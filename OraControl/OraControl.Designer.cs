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
            this.OraControlmenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblOracleDB = new System.Windows.Forms.Label();
            this.lblSchema = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtOracleDB = new System.Windows.Forms.TextBox();
            this.txtSchema = new System.Windows.Forms.TextBox();
            this.btnExportSchema = new System.Windows.Forms.Button();
            this.OracontrolsaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCreateTablespace = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.lblTablespace = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtTablespace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbAutoExtendOn = new System.Windows.Forms.RadioButton();
            this.rbAutoExtendOff = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.OraControlmenuStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.OraControlmenuStrip.Size = new System.Drawing.Size(688, 28);
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
            this.exitMenuItem.Size = new System.Drawing.Size(181, 26);
            this.exitMenuItem.Text = "Exit";
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
            this.lblUsername.Location = new System.Drawing.Point(6, 13);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(86, 20);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPassword.Location = new System.Drawing.Point(9, 44);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(83, 20);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // lblOracleDB
            // 
            this.lblOracleDB.AutoSize = true;
            this.lblOracleDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblOracleDB.Location = new System.Drawing.Point(326, 13);
            this.lblOracleDB.Name = "lblOracleDB";
            this.lblOracleDB.Size = new System.Drawing.Size(89, 20);
            this.lblOracleDB.TabIndex = 2;
            this.lblOracleDB.Text = "Oracle DB";
            // 
            // lblSchema
            // 
            this.lblSchema.AutoSize = true;
            this.lblSchema.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSchema.Location = new System.Drawing.Point(345, 44);
            this.lblSchema.Name = "lblSchema";
            this.lblSchema.Size = new System.Drawing.Size(70, 20);
            this.lblSchema.TabIndex = 2;
            this.lblSchema.Text = "Schema";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(113, 13);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(175, 22);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(113, 41);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(175, 22);
            this.txtPassword.TabIndex = 1;
            // 
            // txtOracleDB
            // 
            this.txtOracleDB.Location = new System.Drawing.Point(421, 11);
            this.txtOracleDB.Name = "txtOracleDB";
            this.txtOracleDB.Size = new System.Drawing.Size(175, 22);
            this.txtOracleDB.TabIndex = 2;
            // 
            // txtSchema
            // 
            this.txtSchema.Location = new System.Drawing.Point(421, 39);
            this.txtSchema.Name = "txtSchema";
            this.txtSchema.Size = new System.Drawing.Size(175, 22);
            this.txtSchema.TabIndex = 3;
            // 
            // btnExportSchema
            // 
            this.btnExportSchema.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExportSchema.Location = new System.Drawing.Point(113, 69);
            this.btnExportSchema.Name = "btnExportSchema";
            this.btnExportSchema.Size = new System.Drawing.Size(137, 28);
            this.btnExportSchema.TabIndex = 4;
            this.btnExportSchema.Text = "Export Schema";
            this.btnExportSchema.UseVisualStyleBackColor = true;
            this.btnExportSchema.Click += new System.EventHandler(this.btnExportSchema_Click);
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
            this.tabControl1.Location = new System.Drawing.Point(0, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(688, 207);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblUsername);
            this.tabPage3.Controls.Add(this.lblPassword);
            this.tabPage3.Controls.Add(this.lblOracleDB);
            this.tabPage3.Controls.Add(this.btnExportSchema);
            this.tabPage3.Controls.Add(this.lblSchema);
            this.tabPage3.Controls.Add(this.txtPassword);
            this.tabPage3.Controls.Add(this.txtUsername);
            this.tabPage3.Controls.Add(this.txtSchema);
            this.tabPage3.Controls.Add(this.txtOracleDB);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(680, 178);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Export & Import ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rbAutoExtendOff);
            this.tabPage1.Controls.Add(this.rbAutoExtendOn);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lblTablespace);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtSize);
            this.tabPage1.Controls.Add(this.txtTablespace);
            this.tabPage1.Controls.Add(this.btnCreateTablespace);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(680, 178);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Creat Tablespace";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCreateTablespace
            // 
            this.btnCreateTablespace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCreateTablespace.Location = new System.Drawing.Point(113, 69);
            this.btnCreateTablespace.Name = "btnCreateTablespace";
            this.btnCreateTablespace.Size = new System.Drawing.Size(111, 28);
            this.btnCreateTablespace.TabIndex = 5;
            this.btnCreateTablespace.Text = "Create";
            this.btnCreateTablespace.UseVisualStyleBackColor = true;
            this.btnCreateTablespace.Click += new System.EventHandler(this.btnCreateTablespace_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(680, 178);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Create User";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.tbOutput.Size = new System.Drawing.Size(688, 399);
            this.tbOutput.TabIndex = 7;
            // 
            // lblTablespace
            // 
            this.lblTablespace.AutoSize = true;
            this.lblTablespace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTablespace.Location = new System.Drawing.Point(6, 13);
            this.lblTablespace.Name = "lblTablespace";
            this.lblTablespace.Size = new System.Drawing.Size(86, 20);
            this.lblTablespace.TabIndex = 8;
            this.lblTablespace.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(50, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Size";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(113, 41);
            this.txtSize.MaxLength = 4;
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(95, 22);
            this.txtSize.TabIndex = 7;
            this.txtSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSize_KeyPress);
            // 
            // txtTablespace
            // 
            this.txtTablespace.Location = new System.Drawing.Point(113, 13);
            this.txtTablespace.Name = "txtTablespace";
            this.txtTablespace.Size = new System.Drawing.Size(175, 22);
            this.txtTablespace.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(326, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Auto Extend";
            // 
            // rbAutoExtendOn
            // 
            this.rbAutoExtendOn.AutoSize = true;
            this.rbAutoExtendOn.Location = new System.Drawing.Point(441, 12);
            this.rbAutoExtendOn.Name = "rbAutoExtendOn";
            this.rbAutoExtendOn.Size = new System.Drawing.Size(48, 21);
            this.rbAutoExtendOn.TabIndex = 10;
            this.rbAutoExtendOn.TabStop = true;
            this.rbAutoExtendOn.Text = "On";
            this.rbAutoExtendOn.UseVisualStyleBackColor = true;
            // 
            // rbAutoExtendOff
            // 
            this.rbAutoExtendOff.AutoSize = true;
            this.rbAutoExtendOff.Location = new System.Drawing.Point(495, 13);
            this.rbAutoExtendOff.Name = "rbAutoExtendOff";
            this.rbAutoExtendOff.Size = new System.Drawing.Size(48, 21);
            this.rbAutoExtendOff.TabIndex = 10;
            this.rbAutoExtendOff.TabStop = true;
            this.rbAutoExtendOff.Text = "Off";
            this.rbAutoExtendOff.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(214, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "MB";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(680, 178);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "command Line";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // OraControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 569);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.OraControlmenuStrip);
            this.MainMenuStrip = this.OraControlmenuStrip;
            this.Name = "OraControl";
            this.Text = "OraControl";
            this.OraControlmenuStrip.ResumeLayout(false);
            this.OraControlmenuStrip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        private System.Windows.Forms.Label lblSchema;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtOracleDB;
        private System.Windows.Forms.TextBox txtSchema;
        private System.Windows.Forms.Button btnExportSchema;
        private System.Windows.Forms.SaveFileDialog OracontrolsaveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnCreateTablespace;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Label lblTablespace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtTablespace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbAutoExtendOff;
        private System.Windows.Forms.RadioButton rbAutoExtendOn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage4;
    }
}

