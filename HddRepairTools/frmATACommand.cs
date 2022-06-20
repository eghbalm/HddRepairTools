using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace HddRepairTools
{
    public partial class frmATACommand : Form
    {
        PortIo pi;
        IDEREGS irs = new IDEREGS();
        public frmATACommand(PortIo PI)
        {
            InitializeComponent();
            pi = PI;
        }
        private void btnClearBuf_Click(object sender, EventArgs e)
        {
            pi.clearBuffer();
            lblbuf.Text = "0";
        }

        private void btnSendCmd_Click(object sender, EventArgs e)
        {
            irs.Features = UInt32.Parse(txtFet.Text, System.Globalization.NumberStyles.HexNumber);
            irs.SectorCount = UInt32.Parse(txtSec.Text, System.Globalization.NumberStyles.HexNumber);
            irs.SectorNumber = UInt32.Parse(txtLow.Text, System.Globalization.NumberStyles.HexNumber);
            irs.CylinderLow = UInt32.Parse(txtMid.Text, System.Globalization.NumberStyles.HexNumber);
            irs.CylinderHigh = UInt32.Parse(txtHight.Text, System.Globalization.NumberStyles.HexNumber);
            irs.DriveHead = UInt32.Parse(txtDev.Text, System.Globalization.NumberStyles.HexNumber);
            irs.Command = UInt32.Parse(txtCmd.Text, System.Globalization.NumberStyles.HexNumber);
            irs.Reserved = UInt32.Parse(txtres.Text, System.Globalization.NumberStyles.HexNumber);
            pi.SendATACommand(irs);
        }

        private void btnHDDToBuffer_Click(object sender, EventArgs e)
        {
            bool can = pi.SectorsTo(pi.TempfileName);
            if (can)
            {
                FileInfo finf = new FileInfo(pi.TempfileName);
                lblbuf.Text = finf.Length.ToString();
                finf = null;
            }
            else
            {
                pi.clearBuffer();
            }
        }

        private void btnBufferToHDD_Click(object sender, EventArgs e)
        {
            bool can = pi.SectorsFrom(pi.TempfileName);
            if (!can)
            {
                MessageBox.Show("Can Not Send To HDD", "Error");
            }
        }

        private void btnSaveBuffer_Click(object sender, EventArgs e)
        {
            if (File.Exists(pi.TempfileName))
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Bin files (*.bin)|*.bin|All files (*.*)|*.*";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string namef = sfd.FileName;
                    if (File.Exists(namef))
                    {
                        DialogResult drs = MessageBox.Show("this file already exists . owerrite this ?", "Danger");
                        if (drs == DialogResult.OK)
                        {
                            try
                            {
                                File.Delete(namef);
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Access Denied. try enother path", "Error");
                            }
                        }
                    }
                    try
                    {
                        File.Copy(pi.TempfileName, namef);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Access Denied. try enother path", "Error");
                    }
                }
                sfd = null;
            }
        }

        private void btnHDDToFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Bin files (*.bin)|*.bin|All files (*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                bool yess = pi.SectorsTo(sfd.FileName);
                if (yess)
                {
                    MessageBox.Show("Get From HDD Successfull.", "Success");
                }
                else
                {
                    MessageBox.Show("Get From HDD Error.", "Errror");
                }
            }
            sfd = null;
        }

        private void btnFileToHDD_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                bool canwrt = pi.SectorsFrom(ofd.FileName);
                if (!canwrt)
                {
                    MessageBox.Show("Can Not Send To HDD", "Error");
                }
            }
            ofd = null;
        }

        private void btnFileToBuffer_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (File.GetAttributes(ofd.FileName) != FileAttributes.Hidden)
                {
                    if (File.Exists(pi.TempfileName))
                    {
                        try
                        {
                            File.Delete(pi.TempfileName);
                        }
                        catch (Exception)
                        {
                            File.SetAttributes(pi.TempfileName, FileAttributes.Normal);
                        }

                    }
                    File.Copy(ofd.FileName, pi.TempfileName, true);
                    FileInfo finf = new FileInfo(pi.TempfileName);
                    lblbuf.Text = finf.Length.ToString();
                    finf = null;
                }
            }
            ofd = null;
        }

        private void btnShowBuffer_Click(object sender, EventArgs e)
        {
            if (File.Exists(pi.TempfileName))
            {
                frmDump frd = new frmDump(pi.TempfileName);
                frd.ShowDialog();
                FileInfo finf = new FileInfo(pi.TempfileName);
                lblbuf.Text = finf.Length.ToString();
                finf = null;
            }
        }

        private void frmATACommand_Load(object sender, EventArgs e)
        {
            pi.clearBuffer();
        }

        private void frmATACommand_FormClosing(object sender, FormClosingEventArgs e)
        {
            pi.clearBuffer();
        }

    }
}
