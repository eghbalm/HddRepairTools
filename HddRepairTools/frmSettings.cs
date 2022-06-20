using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HddRepairTools
{
    public partial class frmSettings : Form
    {
        PortIo pi;
        public frmSettings(PortIo PI)
        {            
            InitializeComponent();
            pi = PI;           
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            lbWD.Text = pi.WorkDir;
            LBA28.Checked = pi.lba28;           
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {           
            pi.Waittime = int.Parse(waitNum.Text);
            pi.WorkDir = lbWD.Text;
            if (LBA28.Checked)
            {
                pi.lba28 = true;
            }
            else
            {
                pi.lba28 = false;
            }            
            //pi.idsector.IdentityDevice();
            this.Close();
        }

        private void textPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).SelectedText != "")
            {
                int a, ss;
                ss = (sender as TextBox).SelectionStart;
                a = (sender as TextBox).SelectionLength;
                (sender as TextBox).Text = (sender as TextBox).Text.Remove(ss, a);
                if (ss > 0)
                {
                    (sender as TextBox).SelectionStart = ss;
                    (sender as TextBox).SelectionLength = 0;
                }
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            !((e.KeyChar > 64) && (e.KeyChar < 71)) && !((e.KeyChar > 96) && (e.KeyChar < 103)))
            {
                e.Handled = true;
            }
            if ((sender as TextBox).Text != "")
            {
                if ((e.KeyChar != (char)Keys.Back) && (sender as TextBox).Text.Length > 3)
                {
                    e.Handled = true;
                }

            }
        }

        private void textPort_Leave(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == "")
            {
                (sender as TextBox).Text = "0";
            }
        }

        private void waitNum_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < waitNum.Text.Length; i++)
            {
                if (!char.IsControl(waitNum.Text[i]) && !char.IsDigit(waitNum.Text[i]))
                {
                    waitNum.Text = "0";
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult dl=fbd.ShowDialog();
            if (dl==DialogResult.OK)
            {
                pi.WorkDir = fbd.SelectedPath;
                lbWD.Text = fbd.SelectedPath;
            }
            fbd.Dispose();
            fbd = null;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbWD_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(lbWD.Text, lbWD,-10,-40,2000);
        }
    }
}
