﻿namespace RepoManager
{
    partial class CreateRepoForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtModsSearch = new System.Windows.Forms.TextBox();
            this.lblModsSearch = new System.Windows.Forms.Label();
            this.dgvMods = new System.Windows.Forms.DataGridView();
            this.modName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modIncluded = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.modOptional = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtArmaPassword = new System.Windows.Forms.TextBox();
            this.lblArmaPassword = new System.Windows.Forms.Label();
            this.numArmaPort = new System.Windows.Forms.NumericUpDown();
            this.lblArmaAddress = new System.Windows.Forms.Label();
            this.txtArmaAddress = new System.Windows.Forms.TextBox();
            this.lblArmaPort = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTeamspeakChannelPassword = new System.Windows.Forms.TextBox();
            this.lblTeamspeakChannelPassword = new System.Windows.Forms.Label();
            this.txtTeamspeakChannelId = new System.Windows.Forms.TextBox();
            this.lblTeamspeakChannelId = new System.Windows.Forms.Label();
            this.txtTeamspeakPassword = new System.Windows.Forms.TextBox();
            this.lblTeamspeakPassword = new System.Windows.Forms.Label();
            this.numTeamspeakPort = new System.Windows.Forms.NumericUpDown();
            this.lblTeamspeakAddress = new System.Windows.Forms.Label();
            this.txtTeamspeakAddress = new System.Windows.Forms.TextBox();
            this.lblTeamspeakPort = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errName = new System.Windows.Forms.ErrorProvider(this.components);
            this.prgCreate = new System.Windows.Forms.ProgressBar();
            this.bgwCreate = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMods)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numArmaPort)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTeamspeakPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errName)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(528, 298);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.lblName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(520, 272);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errName.SetIconPadding(this.txtName, -20);
            this.txtName.Location = new System.Drawing.Point(6, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(508, 20);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 7);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtModsSearch);
            this.tabPage2.Controls.Add(this.lblModsSearch);
            this.tabPage2.Controls.Add(this.dgvMods);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(520, 272);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mods";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtModsSearch
            // 
            this.txtModsSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModsSearch.Location = new System.Drawing.Point(53, 7);
            this.txtModsSearch.Name = "txtModsSearch";
            this.txtModsSearch.Size = new System.Drawing.Size(461, 20);
            this.txtModsSearch.TabIndex = 8;
            this.txtModsSearch.TextChanged += new System.EventHandler(this.txtModsSearch_TextChanged);
            // 
            // lblModsSearch
            // 
            this.lblModsSearch.AutoSize = true;
            this.lblModsSearch.Location = new System.Drawing.Point(3, 10);
            this.lblModsSearch.Name = "lblModsSearch";
            this.lblModsSearch.Size = new System.Drawing.Size(44, 13);
            this.lblModsSearch.TabIndex = 7;
            this.lblModsSearch.Text = "Search:";
            // 
            // dgvMods
            // 
            this.dgvMods.AllowUserToAddRows = false;
            this.dgvMods.AllowUserToDeleteRows = false;
            this.dgvMods.AllowUserToResizeRows = false;
            this.dgvMods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMods.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvMods.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMods.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modName,
            this.modIncluded,
            this.modOptional});
            this.dgvMods.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvMods.Location = new System.Drawing.Point(6, 33);
            this.dgvMods.Name = "dgvMods";
            this.dgvMods.RowHeadersVisible = false;
            this.dgvMods.Size = new System.Drawing.Size(508, 233);
            this.dgvMods.TabIndex = 6;
            this.dgvMods.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMods_CellValueChanged);
            this.dgvMods.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvMods_CurrentCellDirtyStateChanged);
            this.dgvMods.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvMods_RowsAdded);
            // 
            // modName
            // 
            this.modName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.modName.DataPropertyName = "name";
            this.modName.HeaderText = "Name";
            this.modName.Name = "modName";
            this.modName.ReadOnly = true;
            this.modName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.modName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // modIncluded
            // 
            this.modIncluded.DataPropertyName = "include";
            this.modIncluded.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modIncluded.HeaderText = "Include";
            this.modIncluded.Name = "modIncluded";
            this.modIncluded.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.modIncluded.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.modIncluded.Width = 58;
            // 
            // modOptional
            // 
            this.modOptional.DataPropertyName = "optional";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.NullValue = false;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            this.modOptional.DefaultCellStyle = dataGridViewCellStyle4;
            this.modOptional.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modOptional.HeaderText = "Optional";
            this.modOptional.Name = "modOptional";
            this.modOptional.ReadOnly = true;
            this.modOptional.Width = 58;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtArmaPassword);
            this.tabPage3.Controls.Add(this.lblArmaPassword);
            this.tabPage3.Controls.Add(this.numArmaPort);
            this.tabPage3.Controls.Add(this.lblArmaAddress);
            this.tabPage3.Controls.Add(this.txtArmaAddress);
            this.tabPage3.Controls.Add(this.lblArmaPort);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(520, 272);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ArmA Server";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtArmaPassword
            // 
            this.txtArmaPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArmaPassword.Location = new System.Drawing.Point(6, 68);
            this.txtArmaPassword.Name = "txtArmaPassword";
            this.txtArmaPassword.Size = new System.Drawing.Size(508, 20);
            this.txtArmaPassword.TabIndex = 27;
            this.txtArmaPassword.UseSystemPasswordChar = true;
            // 
            // lblArmaPassword
            // 
            this.lblArmaPassword.AutoSize = true;
            this.lblArmaPassword.Location = new System.Drawing.Point(3, 52);
            this.lblArmaPassword.Name = "lblArmaPassword";
            this.lblArmaPassword.Size = new System.Drawing.Size(56, 13);
            this.lblArmaPassword.TabIndex = 26;
            this.lblArmaPassword.Text = "Password:";
            // 
            // numArmaPort
            // 
            this.numArmaPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numArmaPort.Location = new System.Drawing.Point(454, 23);
            this.numArmaPort.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numArmaPort.Name = "numArmaPort";
            this.numArmaPort.Size = new System.Drawing.Size(60, 20);
            this.numArmaPort.TabIndex = 17;
            this.numArmaPort.Value = new decimal(new int[] {
            2302,
            0,
            0,
            0});
            // 
            // lblArmaAddress
            // 
            this.lblArmaAddress.AutoSize = true;
            this.lblArmaAddress.Location = new System.Drawing.Point(3, 7);
            this.lblArmaAddress.Name = "lblArmaAddress";
            this.lblArmaAddress.Size = new System.Drawing.Size(48, 13);
            this.lblArmaAddress.TabIndex = 14;
            this.lblArmaAddress.Text = "Address:";
            // 
            // txtArmaAddress
            // 
            this.txtArmaAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArmaAddress.Location = new System.Drawing.Point(6, 23);
            this.txtArmaAddress.Name = "txtArmaAddress";
            this.txtArmaAddress.Size = new System.Drawing.Size(442, 20);
            this.txtArmaAddress.TabIndex = 15;
            // 
            // lblArmaPort
            // 
            this.lblArmaPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArmaPort.AutoSize = true;
            this.lblArmaPort.Location = new System.Drawing.Point(451, 7);
            this.lblArmaPort.Name = "lblArmaPort";
            this.lblArmaPort.Size = new System.Drawing.Size(29, 13);
            this.lblArmaPort.TabIndex = 16;
            this.lblArmaPort.Text = "Port:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Controls.Add(this.txtTeamspeakPassword);
            this.tabPage4.Controls.Add(this.lblTeamspeakPassword);
            this.tabPage4.Controls.Add(this.numTeamspeakPort);
            this.tabPage4.Controls.Add(this.lblTeamspeakAddress);
            this.tabPage4.Controls.Add(this.txtTeamspeakAddress);
            this.tabPage4.Controls.Add(this.lblTeamspeakPort);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(520, 272);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "TeamSpeak Server";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtTeamspeakChannelPassword);
            this.groupBox1.Controls.Add(this.lblTeamspeakChannelPassword);
            this.groupBox1.Controls.Add(this.txtTeamspeakChannelId);
            this.groupBox1.Controls.Add(this.lblTeamspeakChannelId);
            this.groupBox1.Location = new System.Drawing.Point(6, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 115);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Channel";
            // 
            // txtTeamspeakChannelPassword
            // 
            this.txtTeamspeakChannelPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTeamspeakChannelPassword.Location = new System.Drawing.Point(9, 83);
            this.txtTeamspeakChannelPassword.Name = "txtTeamspeakChannelPassword";
            this.txtTeamspeakChannelPassword.Size = new System.Drawing.Size(493, 20);
            this.txtTeamspeakChannelPassword.TabIndex = 33;
            this.txtTeamspeakChannelPassword.UseSystemPasswordChar = true;
            // 
            // lblTeamspeakChannelPassword
            // 
            this.lblTeamspeakChannelPassword.AutoSize = true;
            this.lblTeamspeakChannelPassword.Location = new System.Drawing.Point(6, 67);
            this.lblTeamspeakChannelPassword.Name = "lblTeamspeakChannelPassword";
            this.lblTeamspeakChannelPassword.Size = new System.Drawing.Size(56, 13);
            this.lblTeamspeakChannelPassword.TabIndex = 32;
            this.lblTeamspeakChannelPassword.Text = "Password:";
            // 
            // txtTeamspeakChannelId
            // 
            this.txtTeamspeakChannelId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTeamspeakChannelId.Location = new System.Drawing.Point(9, 38);
            this.txtTeamspeakChannelId.Name = "txtTeamspeakChannelId";
            this.txtTeamspeakChannelId.Size = new System.Drawing.Size(493, 20);
            this.txtTeamspeakChannelId.TabIndex = 31;
            // 
            // lblTeamspeakChannelId
            // 
            this.lblTeamspeakChannelId.AutoSize = true;
            this.lblTeamspeakChannelId.Location = new System.Drawing.Point(6, 22);
            this.lblTeamspeakChannelId.Name = "lblTeamspeakChannelId";
            this.lblTeamspeakChannelId.Size = new System.Drawing.Size(21, 13);
            this.lblTeamspeakChannelId.TabIndex = 30;
            this.lblTeamspeakChannelId.Text = "ID:";
            // 
            // txtTeamspeakPassword
            // 
            this.txtTeamspeakPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTeamspeakPassword.Location = new System.Drawing.Point(6, 68);
            this.txtTeamspeakPassword.Name = "txtTeamspeakPassword";
            this.txtTeamspeakPassword.Size = new System.Drawing.Size(508, 20);
            this.txtTeamspeakPassword.TabIndex = 25;
            this.txtTeamspeakPassword.UseSystemPasswordChar = true;
            // 
            // lblTeamspeakPassword
            // 
            this.lblTeamspeakPassword.AutoSize = true;
            this.lblTeamspeakPassword.Location = new System.Drawing.Point(3, 52);
            this.lblTeamspeakPassword.Name = "lblTeamspeakPassword";
            this.lblTeamspeakPassword.Size = new System.Drawing.Size(56, 13);
            this.lblTeamspeakPassword.TabIndex = 24;
            this.lblTeamspeakPassword.Text = "Password:";
            // 
            // numTeamspeakPort
            // 
            this.numTeamspeakPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numTeamspeakPort.Location = new System.Drawing.Point(454, 23);
            this.numTeamspeakPort.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numTeamspeakPort.Name = "numTeamspeakPort";
            this.numTeamspeakPort.Size = new System.Drawing.Size(60, 20);
            this.numTeamspeakPort.TabIndex = 23;
            this.numTeamspeakPort.Value = new decimal(new int[] {
            9987,
            0,
            0,
            0});
            // 
            // lblTeamspeakAddress
            // 
            this.lblTeamspeakAddress.AutoSize = true;
            this.lblTeamspeakAddress.Location = new System.Drawing.Point(3, 7);
            this.lblTeamspeakAddress.Name = "lblTeamspeakAddress";
            this.lblTeamspeakAddress.Size = new System.Drawing.Size(48, 13);
            this.lblTeamspeakAddress.TabIndex = 20;
            this.lblTeamspeakAddress.Text = "Address:";
            // 
            // txtTeamspeakAddress
            // 
            this.txtTeamspeakAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTeamspeakAddress.Location = new System.Drawing.Point(6, 23);
            this.txtTeamspeakAddress.Name = "txtTeamspeakAddress";
            this.txtTeamspeakAddress.Size = new System.Drawing.Size(442, 20);
            this.txtTeamspeakAddress.TabIndex = 21;
            // 
            // lblTeamspeakPort
            // 
            this.lblTeamspeakPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTeamspeakPort.AutoSize = true;
            this.lblTeamspeakPort.Location = new System.Drawing.Point(451, 7);
            this.lblTeamspeakPort.Name = "lblTeamspeakPort";
            this.lblTeamspeakPort.Size = new System.Drawing.Size(29, 13);
            this.lblTeamspeakPort.TabIndex = 22;
            this.lblTeamspeakPort.Text = "Port:";
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.Enabled = false;
            this.btnCreate.Location = new System.Drawing.Point(465, 316);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 19;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(384, 316);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errName
            // 
            this.errName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errName.ContainerControl = this;
            // 
            // prgCreate
            // 
            this.prgCreate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgCreate.Location = new System.Drawing.Point(12, 316);
            this.prgCreate.Name = "prgCreate";
            this.prgCreate.Size = new System.Drawing.Size(366, 23);
            this.prgCreate.TabIndex = 21;
            this.prgCreate.Visible = false;
            // 
            // bgwCreate
            // 
            this.bgwCreate.WorkerReportsProgress = true;
            this.bgwCreate.WorkerSupportsCancellation = true;
            this.bgwCreate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwCreate_DoWork);
            this.bgwCreate.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwCreate_ProgressChanged);
            this.bgwCreate.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwCreate_RunWorkerCompleted);
            // 
            // CreateRepoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 351);
            this.Controls.Add(this.prgCreate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.tabControl1);
            this.Name = "CreateRepoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Repository";
            this.Load += new System.EventHandler(this.CreateRepoForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMods)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numArmaPort)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTeamspeakPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvMods;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.NumericUpDown numArmaPort;
        private System.Windows.Forms.Label lblArmaAddress;
        private System.Windows.Forms.TextBox txtArmaAddress;
        private System.Windows.Forms.Label lblArmaPort;
        private System.Windows.Forms.TextBox txtTeamspeakPassword;
        private System.Windows.Forms.Label lblTeamspeakPassword;
        private System.Windows.Forms.NumericUpDown numTeamspeakPort;
        private System.Windows.Forms.Label lblTeamspeakAddress;
        private System.Windows.Forms.TextBox txtTeamspeakAddress;
        private System.Windows.Forms.Label lblTeamspeakPort;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTeamspeakChannelPassword;
        private System.Windows.Forms.Label lblTeamspeakChannelPassword;
        private System.Windows.Forms.TextBox txtTeamspeakChannelId;
        private System.Windows.Forms.Label lblTeamspeakChannelId;
        private System.Windows.Forms.TextBox txtModsSearch;
        private System.Windows.Forms.Label lblModsSearch;
        private System.Windows.Forms.TextBox txtArmaPassword;
        private System.Windows.Forms.Label lblArmaPassword;
        private System.Windows.Forms.ErrorProvider errName;
        private System.Windows.Forms.DataGridViewTextBoxColumn modName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn modIncluded;
        private System.Windows.Forms.DataGridViewCheckBoxColumn modOptional;
        private System.Windows.Forms.ProgressBar prgCreate;
        private System.ComponentModel.BackgroundWorker bgwCreate;
    }
}