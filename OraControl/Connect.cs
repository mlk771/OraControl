using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OraControl
{
    public partial class Connect : Form
    {
        public Connect()
        {
            InitializeComponent();
        }

        private void FormClosing_click(object sender, FormClosingEventArgs e)
        {
            // Maintaining App memory
            if (logoPictureBox != null && logoPictureBox.Image != null)
            {
                // We don't want to dispose the initial image
                // Hence, need to check if the image is different to initial image
                if (logoPictureBox.Image.GetHashCode() != logoPictureBox.InitialImage.GetHashCode())
                {
                    logoPictureBox.Image.Dispose();
                }
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            OraControl oc = new OraControl();
            try
            {
                oc.connUsername = tbUsernameCon.Text;
                oc.connPasswrod = tbPasswordCon.Text;
                oc.connTNS = tbTnsName.Text;
            }
            catch (Exception)
            {
                throw;
            }
            if (oc.connUsername == string.Empty || oc.connPasswrod == string.Empty || oc.connTNS == string.Empty)
            {
                MessageBox.Show("Please make sure you typed all values");
            } else
            {
                oc.Show();
                this.Hide();
            }
        }

        private void Connect_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread(); 
            Application.Exit();
        }

        private void logoPictureBox_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
    }
}
