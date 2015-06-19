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

        static string username = "";
        static string password = "";
        static string oracleDB = "";
        static string schema = "";
        public string cmdString = "";
        public string filePath = Directory.GetCurrentDirectory() + "\\Exports\\";
        public string fileName = "";
        public OraControl()
        {
            InitializeComponent();
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            var aboutWindow = new About();
            aboutWindow.Show();
        }

        private void cmdMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("cmd", "/x ");
            //var cl = Environment.GetCommandLineArgs();

        }

        private void btnExportSchema_Click(object sender, EventArgs e)
        {
            username = this.txtUsername.Text;
            password = this.txtPassword.Text;
            oracleDB = this.txtOracleDB.Text;
            schema = this.txtSchema.Text;

            string deleteOldBackups = getDeleteFilesScript();

            cmdString = deleteOldBackups + "expdp " + username + "/" + password + "@" + oracleDB +
                        " DIRECTORY=dmpdir DUMPFILE=" + schema + "-Backup.DMP logfile=" +
                        schema + "-Backup.log tablespaces=" + schema;
            fileName = filePath + "export.bat";
            // Create folder dirdump in oracle
            File.WriteAllText(fileName, cmdString);

            if (username == string.Empty)
                MessageBox.Show("Please type the username");
            if (password == string.Empty)
                MessageBox.Show("Please enter the password");
            if (oracleDB == string.Empty)
                MessageBox.Show("Please type the Oracle database name");
            if (schema == string.Empty)
                MessageBox.Show("Please type the Schema");

            bool isReady = false;
            if (username != string.Empty && password != string.Empty && oracleDB != string.Empty && schema != string.Empty)
                isReady = true;

            if (isReady)
            {
                string output = "Start Exporting \"" + username + " from:   (" + oracleDB.ToUpper() + ")\r\n";
                tbOutput.AppendText(output);
                var proc = Process.Start(fileName);
                proc.WaitForExit();
                output = "\r\nExtraction Coplete!";
                tbOutput.AppendText(output);

                // Clearing textboxes
                txtUsername.Text = string.Empty;
                txtPassword.Text = string.Empty;
                txtOracleDB.Text = string.Empty;
                txtSchema.Text = string.Empty;
            }
        }

        private static string getDeleteFilesScript()
        {
            return "SET FileToDelete=\"C:\\Database\\SOCCAA-Backup.DMP\"\n" +
                    "SET LogFileToDelete=\"C:\\Database\\SOCCAA-Backup.LOG\"\n" +
                    "IF EXIST %FileToDelete% del /F %FileToDelete%\n" +
                    "IF EXIST %LogFileToDelete% del /F %LogFileToDelete%\n";
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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
            string scriptString, tablespace, size, autoExtend = "";

            // Getting the values of 'Tablespace' & 'Size'
            tablespace = txtTablespace.Text;
            size = txtSize.Text;

            // Getting the value for Auto-Extend
            if (rbAutoExtendOn.Checked) { autoExtend = "ON"; }
            else if (rbAutoExtendOff.Checked) { autoExtend = "OFF"; }

            scriptString = "CREATE BIGFILE TABLESPACE " + tablespace.ToUpper() + " DATAFILE '" + tablespace.ToUpper() +
                           "01.DBF' SIZE " + size +"M AUTOEXTEND " + autoExtend + ";";

            ProcessStartInfo psi = new ProcessStartInfo("sqlplus");
            psi.UseShellExecute = false;
            psi.RedirectStandardOutput = true;
            psi.CreateNoWindow = false; 
            psi.RedirectStandardInput = true;
            var proc = Process.Start(psi);

            proc.StandardInput.WriteLine(@"SYSTEM/Labware1234@orcl");
            proc.StandardInput.WriteLine("show user");

            //proc.StandardInput.WriteLine(scriptString);
            proc.StandardInput.WriteLine("exit");
            //tbOutput.Text += proc.StandardOutput.ReadLine();
            string s = proc.StandardOutput.ReadToEnd();
            tbOutput.Text = s;
            
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            string scriptString, tablespace, size, autoExtend = "";

            //CREATE USER user IDENTIFIED BY password  DEFAULT TABLESPACE ts  QUOTA xxM ON ts  TEMPORARY TABLESPACE temp PROFILE DEFAULT;
            // GRANT CREATE SESSION, RESOURCE, CONNECT TO TEST;
        }

        private void txtSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private async void btnSendCommand_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo("sqlplus");
            psi.UseShellExecute = false;
            psi.CreateNoWindow = false;
            psi.RedirectStandardInput = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;
            Process proc = Process.Start(psi);

            await proc.StandardInput.WriteLineAsync(tbCommands.Text);
            //await proc.StandardInput.WriteLineAsync("exit");

            //string s = proc.BeginOutputReadLine(); 
            tbOutput.Text = await proc.StandardOutput.ReadToEndAsync();
            

        }

        private void lnkDisconnect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Connect connect = new Connect();
            connect.Show();
        }
    }
}
