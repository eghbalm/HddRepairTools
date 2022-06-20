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
    public partial class EraseHdd : Form
    {
        PortIo pi;
        UInt64 LBA = 0;
        UInt64 min = 0;
        UInt64 max = 0;
        Thread trStart;
        UInt16 cmd;
        Random rd = new Random();
        uint len = 1;
        bool loop = false;
        public EraseHdd(PortIo PI)
        {
            InitializeComponent();
            pi = PI;
        }
        private byte[] getSectorByte(uint l, UInt64 secnum)
        {
            UInt64 sn = secnum;
            byte[] bt = new byte[512];
            List<byte> bts = new List<byte>();

            for (int i = 0; i < l; i++)
            {
                if (!rbEmpty.Checked)
                {
                    if (rbSN.Checked)
                    {
                        string st = "   Disk Sector  " + sn.ToString() + " ";
                        byte[] b = new byte[32];
                        for (int j = 0; j < st.Length; j++)
                        {
                            b[j] = Convert.ToByte((st[j]));
                        }
                        List<byte> bL = new List<byte>();
                        while (bL.Count<512)
                        {
                            bL.AddRange(b);
                        }
                        bt = bL.ToArray();
                        bL = null;
                    }

                    if (rbRandom.Checked)
                    {
                        for (int j = 0; j < bt.Length; j++)
                        {
                            bt[j] = Convert.ToByte(rd.Next(256));
                        }
                    }                   
                }
                bts.AddRange(bt);
                sn++;
            }
            return bts.ToArray();
        }

        private void runLoop()
        {
            uint lft = 0;
            IDEREGS idr = new IDEREGS();
            byte[] data=new byte[512];
            if (rbByte.Checked)
                {
                    data = new byte[512*len];
                    for (int j = 0; j < data.Length; j++)
                    {
                        data[j] = byte.Parse(tbByte.Text, System.Globalization.NumberStyles.HexNumber);
                    }
                }
            for (UInt64 i = min; i <= (max - len) + 1; i = i + len)
            //for (UInt64 i = (max - len) + 1; i >= min; i = i - len)
            {
                if (!rbByte.Checked) data = getSectorByte(len, i); 
                idr = pi.getIDERegsFromUlong(i, len, cmd);
                pi.SendATACommand(idr);
                pi.SectorsFromByte(data);

                lft = (uint)(max - (i + len)) + 1;
                if (len > lft && lft > 0)
                {
                    data = getSectorByte(lft, i + len);
                    idr = pi.getIDERegsFromUlong(i + len, lft, cmd);
                    pi.SendATACommand(idr);
                    pi.SectorsFromByte(data);

                }
                if (loop == false)
                {
                    break;
                }
                this.Invoke(new MethodInvoker(delegate
                {
                    pbErase.Value = (int)i;
                    float percent = (float)i * 100/max;
                    lbPercent.Text = percent.ToString("f0.000") + "%";
                    tbMin.Text = i.ToString();

                }));
            }
            data = null;
            loop = false;
            this.Invoke(new MethodInvoker(delegate
            {
                pbErase.Value = pbErase.Maximum;

            }));
            MessageBox.Show("Erase completed ...");
            this.Invoke(new MethodInvoker(delegate
            {
                pbErase.Value = pbErase.Minimum;
                tbMin.Text = min.ToString();

            }));
            trStart = null;
        }

        private void EraseHdd_Load(object sender, EventArgs e)
        {
            setLba();
            tbMin.Text = min.ToString();
            tbMax.Text = max.ToString();
            if (pi.identity.idsector.ModelNumber.ToString() != "")
            {
                tbModel.Text = pi.identity.SwapChars(new string(pi.identity.idsector.ModelNumber));
                tbSN.Text = pi.identity.SwapChars(new string(pi.identity.idsector.SerialNumber));
                tbFW.Text = pi.identity.SwapChars(new string(pi.identity.idsector.FirmwareRevision));
                tbHead.Text = pi.identity.idsector.NumberHeads.ToString();
                tbCylander.Text = pi.identity.idsector.NumberCylinders.ToString();
            }

        }
        private void setLba()
        {
            pi.identity.IdentityDevice();
            LBA = pi.identity.idsector.Total_LBA_Sectors - 1;
            min = 0;
            max = LBA;
        }
        private void btnErase_Click(object sender, EventArgs e)
        {
            pi.lba28 = false;
            if (loop == false)
            {
                pi.lba28 = false;
                minmax();
                pbErase.Minimum = (int)min;
                pbErase.Maximum = Math.Abs((int)max);
                len = uint.Parse(cbLen.Text);
                cmd = UInt16.Parse(cbCMD.Text, System.Globalization.NumberStyles.HexNumber);
                if (len > max)
                {
                    MessageBox.Show("length and MaxLba Eror");
                }
                else
                {
                    trStart = new Thread(new ThreadStart(runLoop));
                    loop = true;
                    trStart.Start();
                }
            }
            else MessageBox.Show("Already Running");
        }
        private void minmax()
        {
            min = UInt64.Parse(tbMin.Text);
            max = UInt64.Parse(tbMax.Text);
            if (min < 0)
            {
                tbMin.Text = "0";
                min = 0;
            }
            if (max > LBA)
            {
                tbMax.Text = LBA.ToString();
                max = LBA;
            }
            if (max < min)
            {
                tbMin.Text = tbMax.Text;
                min = max;
            }

        }

        private void MinMaxKeypress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                if (tb.Text == "0")
                {
                    tb.Text = e.KeyChar.ToString();
                    tb.SelectionStart = tb.TextLength;
                    e.Handled = true;
                }
            }
        }

        private void tbByte_KeyPress(object sender, KeyPressEventArgs e)
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
                else
                {
                    (sender as TextBox).SelectionStart = (sender as TextBox).Text.Length;
                }

            }
        }

        private void tbByte_Leave(object sender, EventArgs e)
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
        }

        private void tbByte_TextChanged(object sender, EventArgs e)
        {
            (sender as TextBox).Text = (sender as TextBox).Text.ToUpper();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            loop = false;
        }

        private void tbMinMax_Leave(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
            minmax();
        }

        private void cb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            if (rbByte.Checked) tbByte.Enabled = true; else tbByte.Enabled = false;
        }

    }
}
