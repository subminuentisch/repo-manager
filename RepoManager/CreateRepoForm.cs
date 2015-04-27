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
        DataTable modsTable = new DataTable();

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
            
            modsTable.Columns.Add("name", typeof(string));
            modsTable.Columns.Add("status", typeof(string));
            foreach (string dir in Directory.GetDirectories(Directory.GetCurrentDirectory(), "@*"))
            {
                var modName = new DirectoryInfo(dir).Name;

                bool modIncluded = false;
                foreach (Mod mod in this.repo.Mods)
                {
                    if (mod.Name == modName)
                    {
                        modIncluded = true;
                        modsTable.Rows.Add(mod.Name, mod.Optional ? "Optional" : "Required");
                        break;
                    }
                }

                if (!modIncluded)
                    modsTable.Rows.Add(modName, "");
            }
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = modsTable;
            bindingSource.Sort = "status DESC, name ASC";
            dgvMods.DataSource = bindingSource;

            dgvMods.DefaultCellStyle.SelectionBackColor = dgvMods.DefaultCellStyle.BackColor;
            dgvMods.DefaultCellStyle.SelectionForeColor = dgvMods.DefaultCellStyle.ForeColor;

            updateModCount();
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
            (dgvMods.DataSource as BindingSource).Filter = string.Format("name LIKE '%{0}%'", txtModsSearch.Text.Trim());
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

            foreach (DataRow modRow in modsTable.Rows)
            {
                string modStatus = modRow.ItemArray[1].ToString();
                if (modStatus == "") continue;

                Mod mod = new Mod();
                mod.Name = (string)modRow.ItemArray[0];
                mod.Optional = (modStatus == "Optional");

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

                    // TODO: Implement properly, this is terrible. repo.Mods.Count includes mods that aren't even included.
                    float modProgress = 100.0f * repo.Mods.Count / modsTable.Rows.Count;
                    float fileProgress = 100.0f * mod.Files.Count / filePaths.Length;
                    float progress = modProgress + 1.0f / modsTable.Rows.Count * fileProgress;
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

        private void updateModCount()
        {
            int numModsRepo = 0;
            foreach (DataRow row in modsTable.Rows)
                numModsRepo += (row.ItemArray[1].ToString() != "" ? 1 : 0);
            tabMods.Text = "Mods (" + numModsRepo + ")";
        }

        private void dgvMods_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            updateModCount();

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
