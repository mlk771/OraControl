using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OraControl
{
    public partial class OraControl : Form
    {

        public string connUsername = "";
        public string connPasswrod = "";
        public string connTNS = "";

        static string username = "";
        static string password = "";
        static string oracleDB = "";
        static string schema = "";
        static string tablespace = "";
        public string cmdString = "";
        public string dirPath = "";
        public string filePath = "";
        public string fileName = "";
        public string userQuota = "M";
        public OraControl()
        {
            InitializeComponent();
        }
        private void OraControl_Load(object sender, EventArgs e)
        {
            //enableDisableTableSpaceControls(false);
            tabControl1.Enabled = false;
        }

        //private void enableDisableTableSpaceControls(bool status)
        //{
        //    tbTablespace.Enabled = status;
        //    tbSize.Enabled = status;
        //    rbAutoExtendOn.Enabled = status;
        //    rbAutoExtendOff.Enabled = status;
        //    btnCreateTablespace.Enabled = status;
        //}

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            var aboutWindow = new About();
            aboutWindow.ShowDialog();
        }

        private void cmdMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("cmd", "/x ");
            //var cl = Environment.GetCommandLineArgs();

        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Connect conn = new Connect();
            conn.Show();
        }

        private void btnCMD_Click(object sender, EventArgs e)
        {
            //ProcessStartInfo psi = new ProcessStartInfo("sqlplus");
            //psi.UseShellExecute = false;
            //psi.RedirectStandardOutput = true;
            //psi.CreateNoWindow = false;
            //psi.RedirectStandardInput = true;
            //var proc = Process.Start(psi);

            //proc.StandardInput.WriteLine(@"SOCCAA/SOCCAA@orcl");
            //proc.StandardInput.WriteLine("show user");
            //proc.StandardInput.WriteLine("exit");
            ////tbOutput.Text += proc.StandardOutput.ReadLine();
            //string s = proc.StandardOutput.ReadToEnd();
            //tbOutput.Text = s;
        }

        private void btnCreateTablespace_Click(object sender, EventArgs e)
        {
            string scriptString, size, autoExtend = "";

            // Getting the values of 'Tablespace' & 'Size'
            tablespace = tbTablespace.Text;
            size = tbSize.Text;

            // Getting the value for Auto-Extend
            if (rbAutoExtendOn.Checked) { autoExtend = "ON"; }
            else if (rbAutoExtendOff.Checked) { autoExtend = "OFF"; }

            scriptString = "CREATE BIGFILE TABLESPACE " + tablespace.ToUpper() + " DATAFILE '" + tablespace.ToUpper() +
                           "01.DBF' SIZE " + size + "M AUTOEXTEND " + autoExtend + ";";

            ExecuteScript(scriptString, "");
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            string scriptString1, scriptString2, user, password, tablespace, quote;

            user = tbUsernameCreateUser.Text;
            password = tbPasswordCreateUser.Text;
            tablespace = tbTablespaceCreateUser.Text;

            scriptString1 = "CREATE USER " + user + " IDENTIFIED BY " + password + " DEFAULT TABLESPACE " + tablespace +
                           " QUOTA " + userQuota + " ON " + tablespace + " TEMPORARY TABLESPACE TEMP PROFILE DEFAULT;";

            scriptString2 = "GRANT CREATE SESSION, RESOURCE, CONNECT TO " + user + ";";

            ExecuteScript(scriptString1, scriptString2);
        }

        private void ExecuteScript(string scriptString1, string scriptString2)
        {
            ProcessStartInfo psi = new ProcessStartInfo("sqlplus");
            psi.UseShellExecute = false;
            psi.RedirectStandardOutput = true;
            psi.CreateNoWindow = false;
            psi.RedirectStandardInput = true;
            var proc = Process.Start(psi);

            // Fix Me: need to acquire credentials from "Connect Form"
            proc.StandardInput.WriteLine(@"{0}/{1}@{2}", connUsername, connPasswrod, connTNS);

            proc.StandardInput.WriteLine(scriptString1);
            if (scriptString2 != string.Empty) { proc.StandardInput.WriteLine(scriptString2); }
            proc.StandardInput.WriteLine("exit");
            //tbOutput.Text += proc.StandardOutput.ReadLine();
            tbOutput.AppendText(proc.StandardOutput.ReadToEnd());
            tbOutput.AppendText("\r\n=================\r\n");
        }

        private void btnSendCommand_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo("sqlplus");
            psi.UseShellExecute = false;
            psi.CreateNoWindow = false;
            psi.RedirectStandardInput = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;
            Process proc = Process.Start(psi);

            proc.StandardInput.WriteLine(@"{0}/{1}@{2}", connUsername, connPasswrod, connTNS);
            proc.StandardInput.WriteLine(tbCommands.Text);
            proc.StandardInput.WriteLine(@"exit");
            //await proc.StandardInput.WriteLineAsync("exit");

            //string s = proc.BeginOutputReadLine(); 
            tbOutput.AppendText(proc.StandardOutput.ReadToEnd());
            tbOutput.AppendText("\r\n=================\r\n");
        }

        private void btnExportSchema_Click(object sender, EventArgs e)
        {
            ExportImportSchema("expdp ");
        }

        private void btnImportSchema_Click(object sender, EventArgs e)
        {
            ExportImportSchema("impdp ");
        }

        private void ExportImportSchema(string task)
        {
            username = this.tbUsernameExpImp.Text;
            password = this.tbPasswordExpImp.Text;
            oracleDB = this.tbOracleDBExpImp.Text;
            tablespace = this.tbTablespaceExpImp.Text;
            var dirObjName = this.tbDirectoryObject.Text;
            string taskType = "", cmdString = "";

            // Checking type of task
            if (task == "expdp ") { taskType = "Exporting "; }
            else { taskType = "Importing "; }


            // Create or replace directory object
            string dirObjscript1 = "CREATE OR REPLACE DIRECTORY " + dirObjName + " AS '" + dirPath + "/';";
            string dirObjscript2 = "GRANT READ, WRITE ON DIRECTORY " + dirObjName + " TO " + username + ";";

            ExecuteScript(dirObjscript1, dirObjscript2);
            string deleteOldBackups = getDeleteFilesScript();

            if (task == "expdp ") cmdString = deleteOldBackups;
            cmdString += task + username + "/" + password + "@" + oracleDB +
                        " DIRECTORY=" + dirObjName + " DUMPFILE=" + tablespace + "-Backup.DMP logfile=" +
                        tablespace + "-Backup.log tablespaces=" + tablespace;
            fileName = "";
            fileName = dirPath + "\\export-import.bat";
            // Create folder dirdump in oracle
            File.WriteAllText(fileName, cmdString);

            if (username == string.Empty)
                MessageBox.Show("Please type the username");
            if (password == string.Empty)
                MessageBox.Show("Please enter the password");
            if (oracleDB == string.Empty)
                MessageBox.Show("Please type the Oracle database name");
            if (tablespace == string.Empty)
                MessageBox.Show("Please Type the Tablespace");

            bool isReady = false;
            if (username != string.Empty && password != string.Empty && oracleDB != string.Empty && tablespace != string.Empty)
                isReady = true;

            if (isReady)
            {
                string output = "Start " + taskType + "\"" + username + "\" from:   (" + oracleDB.ToUpper() + ")\r\n";
                tbOutput.AppendText(output);
                var proc = Process.Start(fileName);
                proc.WaitForExit();
                output = "\r\n" + taskType + "Complete!";
                tbOutput.AppendText(output);

                // Clearing textboxes
                /*  tbUsernameExpImp.Text = string.Empty;
                tbPasswordExpImp.Text = string.Empty;
                tbOracleDBExpImp.Text = string.Empty;
                tbTablespaceExpImp.Text = string.Empty;  */
            }
        }

        public string getDeleteFilesScript()
        {
            return "SET FileToDelete=\"" + dirPath + "SOCCAA-Backup.DMP\"\n" +
                    "SET LogFileToDelete=\"" + dirPath + "SOCCAA-Backup.LOG\"\n" +
                    "IF EXIST %FileToDelete% del /F %FileToDelete%\n" +
                    "IF EXIST %LogFileToDelete% del /F %LogFileToDelete%\n";
        }

        private void lnkDisconnect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Connect connect = new Connect();
            connect.Show();
        }

        private void btnChooseDirectory_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            dirPath = folderBrowserDialog1.SelectedPath + "\\";
            if (folderBrowserDialog1.SelectedPath.ToString() != string.Empty)
            {
                //enableDisableTableSpaceControls(true);
                tabControl1.Enabled = true;
            }
        }

        private void tbSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbQuota_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void cbUnlimitedQuota_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUnlimitedQuota.CheckState == CheckState.Checked)
            {
                tbQuotaCreateUser.Enabled = false;
                userQuota = "UNLIMITED";
            }
            else
            {
                tbQuotaCreateUser.Enabled = true;
                userQuota = "M";        // As Megabyte
            }
        }

        private void OraControl_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Connect connect = new Connect();
            connect.Show();
        }
    }
}
