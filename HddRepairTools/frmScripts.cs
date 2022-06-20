using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Threading;

namespace HddRepairTools
{
    public partial class frmScripts : Form
    {
        struct StatusCode
        {
            public string codeStr;
            public int line;
        }
        bool DRQ = false;
        byte[] buf;
        bool scode = false;
        List<StatusCode> lsc = new List<StatusCode>();
        PortIo pi;
        OleDbCommand cmd;
        OleDbDataReader qddr;
        OleDbDataAdapter odda;
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Scripts.accdb");
        Thread trRun;
        int lineIndex = -1;
        public class Lab
        {
            public string Name;
            public int Index;
            public string val1;
            public string val2;
            public string val3;
            public string val4;
            public string val5;
            public string val6;
            public string val7;
        }
        List<Lab> Labels = new List<Lab>();
        List<Lab> objs = new List<Lab>();
        List<Lab> regs = new List<Lab>();
        List<Lab> IF = new List<Lab>();
        public frmScripts(PortIo p)
        {
            InitializeComponent();
            pi = p;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtScript.Text != "")
            {
                string str = "";
                DialogResult result = System.Windows.Forms.DialogResult.None;
                result = InputBox.Show("Input Required", "Please enter ScriptName below.", "Value", out str);
                if (result != System.Windows.Forms.DialogResult.OK)
                {
                    return;
                }
                if (str != "")
                {
                    con.Open();
                    cmd.CommandText = "select * from tbScripts where Sname='" + str + "';";
                    qddr = cmd.ExecuteReader();
                    if (qddr.Read())
                    {
                        MessageBox.Show("Script Name Already Exists ...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                        return;
                    }
                    con.Close();
                    string strDescription = "";
                    InputBox.Show("Input", "Please enter Script Description below.", "Value", out strDescription);
                    con.Open();
                    cmd.CommandText = "Insert into tbScripts(Sname,Stext,Description) values('" + str + "','" + txtScript.Text + "','" + strDescription + "');";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Script Successfully Saved ...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    loadDB();
                }

            }
            else { MessageBox.Show("Script Text Is Empty ...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void loadDB()
        {
            cbScript.Items.Clear();
            cbScript.Text = "";
            txtScript.Text = "";
            con.Open();
            cmd.CommandText = "select * from tbScripts;";
            qddr = cmd.ExecuteReader();
            while (qddr.Read())
            {
                cbScript.Items.Add(qddr["Sname"].ToString());
            }
            con.Close();
            if (cbScript.Items.Count > 0)
            {
                cbScript.Text = cbScript.Items[0].ToString();
            }
        }

        private void frmScripts_Load(object sender, EventArgs e)
        {
            cmd = new OleDbCommand();
            cmd.Connection = con;
            odda = new OleDbDataAdapter(cmd);
            loadDB();
        }

        private void cbScript_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            cmd.CommandText = "select * from tbScripts where Sname='" + cbScript.Text + "';";
            qddr = cmd.ExecuteReader();
            if (qddr.Read())
            {
                txtScript.Text = qddr["Stext"].ToString();
            }
            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool can = false;
            con.Open();
            cmd.CommandText = "select * from tbScripts where Sname='" + cbScript.Text + "';";
            qddr = cmd.ExecuteReader();
            if (qddr.Read())
            {
                can = true;
            }
            else
            {
                MessageBox.Show("Script Text Is Empty ...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                can = false;
            }
            con.Close();
            if (can)
            {
                DialogResult dr = MessageBox.Show("Are You sore ????", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    con.Open();
                    cmd.CommandText = "Delete from tbScripts where Sname='" + cbScript.Text + "';";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Script Successfully Deleted ...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDB();
                }
            }
        }

        private void cbScript_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        public string getScript(string st)
        {
            string resu = "";
            resu = st.Split(';')[0].ToUpper();
        hhh:
            if (resu.Length > 0)
            {
                if (resu[0] == ' ')
                {
                    resu = resu.Remove(0, 1);
                    goto hhh;
                }
            }
            return resu;
        }

        public string[] getNormalStrs(string st)
        {
            string[] sts = null;
            bool nl = false;

            for (int i = 0; i < st.Length; i++)
            {
                if ((st[i] == ' '))
                {
                    if (sts != null)
                    {
                        if (sts[sts.Length - 1] != null)
                        {
                            nl = true;
                        }
                    }


                }
                else
                {
                    if (sts == null)
                    {
                        sts = new string[1];
                    }
                    else
                    {
                        if (nl)
                        {
                            Array.Resize(ref sts, sts.Length + 1);
                            nl = false;
                        }
                    }

                    sts[sts.Length - 1] += st[i];
                }
            }

            return sts;
        }

        public bool objCode(string code, int ind)
        {
            if (code.Length > 1)
            {
                if (code[0] == '%')
                {
                    scode = true;
                    try
                    {
                        string[] codes = code.Split('=');
                        if (codes.Length > 1)
                        {
                            Lab l = new Lab();
                            l.Index = ind;
                            l.Name = codes[0].Replace(" ", "");
                            l.val1 = codes[1];
                            if (objs.Where(a => a.Name == l.Name).Count() == 0)
                            {
                                objs.Add(l);
                            }
                            else
                            {
                                uint baseint = uint.Parse(objs.Where(a => a.Name == l.Name).FirstOrDefault().val1);
                                string[] sp;
                                uint outint = 0;

                                if (codes[1].Contains("+"))
                                {
                                    sp = codes[1].Split('+');
                                    if (sp.Length == 2)
                                    {
                                        foreach (var item in objs)
                                        {
                                            if (sp[0].Contains(item.Name))
                                            {
                                                outint = uint.Parse(item.val1) + uint.Parse(sp[1]);
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    if (codes[1].Contains("-"))
                                    {
                                        sp = codes[1].Split('-');
                                        if (sp.Length == 2)
                                        {
                                            foreach (var item in objs)
                                            {
                                                if (sp[0].Contains(item.Name))
                                                {
                                                    outint = uint.Parse(item.val1) - uint.Parse(sp[1]);
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        outint = uint.Parse(codes[1]);
                                    }
                                }
                                objs.Where(a => a.Name == l.Name).FirstOrDefault().val1 = outint.ToString();
                            }

                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                        throw;
                    }
                }
            }
            return false;
        }

        public bool labelCode(string code, int idx)
        {
            if (code.Length > 1)
            {
                if (code[0] == '@')
                {
                    scode = true;
                    try
                    {
                        Lab l = new Lab();
                        l.Index = idx;
                        l.Name = code.Substring(1).Replace(" ", "");
                        if (Labels.Where(a => a.Name == l.Name).Count() > 0)
                        {
                            if (Labels.Where(a => a.Name == l.Name).FirstOrDefault().Index != idx)
                            {
                                scode = false;
                            }

                        }
                        else
                        {
                            Labels.Add(l);
                        }
                        return true;
                    }
                    catch (Exception)
                    {
                        scode = false;
                    }
                }
            }
            return false;
        }

        public IDEREGS regCode(string val)
        {
            IDEREGS idrg = new IDEREGS();
            string[] result = new string[7];
            int index = 0;
            result[index] = result[index] + val[0];
            pi.lba28 = false;
            for (int i = 1; i < val.Count(); i++)
            {
                if (val[i] == '%' || val[i] == '$')
                {
                    index++;
                }
                if (index < 7 && val[i] != ' ')
                {
                    result[index] = result[index] + val[i];
                }
            }
            idrg.Features = 0;
            if (result[0][0] == '$')
            {
                idrg.Features = UInt32.Parse(result[0].Remove(0, 1), System.Globalization.NumberStyles.HexNumber);
            }
            else
            {
                idrg.Features = UInt32.Parse(objs.Where(a => a.Name == result[0]).FirstOrDefault().val1);
            }

            idrg.SectorCount = 0;
            if (result[1][0] == '$')
            {
                idrg.SectorCount = UInt32.Parse(result[1].Remove(0, 1), System.Globalization.NumberStyles.HexNumber);
            }
            else
            {
                idrg.SectorCount = UInt32.Parse(objs.Where(a => a.Name == result[1]).FirstOrDefault().val1);
            }

            idrg.SectorNumber = 0;
            if (result[2][0] == '$')
            {
                idrg.SectorNumber = UInt32.Parse(result[2].Remove(0, 1), System.Globalization.NumberStyles.HexNumber);
            }
            else
            {
                idrg.SectorNumber = UInt32.Parse(objs.Where(a => a.Name == result[2]).FirstOrDefault().val1);
            }
            idrg.CylinderLow = 0;
            if (result[3][0] == '$')
            {
                idrg.CylinderLow = UInt32.Parse(result[3].Remove(0, 1), System.Globalization.NumberStyles.HexNumber);
            }
            else
            {
                idrg.CylinderLow = UInt32.Parse(objs.Where(a => a.Name == result[3]).FirstOrDefault().val1);
            }
            idrg.CylinderHigh = 0;
            if (result[4][0] == '$')
            {
                idrg.CylinderHigh = UInt32.Parse(result[4].Remove(0, 1), System.Globalization.NumberStyles.HexNumber);
            }
            else
            {
                idrg.CylinderHigh = UInt32.Parse(objs.Where(a => a.Name == result[4]).FirstOrDefault().val1);
            }

            idrg.DriveHead = 0;
            if (result[5][0] == '$')
            {
                idrg.DriveHead = UInt32.Parse(result[5].Remove(0, 1), System.Globalization.NumberStyles.HexNumber);
            }
            else
            {
                idrg.DriveHead = UInt32.Parse(objs.Where(a => a.Name == result[5]).FirstOrDefault().val1);
            }

            idrg.Command = 0;
            if (result[6][0] == '$')
            {
                idrg.Command = UInt32.Parse(result[6].Remove(0, 1), System.Globalization.NumberStyles.HexNumber);
            }
            else
            {
                idrg.Command = UInt32.Parse(objs.Where(a => a.Name == result[6]).FirstOrDefault().val1);
            }

            return idrg;
        }

        public bool GetRegs(string code, int idx)
        {
            if (code.Length > 6)
            {
                string[] spl = code.Split('=');
                if (spl.Length > 1 && spl[0].Replace(" ", "") == "REGS")
                {
                    pi.SendATACommand(regCode(spl[1].Replace(" ", "")));
                    scode = true;
                }
            }
            return false;
        }

        public bool SectorsTo(string code, int idx)
        {
            if (code.Length > 9)
            {
                if (code.Substring(0, 9) == "SECTORSTO")
                {
                    if (DRQ)
                    {
                        scode = true;
                        try
                        {
                            string[] sp = code.Split('=');
                            if (sp.Length > 1)
                            {
                                sp[1] = sp[1].Replace(" ", "");
                                foreach (var item in objs)
                                {
                                    if (sp[1].Contains(item.Name.Substring(0, item.Name.Length - 2)))
                                    {
                                        sp[1] = sp[1].Replace(item.Name, item.val1.ToString());
                                    }
                                }
                                string[] pad = sp[1].Split('\\');
                                string pathDir = Application.StartupPath;

                                for (int i = 0; i < pad.Length - 1; i++)
                                {
                                    pathDir += "\\" + pad[i];
                                }

                                if (!Directory.Exists(pathDir))
                                {
                                    Directory.CreateDirectory(pathDir);
                                }
                                pi.SectorsTo(pathDir + "\\" + pad[pad.Length - 1]);

                            }
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.Message);
                        }
                    }
                }
            }
            return false;
        }
        public bool cdb(string code, int idx)
        {
            if (code.Length > 2)
            {
                if (code.Substring(0, 3) == "CDB")
                {
                    try
                    {
                        string[] sp = code.Split('=');
                        if (sp.Length > 1)
                        {
                            scode = true;
                            foreach (var item in objs)
                            {
                                if (sp[1].Contains(item.Name.Substring(0, item.Name.Length - 2)) && int.Parse(item.val1) > 256)
                                {
                                    sp[1] = sp[1].Replace(item.Name, int.Parse(item.val1).ToString("x"));
                                }
                            }
                            string[] cdbstr = getNormalStrs(sp[1]);
                            buf = new byte[512];
                            // string pathDir = Application.StartupPath;
                            for (int i = 0; i < buf.Length; i++)
                            {
                                buf[i] = 0;
                                if (cdbstr != null)
                                {
                                    if (i < cdbstr.Length)
                                    {
                                        buf[i] = byte.Parse(cdbstr[i], System.Globalization.NumberStyles.HexNumber);
                                    }
                                }
                            }
                            scode = true;
                            pi.SectorsFromByte(buf);
                            buf = null;
                        }
                    }
                    catch (Exception e)
                    {
                        buf = null;
                        scode = false;
                    }
                }
            }
            return false;
        }

        public int returnval(string str)
        {
            int res = -1;
            if (str.Replace(" ", "")[0] == '%')
            {
                Lab lb = objs.Find(a => a.Name == str.Replace(" ", ""));
                if (lb != null)
                {
                    res = int.Parse(lb.val1);
                }
            }
            else
            {
                res = int.Parse(str);
            }
            return res;
        }

        private bool actIf(int vl1, int vl2, char act)
        {
            bool res = false;
            if (act == '>')
            {
                if (vl1 > vl2)
                {
                    res = true;
                }
            }
            if (act == '<')
            {
                if (vl1 < vl2)
                {
                    res = true;
                }
            }
            if (act == '=')
            {
                if (vl1 == vl2)
                {
                    res = true;
                }
            }
            return res;
        }

        private string[] removeSpace(string[] strs)
        {
            string[] strsResult = null;
            string[] temp = null;
            foreach (var item in strs)
            {
                if (item != "")
                {
                    if (temp != null)
                    {
                        strsResult = new string[temp.Length + 1];
                        for (int i = 0; i < temp.Length; i++)
                        {
                            strsResult[i] = temp[i];
                        }
                    }
                    else
                    {
                        strsResult = new string[1];
                    }
                    strsResult[strsResult.Length - 1] = item;
                    temp = strsResult;
                }
            }
            temp = null;
            return strsResult;
        }

        private void ifCode(string code, int idx)
        {
            if (code.Length > 2)
            {
                if (code.Substring(0, 2) == "IF")
                {
                    scode = true;
                    string[] spl = null;
                    string[] endsval = null;
                    int firstval;
                    int secondval;
                    bool goTo = false;
                    if (code.Contains('='))
                    {
                        spl = code.Substring(2, code.Length - 2).Split('=');
                        spl = removeSpace(spl);
                        if (spl.Length > 1)
                        {
                            firstval = returnval(spl[0]);
                            endsval = spl[1].Replace(" ", "").Split('@');
                            endsval = removeSpace(endsval);
                            if (endsval.Length > 1)
                            {
                                secondval = returnval(endsval[0]);
                                goTo = actIf(firstval, secondval, '=');
                            }
                        }
                    }
                    else
                    {
                        if (code.Contains('>'))
                        {

                            spl = code.Substring(2, code.Length - 2).Split('>');
                            spl = removeSpace(spl);
                            if (spl.Length > 1)
                            {
                                firstval = returnval(spl[0]);
                                endsval = spl[1].Replace(" ", "").Split('@');
                                endsval = removeSpace(endsval);
                                if (endsval.Length > 1)
                                {
                                    secondval = returnval(endsval[0]);
                                    goTo = actIf(firstval, secondval, '>');
                                }
                            }

                        }
                        else
                        {
                            if (code.Contains('<'))
                            {
                                spl = code.Substring(2, code.Length - 2).Split('<');
                                spl = removeSpace(spl);
                                if (spl.Length > 1)
                                {
                                    firstval = returnval(spl[0]);
                                    endsval = spl[1].Replace(" ", "").Split('@');
                                    endsval = removeSpace(endsval);
                                    if (endsval.Length > 1)
                                    {
                                        secondval = returnval(endsval[0]);
                                        goTo = actIf(firstval, secondval, '<');
                                    }
                                }
                            }
                        }
                    }
                    if (goTo && endsval.Length > 1)
                    {
                        Lab l = Labels.Find(a => a.Name == endsval[1] + ":");
                        if (l != null)
                        {
                            lineIndex = l.Index;
                        }
                    }
                }
            }
        }

        private void RunScript()
        {
            lsc.Clear();
            string[] strScripts = null;
            txtScript.Invoke(new MethodInvoker(delegate
            {
                strScripts = txtScript.Lines;
            }));

            for (int i = 0; i < strScripts.Length; i++)
            {
                if (lineIndex > -1)
                {
                    i = lineIndex;
                    lineIndex = -1;
                }
                scode = false;
                string strScript = getScript(strScripts[i]);
                labelCode(getScript(strScripts[i]), i);
                if (strScript != "")
                {
                    objCode(strScript, i);
                    GetRegs(strScript.Replace(" ", ""), i);
                    SectorsTo(strScript, i);
                    ifCode(strScript, i);
                    waitNBusy(strScript.Replace(" ", ""));
                    resetCode(strScript.Replace(" ", ""));
                    GOTO(strScript);
                    cdb(strScript, i);
                    checkDRQ(strScript);
                    resetCode(strScript);
                    if (scode == false)
                    {
                        StatusCode sc;
                        sc.codeStr = strScript;
                        sc.line = i;
                        lsc.Add(sc);
                        break;
                    }
                }
            }
            foreach (var item in lsc)
            {
                MessageBox.Show("Script on line " + item.line.ToString() + " error (" + item.codeStr + ")", "Error script");
            }
        }

        private void resetCode(string code)
        {
            if (code.Replace(" ", "") == "RESET")
            {
                scode = true;
                pi.SoftReset();
            }
        }

        private void checkDRQ(string code)
        {
            if (code.Replace(" ", "") == "CHECKDRQ")
            {
                scode = true;
                DRQ = pi.CheckDRQ();
            }
        }

        private void GOTO(string code)
        {
            string[] gt = code.Split(' ');
            if (gt.Length > 1)
            {
                if (gt[0].Replace(" ", "") == "GOTO")
                {
                    scode = true;
                    Lab lb = Labels.Where(a => a.Name == gt[1].Remove(0, 1) + ":").FirstOrDefault();
                    if (lb != null)
                    {
                        lineIndex = lb.Index;
                    }
                    else
                    {
                        lineIndex = -1;
                    }
                }
            }

        }

        private void waitNBusy(string code)
        {
            if (code.Replace(" ", "") == "WAITNBSY")
            {
                scode = true;
                pi.WaitNBSY();
                Lab lb = objs.Where(a => a.Name == "@ERROR").FirstOrDefault();
                if (lb != null)
                {
                    if (pi.rStatus.ERR) lb.val1 = "1"; else lb.val1 = "0";
                }
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            objs.Clear();
            Labels.Clear();
            IF.Clear();
            regs.Clear();
            Lab l = new Lab();
            l.Name = "@ERROR";
            l.val1 = "0";
            objs.Add(l);
            trRun = new Thread(new ThreadStart(RunScript));
            trRun.Start();
            //RunScript();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            trRun.Abort();
        }
    }
}
