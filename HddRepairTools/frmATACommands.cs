using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace HddRepairTools
{
    public partial class frmATACommands : Form
    {
        PortIo pi;
        Thread trLoop;
        IDEREGS[] loopir = new IDEREGS[2];
        bool trlp = false;
        public frmATACommands(PortIo PI)
        {
            InitializeComponent();
            pi = PI;
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            lbResult.Items.Clear();
        }

        private void btnLoopStop_Click(object sender, EventArgs e)
        {
            trlp = false;
            if (trLoop != null)
            {
                trLoop.Abort();
                trLoop = null;
            }
            tb01.Enabled = true; tb02.Enabled = true; tb03.Enabled = true; tb04.Enabled = true; tb05.Enabled = true; tbDev.Enabled = true; tbCmd.Enabled = true;
            te01.Enabled = true; te02.Enabled = true; te03.Enabled = true; te04.Enabled = true; te05.Enabled = true; teDev.Enabled = true; teCmd.Enabled = true;
            progressBar1.Value = 0;
        }
        public string getRegsString(UInt32 Val, bool cmddev)
        {
            string str = "";

            if (cmddev || pi.lba28)
            {
                str = Val.ToString("x");
                if (str.Length == 1)
                {
                    str = "0" + str;
                }
                str = str.Substring(0, 2);
            }
            else
            {
                byte[] bt = BitConverter.GetBytes(Val);
                string s1 = bt[0].ToString("x");
                string s2 = bt[1].ToString("x");
                if (s1.Length == 1)
                {
                    s1 = "0" + s1;
                }
                if (s2.Length == 1)
                {
                    s2 = "0" + s2;
                }
                str = s2 + s1;
                str = str.Substring(0, 4);
            }
            return str;
        }
        private void runLoop()
        {
            IDEREGS irg=new IDEREGS();
            bool ActiveRun=true;
            for (UInt32 i7 = loopir[0].Command; i7 < loopir[1].Command + 1; i7++)
            {
                for (UInt32 i6 = loopir[0].DriveHead; i6 < loopir[1].DriveHead + 1; i6++)
                {
                    for (UInt32 i5 = loopir[0].CylinderHigh; i5 < loopir[1].CylinderHigh + 1; i5++)
                    {
                        for (UInt32 i4 = loopir[0].CylinderLow; i4 < loopir[1].CylinderLow + 1; i4++)
                        {
                            for (UInt32 i3 = loopir[0].SectorNumber; i3 < loopir[1].SectorNumber + 1; i3++)
                            {
                                for (UInt32 i2 = loopir[0].SectorCount; i2 < loopir[1].SectorCount + 1; i2++)
                                {
                                    for (UInt32 i1 = loopir[0].Features; i1 < loopir[1].Features + 1; i1++)
                                    {
                                        pi.loopResult = "";
                                        string RfileName = i1.ToString("x") +"-"+ i2.ToString("x")+"-" + i3.ToString("x") +"-"+ i4.ToString("x") +"-"+ i5.ToString("x")+"-" + i6.ToString("x")+"-" + i7.ToString("x");
                                        string actFN = "";
                                        groupBox1.Invoke(new MethodInvoker(delegate
                                        {
                                            tb01.Text = getRegsString((UInt32)i1, false);
                                            tb02.Text = getRegsString((UInt32)i2, false);
                                            tb03.Text = getRegsString((UInt32)i3, false);
                                            tb04.Text = getRegsString((UInt32)i4, false);
                                            tb05.Text = getRegsString((UInt32)i5, false);
                                            tbDev.Text = getRegsString((UInt32)i6, true);
                                            tbCmd.Text = getRegsString((UInt32)i7, true);
                                        }));
                                        //////////////////////////////////////////////////////loop
                                        if (PS1.Checked)
                                        {
                                            Thread.Sleep(int.Parse(txtWaitL.Text));
                                            irg.Features = i1;
                                            irg.SectorCount = i2;
                                            irg.SectorNumber = i3;
                                            irg.CylinderLow = i4;
                                            irg.CylinderHigh = i5;
                                            irg.DriveHead = i6;
                                            irg.Command = i7;
                                            ActiveRun=pi.actionCMD(irg, VDRQ.Checked, VRDY.Checked, ifDrqL.Checked, SDRQL.Checked,  "cpRead", "cs.bin","0-0-0-0-0");
                                        }
                                        //////////////////////////////////////////////////////cmd1
                                        if (act1.Checked)
                                        {
                                            Thread.Sleep(int.Parse(txtWait1.Text));
                                            irg.Features = UInt32.Parse(tbc11.Text, System.Globalization.NumberStyles.HexNumber);
                                            irg.SectorCount = UInt32.Parse(tbc12.Text, System.Globalization.NumberStyles.HexNumber);
                                            irg.SectorNumber = UInt32.Parse(tbc13.Text, System.Globalization.NumberStyles.HexNumber);
                                            irg.CylinderLow = UInt32.Parse(tbc14.Text, System.Globalization.NumberStyles.HexNumber);
                                            irg.CylinderHigh = UInt32.Parse(tbc15.Text, System.Globalization.NumberStyles.HexNumber);
                                            irg.DriveHead = UInt32.Parse(tbc1Dev.Text, System.Globalization.NumberStyles.HexNumber);
                                            irg.Command = UInt32.Parse(tbc1Cmd.Text, System.Globalization.NumberStyles.HexNumber);
                                            actFN = "";
                                            actFN = actFN + irg.Features.ToString("x");
                                            actFN = actFN + irg.SectorCount.ToString("x");
                                            actFN = actFN + irg.SectorNumber.ToString("x");
                                            actFN = actFN + irg.CylinderLow.ToString("x");
                                            actFN = actFN + irg.CylinderHigh.ToString("x");
                                            actFN = actFN + irg.DriveHead.ToString("x");
                                            actFN = actFN + irg.Command.ToString("x");
                                            ActiveRun = pi.actionCMD(irg, VDRQ.Checked, VRDY.Checked, ifDrqC1.Checked, SDRQC1.Checked, RfileName + actFN, "cs.bin", "-" + RfileName);
                                        }
                                        //////////////////////////////////////////////////////loop
                                        if (PS2.Checked)
                                        {
                                            Thread.Sleep(int.Parse(txtWaitL.Text));
                                            irg.Features = i1;
                                            irg.SectorCount = i2;
                                            irg.SectorNumber = i3;
                                            irg.CylinderLow = i4;
                                            irg.CylinderHigh = i5;
                                            irg.DriveHead = i6;
                                            irg.Command = i7;
                                            ActiveRun = pi.actionCMD(irg, VDRQ.Checked, VRDY.Checked, ifDrqL.Checked, SDRQL.Checked, RfileName, "cs.bin", "0-0-0-0-0");
                                        }
                                        //////////////////////////////////////////////////////cmd2
                                        if (act2.Checked)
                                        {
                                            Thread.Sleep(int.Parse(txtWait2.Text));
                                            irg.Features = UInt32.Parse(tbc11.Text, System.Globalization.NumberStyles.HexNumber);
                                            irg.SectorCount = UInt32.Parse(tbc12.Text, System.Globalization.NumberStyles.HexNumber);
                                            irg.SectorNumber = UInt32.Parse(tbc13.Text, System.Globalization.NumberStyles.HexNumber);
                                            irg.CylinderLow = UInt32.Parse(tbc14.Text, System.Globalization.NumberStyles.HexNumber);
                                            irg.CylinderHigh = UInt32.Parse(tbc15.Text, System.Globalization.NumberStyles.HexNumber);
                                            irg.DriveHead = UInt32.Parse(tbc1Dev.Text, System.Globalization.NumberStyles.HexNumber);
                                            irg.Command = UInt32.Parse(tbc1Cmd.Text, System.Globalization.NumberStyles.HexNumber);
                                            actFN = "";
                                            actFN = actFN + irg.Features.ToString("x");
                                            actFN = actFN + irg.SectorCount.ToString("x");
                                            actFN = actFN + irg.SectorNumber.ToString("x");
                                            actFN = actFN + irg.CylinderLow.ToString("x");
                                            actFN = actFN + irg.CylinderHigh.ToString("x");
                                            actFN = actFN + irg.DriveHead.ToString("x");
                                            actFN = actFN + irg.Command.ToString("x");
                                            ActiveRun=pi.actionCMD(irg, VDRQ.Checked, VRDY.Checked, ifDrqC2.Checked, SDRQC2.Checked,  RfileName + actFN, "cs.bin", "-" + RfileName);
                                        }
                                        //////////////////////////////////////////////////////loop
                                        if (PS3.Checked)
                                        {
                                            Thread.Sleep(int.Parse(txtWaitL.Text));
                                            irg.Features = i1;
                                            irg.SectorCount = i2;
                                            irg.SectorNumber = i3;
                                            irg.CylinderLow = i4;
                                            irg.CylinderHigh = i5;
                                            irg.DriveHead = i6;
                                            irg.Command = i7;
                                            ActiveRun=pi.actionCMD(irg, VDRQ.Checked, VRDY.Checked, ifDrqL.Checked, SDRQL.Checked, RfileName, "cs.bin", "0-0-0-0-0");
                                        }
                                        //////////////////////////////////////////////////////cmd3
                                        if (act3.Checked)
                                        {
                                            Thread.Sleep(int.Parse(txtWait3.Text));
                                            irg.Features = UInt32.Parse(tbc11.Text, System.Globalization.NumberStyles.HexNumber);
                                            irg.SectorCount = UInt32.Parse(tbc12.Text, System.Globalization.NumberStyles.HexNumber);
                                            irg.SectorNumber = UInt32.Parse(tbc13.Text, System.Globalization.NumberStyles.HexNumber);
                                            irg.CylinderLow = UInt32.Parse(tbc14.Text, System.Globalization.NumberStyles.HexNumber);
                                            irg.CylinderHigh = UInt32.Parse(tbc15.Text, System.Globalization.NumberStyles.HexNumber);
                                            irg.DriveHead = UInt32.Parse(tbc1Dev.Text, System.Globalization.NumberStyles.HexNumber);
                                            irg.Command = UInt32.Parse(tbc1Cmd.Text, System.Globalization.NumberStyles.HexNumber);
                                            actFN = "";
                                            actFN = actFN + irg.Features.ToString("x");
                                            actFN = actFN + irg.SectorCount.ToString("x");
                                            actFN = actFN + irg.SectorNumber.ToString("x");
                                            actFN = actFN + irg.CylinderLow.ToString("x");
                                            actFN = actFN + irg.CylinderHigh.ToString("x");
                                            actFN = actFN + irg.DriveHead.ToString("x");
                                            actFN = actFN + irg.Command.ToString("x");
                                           ActiveRun= pi.actionCMD(irg, VDRQ.Checked, VRDY.Checked, ifDrqC3.Checked, SDRQC3.Checked,  RfileName + actFN, "cs.bin", "-" + RfileName);
                                        }
                                        //////////////////////////////////////////////////////loop
                                        if (PS4.Checked)
                                        {
                                            Thread.Sleep(int.Parse(txtWaitL.Text));
                                            irg.Features = i1;
                                            irg.SectorCount = i2;
                                            irg.SectorNumber = i3;
                                            irg.CylinderLow = i4;
                                            irg.CylinderHigh = i5;
                                            irg.DriveHead = i6;
                                            irg.Command = i7;
                                            ActiveRun = pi.actionCMD(irg, VDRQ.Checked, VRDY.Checked, ifDrqL.Checked, SDRQL.Checked, RfileName, "cs.bin", "0-0-0-0-0");
                                        }
                                        btnLoopStart.Invoke(new MethodInvoker(delegate
                                        {
                                            if (pi.loopResult != "")
                                            {
                                                lbResult.Items.Add(pi.loopResult);
                                            }
                                        }));
                                        if (trlp == false || ActiveRun==false)
                                        {
                                            trlp = false;
                                            btnLoopStart.Invoke(new MethodInvoker(delegate
                                            {
                                                btnLoopStart.Text = "Start";
                                            }));
                                            groupBox1.Invoke(new MethodInvoker(delegate
                                            {
                                                tb01.Enabled = true; tb02.Enabled = true; tb03.Enabled = true; tb04.Enabled = true; tb05.Enabled = true; tbDev.Enabled = true; tbCmd.Enabled = true;
                                                te01.Enabled = true; te02.Enabled = true; te03.Enabled = true; te04.Enabled = true; te05.Enabled = true; teDev.Enabled = true; teCmd.Enabled = true;
                                            }));
                                            trLoop.Abort();
                                            if (trLoop != null)
                                            {
                                                trLoop = null;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            groupBox1.Invoke(new MethodInvoker(delegate
            {
                btnLoopStart.Text = "Start";
                tb01.Enabled = true; tb02.Enabled = true; tb03.Enabled = true; tb04.Enabled = true; tb05.Enabled = true; tbDev.Enabled = true; tbCmd.Enabled = true;
                te01.Enabled = true; te02.Enabled = true; te03.Enabled = true; te04.Enabled = true; te05.Enabled = true; teDev.Enabled = true; teCmd.Enabled = true;
            }));
            if (trLoop != null)
            {
                trLoop = null;
            }
        }

        private void btnLoopStart_Click(object sender, EventArgs e)
        {
            if (trLoop == null)
            {
                pi.loopResult = "";
                loopir[0] = new IDEREGS();
                loopir[1] = new IDEREGS();
                loopir[0].Features = UInt32.Parse(tb01.Text, System.Globalization.NumberStyles.HexNumber);
                loopir[0].SectorCount = UInt32.Parse(tb02.Text, System.Globalization.NumberStyles.HexNumber);
                loopir[0].SectorNumber = UInt32.Parse(tb03.Text, System.Globalization.NumberStyles.HexNumber);
                loopir[0].CylinderLow = UInt32.Parse(tb04.Text, System.Globalization.NumberStyles.HexNumber);
                loopir[0].CylinderHigh = UInt32.Parse(tb05.Text, System.Globalization.NumberStyles.HexNumber);
                loopir[0].DriveHead = UInt32.Parse(tbDev.Text, System.Globalization.NumberStyles.HexNumber);
                loopir[0].Command = UInt32.Parse(tbCmd.Text, System.Globalization.NumberStyles.HexNumber);
                loopir[1].Features = UInt32.Parse(te01.Text, System.Globalization.NumberStyles.HexNumber);
                loopir[1].SectorCount = UInt32.Parse(te02.Text, System.Globalization.NumberStyles.HexNumber);
                loopir[1].SectorNumber = UInt32.Parse(te03.Text, System.Globalization.NumberStyles.HexNumber);
                loopir[1].CylinderLow = UInt32.Parse(te04.Text, System.Globalization.NumberStyles.HexNumber);
                loopir[1].CylinderHigh = UInt32.Parse(te05.Text, System.Globalization.NumberStyles.HexNumber);
                loopir[1].DriveHead = UInt32.Parse(teDev.Text, System.Globalization.NumberStyles.HexNumber);
                loopir[1].Command = UInt32.Parse(teCmd.Text, System.Globalization.NumberStyles.HexNumber);
                tb01.Enabled = false; tb02.Enabled = false; tb03.Enabled = false; tb04.Enabled = false; tb05.Enabled = false; tbDev.Enabled = false; tbCmd.Enabled = false;
                te01.Enabled = false; te02.Enabled = false; te03.Enabled = false; te04.Enabled = false; te05.Enabled = false; teDev.Enabled = false; teCmd.Enabled = false;
                trlp = true;
                trLoop = new Thread(new ThreadStart(runLoop));
                trLoop.Start();
            }
        }
        private void txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).SelectedText != "")
            {
                int a, ss;
                ss = (sender as TextBox).SelectionStart;
                a = (sender as TextBox).SelectionLength;
                (sender as TextBox).Text = (sender as TextBox).Text.Remove(ss, a);
                if (ss > 0)
                {
                    (sender as TextBox).SelectionStart = (sender as TextBox).Text.Length;
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
                if ((e.KeyChar != (char)Keys.Back) && (((sender as TextBox).Text.Length > 1 && pi.lba28) || ((sender as TextBox).Text.Length > 3 && !pi.lba28)))
                {
                    e.Handled = true;
                }

            }
        }
        private void txtboxCmd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).SelectedText != "")
            {
                int a, ss;
                ss = (sender as TextBox).SelectionStart;
                a = (sender as TextBox).SelectionLength;
                (sender as TextBox).Text = (sender as TextBox).Text.Remove(ss, a);
                if (ss > 0)
                {
                    (sender as TextBox).SelectionStart = (sender as TextBox).Text.Length;
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
                if ((e.KeyChar != (char)Keys.Back) && (sender as TextBox).Text.Length > 1)
                {
                    e.Handled = true;
                }

            }
        }
        private void txtboxcmd_Leave(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == "")
            {
                (sender as TextBox).Text = "00";
            }
            if ((sender as TextBox).Text.Length == 1)
            {
                (sender as TextBox).Text = "0" + (sender as TextBox).Text;
            }
            try
            {
                int.Parse((sender as TextBox).Text, System.Globalization.NumberStyles.HexNumber);
            }
            catch (Exception)
            {
                (sender as TextBox).Text = "00";
            }
            if (int.Parse(tb01.Text, System.Globalization.NumberStyles.HexNumber) > int.Parse(te01.Text, System.Globalization.NumberStyles.HexNumber))
            {
                tb01.Text = te01.Text;
            }
            if (int.Parse(tb02.Text, System.Globalization.NumberStyles.HexNumber) > int.Parse(te02.Text, System.Globalization.NumberStyles.HexNumber))
            {
                tb02.Text = te02.Text;
            }
            if (int.Parse(tb03.Text, System.Globalization.NumberStyles.HexNumber) > int.Parse(te03.Text, System.Globalization.NumberStyles.HexNumber))
            {
                tb03.Text = te03.Text;
            }
            if (int.Parse(tb04.Text, System.Globalization.NumberStyles.HexNumber) > int.Parse(te04.Text, System.Globalization.NumberStyles.HexNumber))
            {
                tb04.Text = te04.Text;
            }
            if (int.Parse(tb05.Text, System.Globalization.NumberStyles.HexNumber) > int.Parse(te05.Text, System.Globalization.NumberStyles.HexNumber))
            {
                tb05.Text = te05.Text;
            }
            if (int.Parse(tbDev.Text, System.Globalization.NumberStyles.HexNumber) > int.Parse(teDev.Text, System.Globalization.NumberStyles.HexNumber))
            {
                tbDev.Text = teDev.Text;
            }
            if (int.Parse(tbCmd.Text, System.Globalization.NumberStyles.HexNumber) > int.Parse(teCmd.Text, System.Globalization.NumberStyles.HexNumber))
            {
                tbCmd.Text = teCmd.Text;
            }
        }
        private void txtbox_Leave(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == "")
            {
                (sender as TextBox).Text = "00";
            }
            if ((sender as TextBox).Text.Length == 1 && pi.lba28)
            {
                (sender as TextBox).Text = "0" + (sender as TextBox).Text;
            }
            if ((sender as TextBox).Text.Length < 4 && pi.lba28 == false)
            {
                do
                {
                    (sender as TextBox).Text = "0" + (sender as TextBox).Text;
                } while ((sender as TextBox).Text.Length <= 3);
            }
            if ((sender as TextBox).Text.Length > 2 && pi.lba28)
            {
                (sender as TextBox).Text = (sender as TextBox).Text.Substring((sender as TextBox).Text.Length - 2, 2);
            }
            try
            {
                int.Parse((sender as TextBox).Text, System.Globalization.NumberStyles.HexNumber);
            }
            catch (Exception)
            {
                (sender as TextBox).Text = "00";
            }
            if (int.Parse(tb01.Text, System.Globalization.NumberStyles.HexNumber) > int.Parse(te01.Text, System.Globalization.NumberStyles.HexNumber))
            {
                tb01.Text = te01.Text;
            }
            if (int.Parse(tb02.Text, System.Globalization.NumberStyles.HexNumber) > int.Parse(te02.Text, System.Globalization.NumberStyles.HexNumber))
            {
                tb02.Text = te02.Text;
            }
            if (int.Parse(tb03.Text, System.Globalization.NumberStyles.HexNumber) > int.Parse(te03.Text, System.Globalization.NumberStyles.HexNumber))
            {
                tb03.Text = te03.Text;
            }
            if (int.Parse(tb04.Text, System.Globalization.NumberStyles.HexNumber) > int.Parse(te04.Text, System.Globalization.NumberStyles.HexNumber))
            {
                tb04.Text = te04.Text;
            }
            if (int.Parse(tb05.Text, System.Globalization.NumberStyles.HexNumber) > int.Parse(te05.Text, System.Globalization.NumberStyles.HexNumber))
            {
                tb05.Text = te05.Text;
            }
            if (int.Parse(tbDev.Text, System.Globalization.NumberStyles.HexNumber) > int.Parse(teDev.Text, System.Globalization.NumberStyles.HexNumber))
            {
                tbDev.Text = teDev.Text;
            }
            if (int.Parse(tbCmd.Text, System.Globalization.NumberStyles.HexNumber) > int.Parse(teCmd.Text, System.Globalization.NumberStyles.HexNumber))
            {
                tbCmd.Text = teCmd.Text;
            }
        }

        private void txtWait_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (sender as TextBox);
            if (tb.Text != "")
            {

                for (int i = 0; i < tb.Text.Length; i++)
                {
                    if (!char.IsControl(tb.Text[i]) && !char.IsDigit(tb.Text[i]))
                    {
                        tb.Text = "0";
                    }
                }
            }



        }
    }
}
