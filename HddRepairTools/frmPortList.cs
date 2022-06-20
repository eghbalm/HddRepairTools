using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;

namespace HddRepairTools
{
    public partial class frmPortList : Form
    {
        PortIo pi;
        public frmPortList(PortIo PI)
        {
            InitializeComponent();
            pi = PI;

            try
            {
                List<PortIO_Info> stt = GetIoPorts();
                DataTable dt = new DataTable();
                dt.Columns.Add("BaseIO");
                dt.Columns.Add("DeviceID");
                dt.Columns.Add("Description");
                for (int i = 0; i < stt.Count; i++)
                {
                    dt.Rows.Add();
                    dt.Rows[i]["Description"] = stt[i].Caption;
                    dt.Rows[i]["DeviceID"] = stt[i].DeviceID;
                    dt.Rows[i]["BaseIO"] = stt[i].StartingAddress.ToString("x").ToUpper();
                }
                gvPorts.DataSource = dt;
                gvPorts.Columns[0].Width = 100;
                gvPorts.Columns[1].Width = 450;
                gvPorts.Columns[2].Width = 250;
            }
            catch (Exception)
            {
                MessageBox.Show("Can not find ports io number please input manualy");
            }
            tbBaseaddr.Text = pi.GetPortIO().ToString("x").ToUpper();
            Slaver.Checked = pi.Slaver;
        }

        public const string ATA_ATAPI_GUID = "{4d36e96a-e325-11ce-bfc1-08002be10318}";
        ManagementScope scope = new ManagementScope(@"\\" + Environment.MachineName + @"\root\CIMV2");

        public struct PortIO_Info
        {
            public string DeviceID;
            public int StartingAddress;
            public int EndingAddress;
            public string Caption;
            public string Service;
            public string Name;
        }

        public struct IO_Port
        {
            public string DevID;
            public string Caption;
            public string Name;
            public string Antecedent;
            public string Dependent;
            public int StartingAddress;
            public int EndingAddress;
            public string Service;
        }

        struct PnPentity
        {
            public string Caption;
            public string ClassGuid;
            public string Description;
            public string DeviceID;
            public string Name;
            public string Service;
        }

        public List<PortIO_Info> GetIoPorts()
        {
            List<IO_Port> ioPort = new List<IO_Port>();
            List<PortIO_Info> PIInfo = new List<PortIO_Info>();
            List<PnPentity> pnPentity = new List<PnPentity>();

            ManagementScope scope = new ManagementScope(@"\\" + Environment.MachineName + @"\root\CIMV2");
            SelectQuery sqpp = new SelectQuery("Select * From Win32_PnPentity where ClassGuid='" + ATA_ATAPI_GUID + "'");
            ManagementObjectSearcher searcher1 = new ManagementObjectSearcher(scope, sqpp);

            ManagementObjectCollection moc = searcher1.Get();

            foreach (ManagementObject mo in moc)
            {
                if (mo["DeviceID"] != null)
                {
                    PnPentity pp = new PnPentity();
                    pp.DeviceID = mo["DeviceID"].ToString();
                    pp.Caption = mo["Caption"].ToString();
                    pp.Description = mo["Description"].ToString();
                    pp.ClassGuid = mo["ClassGuid"].ToString();
                    pp.Name = mo["Name"].ToString();
                    pp.Service = mo["Service"].ToString();
                    pnPentity.Add(pp);
                }
            }


            foreach (var item in pnPentity)
            {
                SelectQuery sqpr = new SelectQuery("Select * From Win32_PnPAllocatedResource");
                ManagementObjectSearcher searcher2 = new ManagementObjectSearcher(scope, sqpr);

                ManagementObjectCollection moc1 = searcher2.Get();

                foreach (ManagementObject mo in moc1)
                {
                    if (mo["Dependent"] != null)
                    {
                        if (mo["Dependent"].ToString().Contains(item.DeviceID.Replace(@"\", @"\\")))
                        {

                            if (mo["Antecedent"] != null)
                            {
                                if (mo["Antecedent"].ToString().Contains("StartingAddress"))
                                {
                                    IO_Port i = new IO_Port();
                                    i.Antecedent = mo["Antecedent"].ToString();
                                    i.Dependent = mo["Dependent"].ToString();
                                    i.DevID = item.DeviceID;
                                    i.Caption = item.Caption;
                                    i.Name = item.Name;
                                    i.Service = item.Service;
                                    ioPort.Add(i);
                                }
                            }
                        }

                    }
                }
            }

            List<String> StartingAddress = new List<String>();

            for (int i = 0; i < ioPort.Count; i++)
            {
                SelectQuery sqpr = new SelectQuery("Select * From Win32_PortResource");
                ManagementObjectSearcher searcher2 = new ManagementObjectSearcher(scope, sqpr);
                ManagementObjectCollection moc1 = searcher2.Get();

                foreach (ManagementObject mo in moc1)
                {
                    if (mo["StartingAddress"] != null)
                    {
                        if (ioPort[i].Antecedent.Contains("\"" + mo["StartingAddress"].ToString() + "\""))
                        {
                            int sa = int.Parse(mo["StartingAddress"].ToString());
                            int ea = int.Parse(mo["EndingAddress"].ToString());
                            if (ea - sa == 7)
                            {
                                PortIO_Info pi = new PortIO_Info();
                                pi.Caption = ioPort[i].Caption;
                                pi.DeviceID = ioPort[i].DevID;
                                pi.EndingAddress = ea;
                                pi.StartingAddress = sa;
                                pi.Name = ioPort[i].Name;
                                pi.Service = ioPort[i].Service;
                                PIInfo.Add(pi);
                            }
                        }

                    }
                }
            }


            return PIInfo;
        }

        private void setPort()
        {
            if (tbBaseaddr.Text != "")
            {
                pi.SetPortIO(ushort.Parse(tbBaseaddr.Text, System.Globalization.NumberStyles.HexNumber));
                
            }
            if (Slaver.Checked)
            {
                pi.WI.SetPortValue((UInt16)(pi.GetPortIO() + 6), 0xb0, 1);
                pi.Slaver = true;
            }
            else
            {
                pi.WI.SetPortValue((UInt16)(pi.GetPortIO() + 6), 0xa0, 1);
                pi.Slaver = false;
            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            setPort();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tbBaseaddr_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbBaseaddr_Leave(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == "")
            {
                (sender as TextBox).Text = "0";
            }
        }

        private void gvPorts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                tbBaseaddr.Text = gvPorts.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            UInt16 baseAddress = 0;
            if (tbBaseaddr.Text != "")
            {
                baseAddress = (UInt16)int.Parse(tbBaseaddr.Text, System.Globalization.NumberStyles.HexNumber);
            }
            pi.SetPortIO(baseAddress);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pi.identity = null;
            pi.identity = new IDENTITY(pi);
            setPort();
            pi.identity.IdentityDevice();
            tbModel.Text =pi.identity.SwapChars(new string(pi.identity.idsector.ModelNumber));
            tbSerial.Text = pi.identity.SwapChars(new string(pi.identity.idsector.SerialNumber));            

        }

        private void frmPortList_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel=true;
            this.Hide();
        }

        private void frmPortList_Load(object sender, EventArgs e)
        {
            if (gvPorts.Rows.Count>0)
            {
                tbBaseaddr.Text = gvPorts.Rows[0].Cells[0].Value.ToString();
            }
            UInt16 baseAddress = 0;
            if (tbBaseaddr.Text != "")
            {
                baseAddress = (UInt16)int.Parse(tbBaseaddr.Text, System.Globalization.NumberStyles.HexNumber);
            }
            pi.SetPortIO(baseAddress);
            btnSet_Click(null,null);
        }
    }
}
