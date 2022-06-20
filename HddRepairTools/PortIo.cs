using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Threading;

namespace HddRepairTools
{
    public unsafe class PortIo
    {
        //------------------------------------------- public
        public ATARegisterError rError;
        public ATARegisterStatus rStatus;
        public IDENTITY identity;
        public WinIo WI;
        public bool lba28 = false;
        public FileStream fs;
        public string loopResult = "";
        public int Waittime = 100000;
        public string WorkDir = "";
        public string TempfileName = Path.GetTempPath() + @"ATACommand-Temp";
        public bool Slaver = false;
        //------------------------------------------- private
        private Thread tSE;
        private UInt16 baseIO = 0;
        private UInt16 BaseController = 0;
        
        
        public PortIo()
        {
            WI = new WinIo();
            rError = new ATARegisterError();
            rStatus = new ATARegisterStatus();
            identity = new IDENTITY(this);
            tSE = new Thread(new ThreadStart(GetRSE));
            tSE.Start();
        }
        public void delTempFile()
        {
            try
            {
                File.SetAttributes(TempfileName, FileAttributes.Normal);
            }
            catch { }
            if (File.Exists(TempfileName))
            {
                try
                {
                    File.Delete(TempfileName);
                }
                catch { }
            }
        }
        public void clearBuffer()
        {
            if (File.Exists(TempfileName))
            {
                try
                {
                    File.Delete(TempfileName);
                }
                catch (Exception)
                {

                    try
                    {
                        fs.Close();
                        File.Delete(TempfileName);
                    }
                    catch (Exception)
                    {
                        TempfileName += "0";
                    }
                }

            }
        }
        public bool SectorsTo(string pathfile)
        {
            ATARegisterStatus RS = new ATARegisterStatus();
            bool can = false;
            FileInfo fi = new FileInfo(pathfile);
            if (!Directory.Exists(fi.DirectoryName))
            {
                Directory.CreateDirectory(fi.DirectoryName);
            }
            fi = null;
        lpp:
            if (fs != null)
            {
                fs.Close();
            }
            try
            {
                fs = File.Open(pathfile, FileMode.OpenOrCreate);
                fs.Seek(fs.Length, SeekOrigin.Begin);
            }
            catch (Exception)
            {
                if (pathfile == TempfileName)
                {
                    TempfileName = TempfileName + "0";
                    pathfile = TempfileName;
                }
                else
                {
                    pathfile = pathfile + "0";
                }
                goto lpp;
            }
            uint portValue = 0;
            loopResult = "";
            while (true)
            {
            hh:
                portValue = 0;
                WI.GetPortValue((UInt16)(baseIO + 7), &portValue, 1);
                RS.setStatusRegister(portValue);
                if (portValue > 255) goto hh;

                if (RS.DRQ)
                {
                    UInt32 its = 0;
                    WI.GetPortValue(baseIO, &its, 4);
                    byte[] bts = BitConverter.GetBytes(its);
                    fs.Write(bts, 0, bts.Length);
                    can = true;
                }
                else
                {
                    rStatus = RS;
                    break;
                }
            }
            fs.Close();
            return can;
        }
        public byte[] GetSectors()
        {
            List<byte> btt = new List<byte>();
            uint portValue = 0;
            int waitLoop = Waittime;
            while (waitLoop > 0)
            {
                portValue = 0;
                WI.GetPortValue((UInt16)(baseIO + 7), &portValue, 1);
                if (portValue == 0x58 || portValue == 0x59)
                {
                    UInt32 its = 0;
                    WI.GetPortValue(baseIO, &its, 4);
                    byte[] bts = BitConverter.GetBytes(its);
                    for (int i = 0; i < bts.Length; i++)
                    {
                        btt.Add(bts[i]);
                    }
                }
                else
                {
                    waitLoop--;
                    if (portValue < 256)
                    {
                        break;
                    }
                }
            }
            return btt.ToArray();
        }
        public bool SectorsFrom(string pathfile)
        {
            bool can = false;
            if (fs != null)
            {
                fs.Close();
            }
            try
            {
                fs = File.Open(pathfile, FileMode.Open);
            }
            catch (Exception)
            {
                MessageBox.Show("Buffer Damaged Try Egain", "Error");
            }
            int idx = 0;
            uint portValue = 0;
            loopResult = "";
            while (true)
            {
                portValue = 0;
                WI.GetPortValue((UInt16)(baseIO + 7), &portValue, 1);
                if (portValue == 88)
                {
                    byte[] bts = new byte[4];
                    if (idx < fs.Length + 2)
                    {
                        fs.Read(bts, 0, 2);
                    }
                    WI.SetPortValue(baseIO, (UInt32)BitConverter.ToInt32(bts, 0), 2);
                    can = true;
                    idx++;
                }
                else
                {
                    if (portValue < 256)
                    {
                        break;
                    }
                }
            }
            fs.Close();
            return can;
        }
        public bool SectorsFromByte(byte[] bts)
        {
            bool can = false;
            int idx = 0;
            uint portValue = 0;
            loopResult = "";
            while (true)
            {
                portValue = 0;
                WI.GetPortValue((UInt16)(baseIO + 7), &portValue, 1);
                if (portValue == 88)
                {
                    UInt32 ui = 0;
                    byte[] bs = new byte[4];
                    if (idx < bts.Length - 3)
                    {
                        bs[0] = bts[idx];
                        bs[1] = bts[idx + 1];
                        bs[2] = bts[idx + 2];
                        bs[2] = bts[idx + 3];
                    }
                    else
                    {
                        bs[0] = 0;
                        bs[1] = 0;
                        bs[2] = 0;
                        bs[2] = 0;
                    }
                    ui = (UInt32)BitConverter.ToInt32(bs, 0);
                    WI.SetPortValue(baseIO, ui, 2);
                    can = true;
                    idx = idx + 2;                   
                }
                else
                {
                    if (portValue < 256)
                    {
                        break;
                    }
                }               

            }
            return can;
        }
        public bool actionCMD(IDEREGS idr, bool DRQ, bool rdy, bool drqstop, bool SDRQ, string RFName, string WFName, string allcmd)
        {
            bool resu = true;
            /////////////////////////////////////////////////////////////////////////lop
            SendATACommand(idr);
            UInt32 portValue = 0;
            int waitLoop = Waittime;
            while (--waitLoop > 0)
            {
                portValue = 0;
                WI.GetPortValue((UInt16)(baseIO + 7), &portValue, 1);
                //  drive is ready
                if (portValue == 0x50)
                {
                    if (rdy)
                    {
                        loopResult += "ready= " + idr.Features.ToString("x") + " - " + idr.SectorCount.ToString("x") + " - " + idr.SectorNumber.ToString("x") + " - " + idr.CylinderLow.ToString("x") + " - " + idr.CylinderHigh.ToString("x") + " - " + idr.DriveHead.ToString("x") + " - " + idr.Command.ToString("x") + "-" + allcmd + Environment.NewLine;
                    }
                    resu = true;
                    break;
                }
                //  previous drive command ended in error
                if (portValue == 0x51) { resu = true; break; }
                //  drive is ready and drq
                if (portValue == 0x58)
                {
                    resu = true;
                    if (drqstop)
                    {
                        resu = false;
                    }
                    if (SDRQ)
                    {

                        string strpath = Application.StartupPath + "\\OutDir\\";
                        if (!Directory.Exists(strpath))
                        {
                            Directory.CreateDirectory(strpath);
                        }
                        strpath = strpath + RFName;
                        SectorsTo(strpath);
                    }
                    else
                    {
                        string strpath = Application.StartupPath + "\\OutDir\\";
                        if (!Directory.Exists(strpath))
                        {
                            Directory.CreateDirectory(strpath);
                        }
                        strpath = strpath + WFName;
                        SectorsFrom(strpath);
                    }
                    if (DRQ) loopResult += "drq= " + idr.Features.ToString("x") + " - " + idr.SectorCount.ToString("x") + " - " + idr.SectorNumber.ToString("x") + " - " + idr.CylinderLow.ToString("x") + " - " + idr.CylinderHigh.ToString("x") + " - " + idr.DriveHead.ToString("x") + " - " + idr.Command.ToString("x") + "-" + allcmd + Environment.NewLine; break;
                }
                //  drive is busy
                if (portValue == 0xD0) { break; }
                if (0xf0 < portValue || portValue < 0xFF || portValue == 0x7f) { break; }
                //  previous drive command ended in error
            }
            if (waitLoop < 1)
            {
                SoftReset();
            };
            return resu;
        }
        public bool WaitNBSY()
        {
            ATARegisterStatus RS = new ATARegisterStatus();
            bool result = true;
            UInt32 portValue = 0;
            int waitLoop = Waittime;
            while (--waitLoop > 0)
            {
                portValue = 0;
                WI.GetPortValue((UInt16)(baseIO + 7), &portValue, 1);
                RS.setStatusRegister(portValue);
                //  drive is ready                
                if (!RS.BSY) { break; };
            }
            if (waitLoop < 1) { result = false; };
            rStatus = RS;
            return result;
        }
        public void SendATACommand(IDEREGS irs)
        {
            byte[] btsc = BitConverter.GetBytes(irs.SectorCount);
            byte[] btsn = BitConverter.GetBytes(irs.SectorNumber);
            byte[] btcl = BitConverter.GetBytes(irs.CylinderLow);
            byte[] btch = BitConverter.GetBytes(irs.CylinderHigh);
            WaitNBSY();
            WI.SetPortValue((UInt16)(baseIO + 1), irs.Features, 1);
            WI.SetPortValue((UInt16)(baseIO + 6), irs.DriveHead, 1);
            if (!lba28)
            {
                WI.SetPortValue((UInt16)(baseIO + 2), btsc[1], 1);
                WI.SetPortValue((UInt16)(baseIO + 3), btsn[1], 1);
                WI.SetPortValue((UInt16)(baseIO + 4), btcl[1], 1);
                WI.SetPortValue((UInt16)(baseIO + 5), btch[1], 1);
            }

            WI.SetPortValue((UInt16)(baseIO + 2), btsc[0], 1);
            WI.SetPortValue((UInt16)(baseIO + 3), btsn[0], 1);
            WI.SetPortValue((UInt16)(baseIO + 4), btcl[0], 1);
            WI.SetPortValue((UInt16)(baseIO + 5), btch[0], 1);

            WI.SetPortValue((UInt16)(baseIO + 7), irs.Command, 1);
            WaitNBSY();
        }
        public bool CheckDRQ()
        {
            GetRSE();
            if (rStatus.DRQ) return true; else return false;
        }
        public void ioWait()
        {
            UInt32 portValue;
            WI.GetPortValue((UInt16)(baseIO + 0x0C), &portValue, 1);
            WI.GetPortValue((UInt16)(baseIO + 0x0C), &portValue, 1);
            WI.GetPortValue((UInt16)(baseIO + 0x0C), &portValue, 1);
            WI.GetPortValue((UInt16)(baseIO + 0x0C), &portValue, 1);
        }
        public void SetPortIO(UInt16 baseio)
        {
           baseIO = baseio;
           BaseController = (UInt16)(baseIO - 16);
        }
        public UInt16 GetPortIO()
        {
           return baseIO;
        }
        public void SoftReset()
        {
            WI.SetPortValue((UInt16)(BaseController + 2), 0x04, 1);
            ioWait();
            WI.SetPortValue((UInt16)(BaseController + 2), 0x00, 1);
            WI.SetPortValue((UInt16)(baseIO + 7), 0x08, 1);
        }
        public IDEREGS getIDERegsFromUlong(UInt64 i, uint ln, uint cmd)
        {
            string temp = "";
            byte[] bt;
            IDEREGS idr = new IDEREGS();
            idr.Features = 0;
            idr.Command = cmd;
            idr.SectorCount = ln;
            if (Slaver) idr.DriveHead = 0xF0; else idr.DriveHead = 0xE0;
            bt = BitConverter.GetBytes(i);
            for (int j = 0; j < bt.Length; j++)
            {

                if (j == 0)
                {
                    idr.SectorNumber = bt[j];
                }
                if (j == 1)
                {
                    idr.CylinderLow = bt[j];
                }
                if (j == 2)
                {
                    idr.CylinderHigh = bt[j];
                }
                if (j == 3)
                {
                    temp = idr.SectorNumber.ToString("x2");
                    temp = bt[j].ToString("x") + temp;
                    idr.SectorNumber = uint.Parse(temp, System.Globalization.NumberStyles.HexNumber);
                }
                if (j == 4)
                {
                    temp = idr.CylinderLow.ToString("x2");
                    temp = bt[j].ToString("x") + temp;
                    idr.CylinderLow = uint.Parse(temp, System.Globalization.NumberStyles.HexNumber);
                }
                if (j == 5)
                {
                    temp = idr.CylinderHigh.ToString("x2");
                    temp = bt[j].ToString("x") + temp;
                    idr.CylinderHigh = uint.Parse(temp, System.Globalization.NumberStyles.HexNumber);
                }
                if (j == 6)
                {
                    idr.DriveHead = idr.DriveHead + bt[j];
                }
            }
            bt = null;
            return idr;
        }

        public void GetRSE()
        {
            UInt32 Error;
            UInt32 Status;
            WI.GetPortValue((UInt16)(baseIO + 1), &Error, 1);
            WI.GetPortValue((UInt16)(baseIO + 7), &Status, 1);
            rError.setErrorRegister(Error);
            rStatus.setStatusRegister(Status);
        }

        ~PortIo()
        {
            if (tSE!=null)
            {
                tSE.Abort();
                tSE = null;
            }
            rError = null;
            rStatus = null;
            identity = null;
            WI = null;
        }
    }
}
