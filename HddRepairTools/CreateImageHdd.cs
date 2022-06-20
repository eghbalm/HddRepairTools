using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace HddRepairTools
{
    public partial class CreateImageHdd : Form
    {
        PortIo pi;
        UInt64 LBA = 100;
        UInt64 min = 0;
        UInt64 max = 0;
        Thread trStart;
        FileStream fs;
        uint len = 1;        
        bool loop = false;
        public CreateImageHdd(PortIo PI)
        {
            InitializeComponent();
            pi = PI;
        }   

        private void runLoop()
        {
            uint lft = 0;
            IDEREGS idr = new IDEREGS();            
            byte[] data;
            FileInfo fi = new FileInfo(tbFName.Text);
            if (!Directory.Exists(fi.DirectoryName))
            {
                Directory.CreateDirectory(fi.DirectoryName);
            }
            fi = null;
            fs = File.Open(tbFName.Text, FileMode.Create);

            for (UInt64 i = min; i <= (max - len)+1; i = i + len)
            {

                idr = pi.getIDERegsFromUlong(i, len,0x24);
                pi.SendATACommand(idr);
                Thread.Sleep(50);
                data = pi.GetSectors();
                if (data.Length == 0)
                {
                    //MessageBox.Show(i.ToString());
                    break;
                }
                fs.Write(data, 0, data.Length);   

                lft = (uint)(max - (i + len))+1;
                if (len > lft && lft > 0)
                {
                    idr = pi.getIDERegsFromUlong(i+len, lft,0x24);
                    pi.SendATACommand(idr);
                    data = pi.GetSectors();
                    if (data.Length == 0)
                    {
                        //MessageBox.Show(i.ToString());
                        break;
                    }
                    fs.Write(data, 0, data.Length);
                }
                if (loop == false)
                {
                    break;
                }
                this.Invoke(new MethodInvoker(delegate
                {
                    pbMon.Value = (int)i;

                }));
            }
            fs.Close();            
            data = null;
            this.Invoke(new MethodInvoker(delegate
            {
                pbMon.Value = pbMon.Maximum;

            }));
            MessageBox.Show("Create Image Completed ...");
            this.Invoke(new MethodInvoker(delegate
            {
                pbMon.Value = pbMon.Minimum;

            }));
            trStart.Abort();
            trStart = null;
        }

        private void CreateImageHdd_Load(object sender, EventArgs e)
        {
            tbFName.Text = pi.WorkDir + "\\Image\\image.bin";
            setLba();
            tbMin.Text = min.ToString();
            tbMax.Text = max.ToString();
        }
        private void setLba()
        {
            pi.identity.IdentityDevice();
            LBA = pi.identity.idsector.Total_LBA_Sectors - 1;
            min = 0;
            max = LBA;
        }
        private void minmax()
        {
            min = UInt64.Parse(tbMin.Text);
            max = UInt64.Parse(tbMax.Text);
            if (min<0)
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

        private void keypress(TextBox tb, KeyPressEventArgs e)
        {
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
        private void tbMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            keypress(sender as TextBox, e);
        }

        private void tbMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            keypress(sender as TextBox, e);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            loop = false;
        }

        private void tbMinMax_Leave(object sender, EventArgs e)
        {
            minmax();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            minmax();
            pbMon.Minimum = (int)min;
            pbMon.Maximum =Math.Abs((int)max);
            len =uint.Parse(cbLen.Text);
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

        private void cbLen_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.Filter = "Binary File|*.bin";
            DialogResult dl = ofd.ShowDialog();
            if (dl == DialogResult.OK)
            {
                tbFName.Text = ofd.FileName;
            }
            ofd.Dispose();
            ofd = null;
        }

    }
}
