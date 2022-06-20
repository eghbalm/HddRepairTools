/*
 # HddsRepairTools

Created by eghbal mohammadi
Mail = eghbalm1362@gmail.com
Company = PicoSystem
Mobile = 09187843531

Create progect with c# and in visual studio 2010

Note
1 - this app suported mhdd scripts
2 - this app correctly run in 32bit operation system
3 - Use the victoria or ideterminal program to find the sata port number
4 - ideterminal program is attached to project
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;

namespace HddRepairTools
{
    public unsafe partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        PortIo pi;
        frmMonitoring fMonitoring;
        frmSettings fSettings;
        frmATACommand fatacom;
        frmScripts fScript;
        frmATACommands fatacoms;
        EraseHdd EH;
        CreateImageHdd CI;
        frmPortList fpl;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (pi == null)
            {
                pi = new PortIo();
            }
            pi.WorkDir = Application.StartupPath;

            fpl = new frmPortList(pi);
            fpl.Top = this.Top;
            fpl.Left = this.Left;
            fpl.Show();
        }
        private void Monitorings()
        {
            UInt32 Error;
            UInt32 Status;
            Error = 0;
            pi.WI.GetPortValue((UInt16)(pi.GetPortIO() + 1), &Error, 1);
            Status = 0;
            pi.WI.GetPortValue((UInt16)(pi.GetPortIO() + 7), &Status, 1);
            pi.rError.setErrorRegister(Error);
            pi.rStatus.setStatusRegister(Status);

            if (pi.rStatus.ERR) lbEror.BackColor = Color.Red; else lbEror.BackColor = Color.DarkGray;
            if (pi.rStatus.IDX) lbIdx.BackColor = Color.Green; else lbIdx.BackColor = Color.DarkGray;
            if (pi.rStatus.CORR) lbCorr.BackColor = Color.Green; else lbCorr.BackColor = Color.DarkGray;
            if (pi.rStatus.DRQ) lbDrq.BackColor = Color.Green; else lbDrq.BackColor = Color.DarkGray;
            if (pi.rStatus.DSC) lbDsc.BackColor = Color.Green; else lbDsc.BackColor = Color.DarkGray;
            if (pi.rStatus.DF) lbDf.BackColor = Color.Red; else lbDf.BackColor = Color.DarkGray;
            if (pi.rStatus.DRDY) lbDrdy.BackColor = Color.Green; else lbDrdy.BackColor = Color.DarkGray;
            if (pi.rStatus.BSY) lbBsy.BackColor = Color.Green; else lbBsy.BackColor = Color.DarkGray;
            ////////////////////////////////////////////////////////////
            if (pi.rError.BBK) lbBBK.BackColor = Color.Red; else lbBBK.BackColor = Color.DarkGray;
            if (pi.rError.UNC) lbUNC.BackColor = Color.Red; else lbUNC.BackColor = Color.DarkGray;
            if (pi.rError.MC) lbMC.BackColor = Color.Red; else lbMC.BackColor = Color.DarkGray;
            if (pi.rError.IDNF) lbIDNF.BackColor = Color.Red; else lbIDNF.BackColor = Color.DarkGray;
            if (pi.rError.MCR) lbMCR.BackColor = Color.Red; else lbMCR.BackColor = Color.DarkGray;
            if (pi.rError.ABRT) lbABRT.BackColor = Color.Red; else lbABRT.BackColor = Color.DarkGray;
            if (pi.rError.TONF) lbTONF.BackColor = Color.Red; else lbTONF.BackColor = Color.DarkGray;
            if (pi.rError.AMNF) lbAMNF.BackColor = Color.Red; else lbAMNF.BackColor = Color.DarkGray;
        }

        private void tmMain_Tick(object sender, EventArgs e)
        {
            Monitorings();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void monitoringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fMonitoring != null)
            {
                fMonitoring.Close();
                fMonitoring = null;
                fMonitoring = new frmMonitoring(pi);
                fMonitoring.Top = this.Top;
                fMonitoring.Left = this.Left;
                fMonitoring.Show();
            }
            else
            {
                fMonitoring = new frmMonitoring(pi);
                fMonitoring.Top = this.Top;
                fMonitoring.Left = this.Left;
                fMonitoring.Show();
            }
        }

        private void sofTResetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pi.SoftReset();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fSettings != null)
            {
                fSettings.Close();
                fSettings = null;
                fSettings = new frmSettings(pi);
                fSettings.Top = this.Top;
                fSettings.Left = this.Left;
                fSettings.Show();
            }
            else
            {
                fSettings = new frmSettings(pi);
                fSettings.Top = this.Top;
                fSettings.Left = this.Left;
                fSettings.Show();
            }
        }



        private void singleCommandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fatacom != null)
            {
                fatacom.Close();
                fatacom = null;
                fatacom = new frmATACommand(pi);
                fatacom.Top = this.Top;
                fatacom.Left = this.Left;
                fatacom.Show();
            }
            else
            {
                fatacom = new frmATACommand(pi);
                fatacom.Top = this.Top;
                fatacom.Left = this.Left;
                fatacom.Show();
            }
        }

        private void loopCommandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fatacoms != null)
            {
                fatacoms.Close();
                fatacoms = null;
                fatacoms = new frmATACommands(pi);
                fatacoms.Top = this.Top;
                fatacoms.Left = this.Left;
                fatacoms.Show();
            }
            else
            {
                fatacoms = new frmATACommands(pi);
                fatacoms.Top = this.Top;
                fatacoms.Left = this.Left;
                fatacoms.Show();
            }
        }

        private void eraseDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EH != null)
            {
                EH.Close();
                EH = null;
                EH = new EraseHdd(pi);
                EH.Top = this.Top;
                EH.Left = this.Left;
                EH.Show();
            }
            else
            {
                EH = new EraseHdd(pi);
                EH.Top = this.Top;
                EH.Left = this.Left;
                EH.Show();
            }
        }

        private void seagateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fScript != null)
            {
                fScript.Close();
                fScript = null;
                fScript = new frmScripts(pi);
                fScript.Top = this.Top;
                fScript.Left = this.Left;
                fScript.Show();
            }
            else
            {
                fScript = new frmScripts(pi);
                fScript.Top = this.Top;
                fScript.Left = this.Left;
                fScript.Show();
            }
        }

        private void wipeHddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EH != null)
            {
                EH.Close();
                EH = null;
                EH = new EraseHdd(pi);
                EH.Top = this.Top;
                EH.Left = this.Left;
                EH.Show();
            }
            else
            {
                EH = new EraseHdd(pi);
                EH.Top = this.Top;
                EH.Left = this.Left;
                EH.Show();
            }
        }

        private void createImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CI != null)
            {
                CI.Close();
                CI = null;
                CI = new CreateImageHdd(pi);
                CI.Top = this.Top;
                CI.Left = this.Left;
                CI.Show();
            }
            else
            {
                CI = new CreateImageHdd(pi);
                CI.Top = this.Top;
                CI.Left = this.Left;
                CI.Show();
            }
        }

        private void setPortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fpl.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.ShowDialog();
        }

    }
}
