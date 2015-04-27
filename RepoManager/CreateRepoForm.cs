using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RepoManager
{
    public partial class CreateRepoForm : Form
    {
        Repo repo;

        public CreateRepoForm()
        {
            InitializeComponent();

            repo = new Repo();
        }

        public CreateRepoForm(string repoFile)
        {
            InitializeComponent();

            this.repo = Repo.FromFile(repoFile);
            this.Text = "Edit Repository";
            this.btnCreate.Text = "Save";
        }

        private void CreateRepoForm_Load(object sender, EventArgs e)
        {
            txtName.Text = repo.Name;
            txtArmaAddress.Text = repo.ArmaServer.Address;
            numArmaPort.Value = repo.ArmaServer.Port;
            txtArmaPassword.Text = repo.ArmaServer.Password;
            txtTeamspeakAddress.Text = repo.TeamspeakServer.Address;
            numTeamspeakPort.Value = repo.TeamspeakServer.Port;
            txtTeamspeakPassword.Text = repo.TeamspeakServer.Password;
            txtTeamspeakChannelId.Text = repo.TeamspeakServer.ChannelId;
            txtTeamspeakChannelPassword.Text = repo.TeamspeakServer.ChannelPassword;
            
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("name", typeof(string));
            dataTable.Columns.Add("include", typeof(bool));
            dataTable.Columns.Add("optional", typeof(bool));
            foreach (string dir in Directory.GetDirectories(Directory.GetCurrentDirectory(), "@*"))
            {
                var modName = new DirectoryInfo(dir).Name;

                bool modIncluded = false;
                foreach (Mod mod in this.repo.Mods)
                {
                    if (mod.Name == modName)
                    {
                        modIncluded = true;
                        dataTable.Rows.Add(mod.Name, true, mod.Optional);
                        break;
                    }
                }

                if (!modIncluded)
                    dataTable.Rows.Add(modName, false, false);
            }
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            bindingSource.Sort = "include DESC, name ASC";
            dgvMods.DataSource = bindingSource;

            dgvMods.DefaultCellStyle.SelectionBackColor = dgvMods.DefaultCellStyle.BackColor;
            dgvMods.DefaultCellStyle.SelectionForeColor = dgvMods.DefaultCellStyle.ForeColor;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bgwCreate.CancelAsync();
            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            string error = null;
            if (!Regex.IsMatch(txtName.Text, "^[a-zA-Z0-9_-]*$"))
                error = "Allowed characters: a-zA-Z0-9_-";
            errName.SetError((Control)sender, error);

            btnCreate.Enabled = (error == null && txtName.Text.Trim().Length > 0);
        }

        private void txtModsSearch_TextChanged(object sender, EventArgs e)
        {
            var bindingSource = (BindingSource)dgvMods.DataSource;
            bindingSource.Filter = string.Format("name LIKE '%{0}%'", txtModsSearch.Text.Trim());
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            btnCreate.Enabled = false;
            prgCreate.Visible = true;

            bgwCreate.RunWorkerAsync(txtName.Text);
        }

        private void bgwCreate_DoWork(object sender, DoWorkEventArgs e)
        {
            Repo repo = new Repo();
            repo.Name = (string)e.Argument;
            repo.ArmaServer.Address = txtArmaAddress.Text;
            repo.ArmaServer.Port = (int)numArmaPort.Value;
            repo.ArmaServer.Password = txtArmaPassword.Text;
            repo.TeamspeakServer.Address = txtTeamspeakAddress.Text;
            repo.TeamspeakServer.Port = (int)numTeamspeakPort.Value;
            repo.TeamspeakServer.Password = txtTeamspeakPassword.Text;
            repo.TeamspeakServer.ChannelId = txtTeamspeakChannelId.Text;
            repo.TeamspeakServer.ChannelPassword = txtTeamspeakChannelPassword.Text;

            DataRowCollection modRows = ((DataTable)((BindingSource)dgvMods.DataSource).DataSource).Rows;
            foreach (DataRow modRow in modRows)
            {
                bool modIncluded = (bool)modRow.ItemArray[1];
                if (!modIncluded) continue;

                Mod mod = new Mod();
                mod.Name = (string)modRow.ItemArray[0];
                mod.Optional = (bool)modRow.ItemArray[2];

                string[] filePaths = Directory.GetFiles(mod.Name, "*.*", SearchOption.AllDirectories);
                foreach (string filePath in filePaths)
                {
                    ModFileInfo cachedFileInfo = (FileCache.Files.ContainsKey(filePath) ? FileCache.Files[filePath] : new ModFileInfo());
                    DateTime lastModified = File.GetLastWriteTimeUtc(filePath);

                    ModFile modFile;
                    if (lastModified == cachedFileInfo.LastModified)
                    {
                        modFile = new ModFile(filePath, cachedFileInfo.Checksum);
                    }
                    else
                    {
                        modFile = new ModFile(filePath);
                        FileCache.Files[filePath] = new ModFileInfo(modFile.Checksum, lastModified);
                    }
                    mod.Files.Add(modFile);

                    float modProgress = 100.0f * repo.Mods.Count / modRows.Count;
                    float fileProgress = 100.0f * mod.Files.Count / filePaths.Length;
                    float progress = modProgress + 1.0f / modRows.Count * fileProgress;
                    bgwCreate.ReportProgress((int)progress);
                }

                FileCache.Save();
                repo.Mods.Add(mod);
            }

            repo.Save(".c&p/repos/" + repo.Name + ".json");
        }

        private void bgwCreate_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            prgCreate.Value = e.ProgressPercentage;
        }

        private void bgwCreate_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Close();
        }

        private void updateCheckboxState(int rowIndex)
        {
            var currentRow = dgvMods.Rows[rowIndex];
            var modOptionalCell = currentRow.Cells["modOptional"];
            modOptionalCell.ReadOnly = !(bool)currentRow.Cells["modIncluded"].Value;
            modOptionalCell.Value = (modOptionalCell.ReadOnly ? false : modOptionalCell.Value);
            modOptionalCell.Style.ForeColor = (modOptionalCell.ReadOnly ? Color.FromName("ControlLight") : Color.Black);
            modOptionalCell.Style.SelectionForeColor = modOptionalCell.Style.ForeColor;

            int numIncludedMods = 0;
            foreach (DataGridViewRow row in dgvMods.Rows)
                numIncludedMods += ((bool)row.Cells["modIncluded"].Value ? 1 : 0);
            tabMods.Text = "Mods (" + numIncludedMods + ")";
        }

        private void dgvMods_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int rowIndex = e.RowIndex; rowIndex < e.RowIndex + e.RowCount; rowIndex++)
                this.updateCheckboxState(rowIndex);
        }

        private void dgvMods_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMods.Columns[e.ColumnIndex].Name == "modIncluded")
                this.updateCheckboxState(e.RowIndex);

            txtModsSearch.SelectAll();
            txtModsSearch.Focus();
        }

        private void dgvMods_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvMods.IsCurrentCellDirty)
                dgvMods.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void tabGeneral_Enter(object sender, EventArgs e)
        {
            txtName.Select();
        }

        private void tabMods_Enter(object sender, EventArgs e)
        {
            txtModsSearch.Select();
        }

        private void tabTeamspeak_Enter(object sender, EventArgs e)
        {
            txtTeamspeakAddress.Select();
        }

        private void tabArma_Enter(object sender, EventArgs e)
        {
            txtArmaAddress.Select();
        }
    }
}
