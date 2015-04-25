using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace RepoManager
{
    public partial class SettingsForm : Form
    {
        Settings settings;

        public SettingsForm(Settings settings)
        {
            InitializeComponent();

            this.settings = settings;
            txtFtpAddress.Text = settings.FtpServer.Address;
            numFtpPort.Value = settings.FtpServer.Port;
            txtFtpUsername.Text = settings.FtpServer.Username;
            txtFtpPassword.Text = settings.FtpServer.Password;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            settings.FtpServer.Address = txtFtpAddress.Text;
            settings.FtpServer.Port = (int)numFtpPort.Value;
            settings.FtpServer.Username = txtFtpUsername.Text;
            settings.FtpServer.Password = txtFtpPassword.Text;
            settings.Save();

            Close();
        }
    }
}
