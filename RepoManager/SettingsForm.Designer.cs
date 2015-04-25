namespace RepoManager
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFtpPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFtpUsername = new System.Windows.Forms.TextBox();
            this.lblTeamspeakPassword = new System.Windows.Forms.Label();
            this.numFtpPort = new System.Windows.Forms.NumericUpDown();
            this.lblTeamspeakAddress = new System.Windows.Forms.Label();
            this.txtFtpAddress = new System.Windows.Forms.TextBox();
            this.lblTeamspeakPort = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFtpPort)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtFtpPassword);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFtpUsername);
            this.groupBox1.Controls.Add(this.lblTeamspeakPassword);
            this.groupBox1.Controls.Add(this.numFtpPort);
            this.groupBox1.Controls.Add(this.lblTeamspeakAddress);
            this.groupBox1.Controls.Add(this.txtFtpAddress);
            this.groupBox1.Controls.Add(this.lblTeamspeakPort);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 159);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FTP Server";
            // 
            // txtFtpPassword
            // 
            this.txtFtpPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFtpPassword.Location = new System.Drawing.Point(9, 128);
            this.txtFtpPassword.Name = "txtFtpPassword";
            this.txtFtpPassword.Size = new System.Drawing.Size(344, 20);
            this.txtFtpPassword.TabIndex = 33;
            this.txtFtpPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Password:";
            // 
            // txtFtpUsername
            // 
            this.txtFtpUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFtpUsername.Location = new System.Drawing.Point(9, 83);
            this.txtFtpUsername.Name = "txtFtpUsername";
            this.txtFtpUsername.Size = new System.Drawing.Size(344, 20);
            this.txtFtpUsername.TabIndex = 31;
            // 
            // lblTeamspeakPassword
            // 
            this.lblTeamspeakPassword.AutoSize = true;
            this.lblTeamspeakPassword.Location = new System.Drawing.Point(6, 67);
            this.lblTeamspeakPassword.Name = "lblTeamspeakPassword";
            this.lblTeamspeakPassword.Size = new System.Drawing.Size(58, 13);
            this.lblTeamspeakPassword.TabIndex = 30;
            this.lblTeamspeakPassword.Text = "Username:";
            // 
            // numFtpPort
            // 
            this.numFtpPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numFtpPort.Location = new System.Drawing.Point(293, 38);
            this.numFtpPort.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numFtpPort.Name = "numFtpPort";
            this.numFtpPort.Size = new System.Drawing.Size(60, 20);
            this.numFtpPort.TabIndex = 29;
            this.numFtpPort.Value = new decimal(new int[] {
            21,
            0,
            0,
            0});
            // 
            // lblTeamspeakAddress
            // 
            this.lblTeamspeakAddress.AutoSize = true;
            this.lblTeamspeakAddress.Location = new System.Drawing.Point(6, 22);
            this.lblTeamspeakAddress.Name = "lblTeamspeakAddress";
            this.lblTeamspeakAddress.Size = new System.Drawing.Size(48, 13);
            this.lblTeamspeakAddress.TabIndex = 26;
            this.lblTeamspeakAddress.Text = "Address:";
            // 
            // txtFtpAddress
            // 
            this.txtFtpAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFtpAddress.Location = new System.Drawing.Point(9, 38);
            this.txtFtpAddress.Name = "txtFtpAddress";
            this.txtFtpAddress.Size = new System.Drawing.Size(278, 20);
            this.txtFtpAddress.TabIndex = 27;
            // 
            // lblTeamspeakPort
            // 
            this.lblTeamspeakPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTeamspeakPort.AutoSize = true;
            this.lblTeamspeakPort.Location = new System.Drawing.Point(290, 22);
            this.lblTeamspeakPort.Name = "lblTeamspeakPort";
            this.lblTeamspeakPort.Size = new System.Drawing.Size(29, 13);
            this.lblTeamspeakPort.TabIndex = 28;
            this.lblTeamspeakPort.Text = "Port:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(215, 178);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(296, 178);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 213);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFtpPort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFtpUsername;
        private System.Windows.Forms.Label lblTeamspeakPassword;
        private System.Windows.Forms.NumericUpDown numFtpPort;
        private System.Windows.Forms.Label lblTeamspeakAddress;
        private System.Windows.Forms.TextBox txtFtpAddress;
        private System.Windows.Forms.Label lblTeamspeakPort;
        private System.Windows.Forms.TextBox txtFtpPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}