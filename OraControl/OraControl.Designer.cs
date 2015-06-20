namespace OraControl
{
    partial class OraControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OraControl));
            this.OraControlmenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblOracleDB = new System.Windows.Forms.Label();
            this.lblTablespace3 = new System.Windows.Forms.Label();
            this.tbUsernameExpImp = new System.Windows.Forms.TextBox();
            this.tbPasswordExpImp = new System.Windows.Forms.TextBox();
            this.tbOracleDBExpImp = new System.Windows.Forms.TextBox();
            this.tbTablespaceExpImp = new System.Windows.Forms.TextBox();
            this.btnExportSchema = new System.Windows.Forms.Button();
            this.OracontrolsaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rbAutoExtendOff = new System.Windows.Forms.RadioButton();
            this.rbAutoExtendOn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTablespace1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.tbTablespace = new System.Windows.Forms.TextBox();
            this.btnCreateTablespace = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbUnlimitedQuota = new System.Windows.Forms.CheckBox();
            this.lblTableSpace2 = new System.Windows.Forms.Label();
            this.tbTablespaceCreateUser = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPasswordCreateUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblQuota = new System.Windows.Forms.Label();
            this.tbQuotaCreateUser = new System.Windows.Forms.TextBox();
            this.tbUsernameCreateUser = new System.Windows.Forms.TextBox();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnImportSchema = new System.Windows.Forms.Button();
            this.lblDirectoryOBJ = new System.Windows.Forms.Label();
            this.tbDirectoryObject = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnSendCommand = new System.Windows.Forms.Button();
            this.tbCommands = new System.Windows.Forms.TextBox();
            this.btnChooseDirectory = new System.Windows.Forms.Button();
            this.lnkDisconnect = new System.Windows.Forms.LinkLabel();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.OraControlmenuStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // OraControlmenuStrip
            // 
            this.OraControlmenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.OraControlmenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.cmdMenuItem,
            this.aboutMenuItem});
            this.OraControlmenuStrip.Location = new System.Drawing.Point(0, 0);
            this.OraControlmenuStrip.Name = "OraControlmenuStrip";
            this.OraControlmenuStrip.Size = new System.Drawing.Size(710, 28);
            this.OraControlmenuStrip.TabIndex = 0;
            this.OraControlmenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(166, 26);
            this.exitMenuItem.Text = "Disconnect...";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // cmdMenuItem
            // 
            this.cmdMenuItem.Name = "cmdMenuItem";
            this.cmdMenuItem.Size = new System.Drawing.Size(54, 24);
            this.cmdMenuItem.Text = "CMD";
            this.cmdMenuItem.Click += new System.EventHandler(this.cmdMenuItem_Click);
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutMenuItem.Text = "About";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblUsername.Location = new System.Drawing.Point(11, 13);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(86, 20);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPassword.Location = new System.Drawing.Point(14, 44);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(83, 20);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // lblOracleDB
            // 
            this.lblOracleDB.AutoSize = true;
            this.lblOracleDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblOracleDB.Location = new System.Drawing.Point(331, 13);
            this.lblOracleDB.Name = "lblOracleDB";
            this.lblOracleDB.Size = new System.Drawing.Size(89, 20);
            this.lblOracleDB.TabIndex = 2;
            this.lblOracleDB.Text = "Oracle DB";
            // 
            // lblTablespace3
            // 
            this.lblTablespace3.AutoSize = true;
            this.lblTablespace3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTablespace3.Location = new System.Drawing.Point(325, 44);
            this.lblTablespace3.Name = "lblTablespace3";
            this.lblTablespace3.Size = new System.Drawing.Size(95, 20);
            this.lblTablespace3.TabIndex = 2;
            this.lblTablespace3.Text = "Tablespace";
            // 
            // tbUsernameExpImp
            // 
            this.tbUsernameExpImp.Location = new System.Drawing.Point(103, 13);
            this.tbUsernameExpImp.Name = "tbUsernameExpImp";
            this.tbUsernameExpImp.Size = new System.Drawing.Size(175, 26);
            this.tbUsernameExpImp.TabIndex = 0;
            // 
            // tbPasswordExpImp
            // 
            this.tbPasswordExpImp.Location = new System.Drawing.Point(103, 43);
            this.tbPasswordExpImp.Name = "tbPasswordExpImp";
            this.tbPasswordExpImp.PasswordChar = '●';
            this.tbPasswordExpImp.Size = new System.Drawing.Size(175, 26);
            this.tbPasswordExpImp.TabIndex = 1;
            // 
            // tbOracleDBExpImp
            // 
            this.tbOracleDBExpImp.Location = new System.Drawing.Point(426, 11);
            this.tbOracleDBExpImp.Name = "tbOracleDBExpImp";
            this.tbOracleDBExpImp.Size = new System.Drawing.Size(246, 26);
            this.tbOracleDBExpImp.TabIndex = 2;
            // 
            // tbTablespaceExpImp
            // 
            this.tbTablespaceExpImp.Location = new System.Drawing.Point(426, 41);
            this.tbTablespaceExpImp.Name = "tbTablespaceExpImp";
            this.tbTablespaceExpImp.Size = new System.Drawing.Size(246, 26);
            this.tbTablespaceExpImp.TabIndex = 3;
            // 
            // btnExportSchema
            // 
            this.btnExportSchema.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExportSchema.Location = new System.Drawing.Point(103, 73);
            this.btnExportSchema.Name = "btnExportSchema";
            this.btnExportSchema.Size = new System.Drawing.Size(81, 28);
            this.btnExportSchema.TabIndex = 5;
            this.btnExportSchema.Text = "Export";
            this.btnExportSchema.UseVisualStyleBackColor = true;
            this.btnExportSchema.Click += new System.EventHandler(this.btnExportSchema_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabControl1.Location = new System.Drawing.Point(0, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(710, 143);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rbAutoExtendOff);
            this.tabPage1.Controls.Add(this.rbAutoExtendOn);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lblTablespace1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tbSize);
            this.tabPage1.Controls.Add(this.tbTablespace);
            this.tabPage1.Controls.Add(this.btnCreateTablespace);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(702, 110);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Creat Tablespace";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rbAutoExtendOff
            // 
            this.rbAutoExtendOff.AutoSize = true;
            this.rbAutoExtendOff.Location = new System.Drawing.Point(495, 11);
            this.rbAutoExtendOff.Name = "rbAutoExtendOff";
            this.rbAutoExtendOff.Size = new System.Drawing.Size(53, 24);
            this.rbAutoExtendOff.TabIndex = 10;
            this.rbAutoExtendOff.TabStop = true;
            this.rbAutoExtendOff.Text = "Off";
            this.rbAutoExtendOff.UseVisualStyleBackColor = true;
            // 
            // rbAutoExtendOn
            // 
            this.rbAutoExtendOn.AutoSize = true;
            this.rbAutoExtendOn.Location = new System.Drawing.Point(437, 11);
            this.rbAutoExtendOn.Name = "rbAutoExtendOn";
            this.rbAutoExtendOn.Size = new System.Drawing.Size(52, 24);
            this.rbAutoExtendOn.TabIndex = 2;
            this.rbAutoExtendOn.TabStop = true;
            this.rbAutoExtendOn.Text = "On";
            this.rbAutoExtendOn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(332, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Auto Extend";
            // 
            // lblTablespace1
            // 
            this.lblTablespace1.AutoSize = true;
            this.lblTablespace1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTablespace1.Location = new System.Drawing.Point(4, 13);
            this.lblTablespace1.Name = "lblTablespace1";
            this.lblTablespace1.Size = new System.Drawing.Size(95, 20);
            this.lblTablespace1.TabIndex = 8;
            this.lblTablespace1.Text = "Tablespace";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(205, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "MB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(56, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Size";
            // 
            // tbSize
            // 
            this.tbSize.Location = new System.Drawing.Point(103, 43);
            this.tbSize.MaxLength = 4;
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(95, 26);
            this.tbSize.TabIndex = 1;
            this.tbSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSize_KeyPress);
            // 
            // tbTablespace
            // 
            this.tbTablespace.Location = new System.Drawing.Point(103, 13);
            this.tbTablespace.Name = "tbTablespace";
            this.tbTablespace.Size = new System.Drawing.Size(175, 26);
            this.tbTablespace.TabIndex = 0;
            // 
            // btnCreateTablespace
            // 
            this.btnCreateTablespace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCreateTablespace.Location = new System.Drawing.Point(103, 73);
            this.btnCreateTablespace.Name = "btnCreateTablespace";
            this.btnCreateTablespace.Size = new System.Drawing.Size(137, 28);
            this.btnCreateTablespace.TabIndex = 3;
            this.btnCreateTablespace.Text = "Create";
            this.btnCreateTablespace.UseVisualStyleBackColor = true;
            this.btnCreateTablespace.Click += new System.EventHandler(this.btnCreateTablespace_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbUnlimitedQuota);
            this.tabPage2.Controls.Add(this.lblTableSpace2);
            this.tabPage2.Controls.Add(this.tbTablespaceCreateUser);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.tbPasswordCreateUser);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.lblQuota);
            this.tabPage2.Controls.Add(this.tbQuotaCreateUser);
            this.tabPage2.Controls.Add(this.tbUsernameCreateUser);
            this.tabPage2.Controls.Add(this.btnCreateUser);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(702, 110);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Create User";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbUnlimitedQuota
            // 
            this.cbUnlimitedQuota.AutoSize = true;
            this.cbUnlimitedQuota.Location = new System.Drawing.Point(548, 45);
            this.cbUnlimitedQuota.Name = "cbUnlimitedQuota";
            this.cbUnlimitedQuota.Size = new System.Drawing.Size(101, 24);
            this.cbUnlimitedQuota.TabIndex = 20;
            this.cbUnlimitedQuota.Text = "Unlimited";
            this.cbUnlimitedQuota.UseVisualStyleBackColor = true;
            this.cbUnlimitedQuota.CheckedChanged += new System.EventHandler(this.cbUnlimitedQuota_CheckedChanged);
            // 
            // lblTableSpace2
            // 
            this.lblTableSpace2.AutoSize = true;
            this.lblTableSpace2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTableSpace2.Location = new System.Drawing.Point(327, 13);
            this.lblTableSpace2.Name = "lblTableSpace2";
            this.lblTableSpace2.Size = new System.Drawing.Size(95, 20);
            this.lblTableSpace2.TabIndex = 19;
            this.lblTableSpace2.Text = "Tablespace";
            // 
            // tbTablespaceCreateUser
            // 
            this.tbTablespaceCreateUser.Location = new System.Drawing.Point(426, 11);
            this.tbTablespaceCreateUser.Name = "tbTablespaceCreateUser";
            this.tbTablespaceCreateUser.Size = new System.Drawing.Size(223, 26);
            this.tbTablespaceCreateUser.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(14, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Password";
            // 
            // tbPasswordCreateUser
            // 
            this.tbPasswordCreateUser.Location = new System.Drawing.Point(103, 43);
            this.tbPasswordCreateUser.Name = "tbPasswordCreateUser";
            this.tbPasswordCreateUser.PasswordChar = '●';
            this.tbPasswordCreateUser.Size = new System.Drawing.Size(175, 26);
            this.tbPasswordCreateUser.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(11, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(507, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "MB";
            // 
            // lblQuota
            // 
            this.lblQuota.AutoSize = true;
            this.lblQuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblQuota.Location = new System.Drawing.Point(368, 44);
            this.lblQuota.Name = "lblQuota";
            this.lblQuota.Size = new System.Drawing.Size(54, 20);
            this.lblQuota.TabIndex = 15;
            this.lblQuota.Text = "Quota";
            // 
            // tbQuotaCreateUser
            // 
            this.tbQuotaCreateUser.Location = new System.Drawing.Point(426, 41);
            this.tbQuotaCreateUser.MaxLength = 4;
            this.tbQuotaCreateUser.Name = "tbQuotaCreateUser";
            this.tbQuotaCreateUser.Size = new System.Drawing.Size(75, 26);
            this.tbQuotaCreateUser.TabIndex = 11;
            this.tbQuotaCreateUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQuota_KeyPress);
            // 
            // tbUsernameCreateUser
            // 
            this.tbUsernameCreateUser.Location = new System.Drawing.Point(103, 13);
            this.tbUsernameCreateUser.Name = "tbUsernameCreateUser";
            this.tbUsernameCreateUser.Size = new System.Drawing.Size(175, 26);
            this.tbUsernameCreateUser.TabIndex = 10;
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCreateUser.Location = new System.Drawing.Point(103, 73);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(137, 28);
            this.btnCreateUser.TabIndex = 12;
            this.btnCreateUser.Text = "Create";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblUsername);
            this.tabPage3.Controls.Add(this.lblPassword);
            this.tabPage3.Controls.Add(this.lblOracleDB);
            this.tabPage3.Controls.Add(this.btnImportSchema);
            this.tabPage3.Controls.Add(this.btnExportSchema);
            this.tabPage3.Controls.Add(this.lblDirectoryOBJ);
            this.tabPage3.Controls.Add(this.lblTablespace3);
            this.tabPage3.Controls.Add(this.tbPasswordExpImp);
            this.tabPage3.Controls.Add(this.tbDirectoryObject);
            this.tabPage3.Controls.Add(this.tbUsernameExpImp);
            this.tabPage3.Controls.Add(this.tbTablespaceExpImp);
            this.tabPage3.Controls.Add(this.tbOracleDBExpImp);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(702, 110);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Export & Import ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnImportSchema
            // 
            this.btnImportSchema.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnImportSchema.Location = new System.Drawing.Point(197, 73);
            this.btnImportSchema.Name = "btnImportSchema";
            this.btnImportSchema.Size = new System.Drawing.Size(81, 28);
            this.btnImportSchema.TabIndex = 6;
            this.btnImportSchema.Text = "Import";
            this.btnImportSchema.UseVisualStyleBackColor = true;
            this.btnImportSchema.Click += new System.EventHandler(this.btnImportSchema_Click);
            // 
            // lblDirectoryOBJ
            // 
            this.lblDirectoryOBJ.AutoSize = true;
            this.lblDirectoryOBJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDirectoryOBJ.Location = new System.Drawing.Point(325, 73);
            this.lblDirectoryOBJ.Name = "lblDirectoryOBJ";
            this.lblDirectoryOBJ.Size = new System.Drawing.Size(166, 20);
            this.lblDirectoryOBJ.TabIndex = 2;
            this.lblDirectoryOBJ.Text = "Directory OBJ Name";
            // 
            // tbDirectoryObject
            // 
            this.tbDirectoryObject.Location = new System.Drawing.Point(497, 70);
            this.tbDirectoryObject.Name = "tbDirectoryObject";
            this.tbDirectoryObject.Size = new System.Drawing.Size(175, 26);
            this.tbDirectoryObject.TabIndex = 4;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnSendCommand);
            this.tabPage4.Controls.Add(this.tbCommands);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(702, 110);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Command Line";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnSendCommand
            // 
            this.btnSendCommand.Location = new System.Drawing.Point(9, 74);
            this.btnSendCommand.Name = "btnSendCommand";
            this.btnSendCommand.Size = new System.Drawing.Size(109, 32);
            this.btnSendCommand.TabIndex = 1;
            this.btnSendCommand.Text = "Send";
            this.btnSendCommand.UseVisualStyleBackColor = true;
            this.btnSendCommand.Click += new System.EventHandler(this.btnSendCommand_Click);
            // 
            // tbCommands
            // 
            this.tbCommands.AcceptsReturn = true;
            this.tbCommands.Location = new System.Drawing.Point(6, 6);
            this.tbCommands.Multiline = true;
            this.tbCommands.Name = "tbCommands";
            this.tbCommands.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbCommands.Size = new System.Drawing.Size(690, 52);
            this.tbCommands.TabIndex = 0;
            // 
            // btnChooseDirectory
            // 
            this.btnChooseDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnChooseDirectory.Location = new System.Drawing.Point(314, 4);
            this.btnChooseDirectory.Name = "btnChooseDirectory";
            this.btnChooseDirectory.Size = new System.Drawing.Size(191, 28);
            this.btnChooseDirectory.TabIndex = 3;
            this.btnChooseDirectory.Text = "1. Select Directory";
            this.btnChooseDirectory.UseVisualStyleBackColor = true;
            this.btnChooseDirectory.Click += new System.EventHandler(this.btnChooseDirectory_Click);
            // 
            // lnkDisconnect
            // 
            this.lnkDisconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkDisconnect.AutoSize = true;
            this.lnkDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lnkDisconnect.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkDisconnect.Location = new System.Drawing.Point(628, 9);
            this.lnkDisconnect.Name = "lnkDisconnect";
            this.lnkDisconnect.Size = new System.Drawing.Size(83, 18);
            this.lnkDisconnect.TabIndex = 8;
            this.lnkDisconnect.TabStop = true;
            this.lnkDisconnect.Text = "Disconnect";
            this.lnkDisconnect.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDisconnect_LinkClicked);
            // 
            // tbOutput
            // 
            this.tbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOutput.BackColor = System.Drawing.SystemColors.MenuText;
            this.tbOutput.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOutput.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbOutput.Location = new System.Drawing.Point(0, 172);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOutput.Size = new System.Drawing.Size(710, 399);
            this.tbOutput.TabIndex = 7;
            // 
            // OraControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 569);
            this.Controls.Add(this.btnChooseDirectory);
            this.Controls.Add(this.lnkDisconnect);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.OraControlmenuStrip);
            this.Controls.Add(this.tbOutput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.OraControlmenuStrip;
            this.MinimumSize = new System.Drawing.Size(700, 515);
            this.Name = "OraControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OraControl";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OraControl_FormClosed);
            this.Load += new System.EventHandler(this.OraControl_Load);
            this.OraControlmenuStrip.ResumeLayout(false);
            this.OraControlmenuStrip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip OraControlmenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmdMenuItem;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblOracleDB;
        private System.Windows.Forms.Label lblTablespace3;
        private System.Windows.Forms.TextBox tbUsernameExpImp;
        private System.Windows.Forms.TextBox tbPasswordExpImp;
        private System.Windows.Forms.TextBox tbOracleDBExpImp;
        private System.Windows.Forms.TextBox tbTablespaceExpImp;
        private System.Windows.Forms.Button btnExportSchema;
        private System.Windows.Forms.SaveFileDialog OracontrolsaveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnCreateTablespace;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblTablespace1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.TextBox tbTablespace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbAutoExtendOff;
        private System.Windows.Forms.RadioButton rbAutoExtendOn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblQuota;
        private System.Windows.Forms.TextBox tbQuotaCreateUser;
        private System.Windows.Forms.TextBox tbUsernameCreateUser;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPasswordCreateUser;
        private System.Windows.Forms.Label lblTableSpace2;
        private System.Windows.Forms.TextBox tbTablespaceCreateUser;
        private System.Windows.Forms.Button btnSendCommand;
        private System.Windows.Forms.TextBox tbCommands;
        private System.Windows.Forms.LinkLabel lnkDisconnect;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnChooseDirectory;
        private System.Windows.Forms.Label lblDirectoryOBJ;
        private System.Windows.Forms.TextBox tbDirectoryObject;
        private System.Windows.Forms.Button btnImportSchema;
        private System.Windows.Forms.CheckBox cbUnlimitedQuota;
    }
}

