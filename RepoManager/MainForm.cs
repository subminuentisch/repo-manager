using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace RepoManager
{
    public partial class MainForm : Form
    {
        Settings settings;

        public MainForm()
        {
            InitializeComponent();

            settings = Settings.Load();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DirectoryInfo info = Directory.CreateDirectory(".c&p");
            info.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
            Directory.CreateDirectory(".c&p/repos");

            refreshRepos();
        }

        private void refreshRepos()
        {
            dgvRepos.Rows.Clear();

            foreach (string repoFile in Directory.GetFiles(".c&p/repos"))
            {
                dgvRepos.Rows.Add(repoFile, Path.GetFileNameWithoutExtension(repoFile));
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            new CreateRepoForm().ShowDialog();
            refreshRepos();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string repoFile = (string)dgvRepos.SelectedRows[0].Cells["repoPath"].Value;
            new CreateRepoForm(repoFile).ShowDialog();
            refreshRepos();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            System.IO.File.Delete((string)dgvRepos.SelectedRows[0].Cells["repoPath"].Value);
            refreshRepos();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new SettingsForm(settings)).ShowDialog();
            updateCopyUrlState();
        }

        private void dgvRepos_SelectionChanged(object sender, EventArgs e)
        {
            btnEdit.Enabled = (dgvRepos.SelectedRows.Count == 1);
            btnDelete.Enabled = btnEdit.Enabled;
            updateCopyUrlState();
        }

        private void updateCopyUrlState()
        {
            if (settings.FtpServer.Address.Trim() == "")
            {
                btnCopyUrl.Enabled = false;
                errMissingFtp.SetError(btnCopyUrl, "Server details missing (Edit -> Settings -> FTP Server).");
            }
            else
            {
                btnCopyUrl.Enabled = (dgvRepos.SelectedRows.Count == 1);
                errMissingFtp.SetError(btnCopyUrl, null);
            }
        }

        private void btnCopyUrl_Click(object sender, EventArgs e)
        {
            string escapedRepoName = Uri.EscapeDataString((string)dgvRepos.SelectedRows[0].Cells["repoName"].Value);
            string escapedUsername = Uri.EscapeDataString(settings.FtpServer.Username.Trim());
            string escapedPassword = Uri.EscapeDataString(settings.FtpServer.Password);
            string credentials = (escapedUsername == "" ? "" :
                (escapedPassword == "" ? escapedUsername + "@" : escapedUsername + ":" + escapedPassword + "@"));
            Clipboard.SetText("click-play://" + credentials + settings.FtpServer.Address + ":" +
                settings.FtpServer.Port + "/" + escapedRepoName);
        }

        private void documentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/armabake/repo-manager/wiki");
        }

        private void bugTrackerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/armabake/repo-manager/issues");
        }
    }
}
