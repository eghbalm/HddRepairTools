using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HddRepairTools
{
    public class IDENTITY
    {
        PortIo p;
        public IDSECTOR idsector;
        private UInt64 LBA;
        public IDENTITY(PortIo pi)
        {
            p = pi;
            idsector = new IDSECTOR();
        }

        public string SwapChars(string chars)
        {
            string strs = "";
            for (int i = 0; i <= chars.Length - 2; i += 2)
            {
                strs += chars[i + 1].ToString() + chars[i].ToString();
            }
            strs = strs.Replace(" ", "");
            return strs;
        } 
        

        public bool IdentityDevice()
        {
            IDEREGS irIdentity = new IDEREGS();
            byte[] IdentityBuffer;
            irIdentity.Command = 0xec;
            if (p.Slaver)
            {
                irIdentity.DriveHead = 0xb0;
            }
            else
            {
                irIdentity.DriveHead = 0xa0;
            }
            p.SendATACommand(irIdentity);
            IdentityBuffer = p.GetSectors();
            if (IdentityBuffer.Length<512)
            {
                return false;
            }
            idsector= fromBytes(IdentityBuffer);
            return true;
        }

        public IDSECTOR fromBytes(byte[] arr)
        {
            IDSECTOR str = new IDSECTOR();
            int size = Marshal.SizeOf(str);
            IntPtr ptr = Marshal.AllocHGlobal(size);
            Marshal.Copy(arr, 0, ptr, size);
            str = (IDSECTOR)Marshal.PtrToStructure(ptr, str.GetType());
            Marshal.FreeHGlobal(ptr);
            return str;
        }
        public byte[] getBytes(IDSECTOR str)
        {
            int size = Marshal.SizeOf(str);
            byte[] arr = new byte[size];
            IntPtr ptr = Marshal.AllocHGlobal(size);
            Marshal.StructureToPtr(str, ptr, true);
            Marshal.Copy(ptr, arr, 0, size);
            Marshal.FreeHGlobal(ptr);
            return arr;
        }
    }

}
