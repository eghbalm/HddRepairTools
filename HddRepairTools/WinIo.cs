using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HddRepairTools
{
    public unsafe class WinIo
    {

        [DllImport("kernel32.dll")]
        private extern static IntPtr LoadLibrary(String DllName);

        [DllImport("kernel32.dll")]
        private extern static IntPtr GetProcAddress(IntPtr hModule, String ProcName);

        [DllImport("kernel32")]
        private extern static bool FreeLibrary(IntPtr hModule);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool InitializeWinIo();

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool GetPhysLong(IntPtr PhysAddr, UInt32* pPhysVal);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool SetPhysLong(uint PhysAddr, UInt32 PhysVal);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool GetPortVal(uint wPortAddr, UInt32* pdwPortVal, byte bSize);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool SetPortVal(uint wPortAddr, UInt32 pdwPortVal, byte bSize);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool ShutdownWinIo();

        InitializeWinIo InitWinIo = null;
        GetPortVal GetPVal = null;
        SetPortVal SetPVal = null;
        ShutdownWinIo ShtWinIo = null;
        IntPtr hMod;

        public WinIo()
        {
            hMod = LoadLibrary("WinIo.dll");

            if (hMod == IntPtr.Zero)
            {
                MessageBox.Show("Can't find WinIo.dll. Make sure the WinIo.dll library files are located in the same directory as your executable file.");
            }

            IntPtr pFunc = GetProcAddress(hMod, "InitializeWinIo");
            if (pFunc != IntPtr.Zero)
            {
                InitWinIo = (InitializeWinIo)Marshal.GetDelegateForFunctionPointer(pFunc, typeof(InitializeWinIo));
                bool result = InitWinIo();
                if (!result)
                {
                    FreeLibrary(hMod);
                    hMod = IntPtr.Zero;
                    MessageBox.Show("Error returned from InitializeWinIo. Make sure you are running with administrative privilages are that WinIo library files are located in the same directory as your executable file.");
                    // throw new Exception(msg);
                }
            }
        }

        ~WinIo()
        {
            if (hMod != IntPtr.Zero)
            {
                IntPtr pFunc = GetProcAddress(hMod, "ShutdownWinIo");
                if (pFunc != IntPtr.Zero)
                {
                    this.GetPVal = null;
                    this.SetPVal = null;

                    ShtWinIo = (ShutdownWinIo)Marshal.GetDelegateForFunctionPointer(pFunc, typeof(ShutdownWinIo));
                    ShtWinIo();

                    FreeLibrary(hMod);
                    hMod = IntPtr.Zero;
                }
            }
        }

        public void Close()
        {
            if (hMod != IntPtr.Zero)
            {
                IntPtr pFunc = GetProcAddress(hMod, "ShutdownWinIo");
                if (pFunc != IntPtr.Zero)
                {
                    this.GetPVal = null;
                    this.SetPVal = null;

                    ShtWinIo = (ShutdownWinIo)Marshal.GetDelegateForFunctionPointer(pFunc, typeof(ShutdownWinIo));
                    ShtWinIo();

                    FreeLibrary(hMod);
                    hMod = IntPtr.Zero;
                }
            }
        }

        public bool GetPortValue(UInt16 portAddress, UInt32* dddd, byte bt)
        {
            if (hMod != IntPtr.Zero)
            {
                if (this.GetPVal == null)
                {
                    IntPtr pFunc = GetProcAddress(hMod, "GetPortVal");
                    if (pFunc != IntPtr.Zero)
                    {
                        this.GetPVal = (GetPortVal)Marshal.GetDelegateForFunctionPointer(pFunc, typeof(GetPortVal));
                    }
                    else
                    {
                        return false;
                    }
                }

                if (!this.GetPVal(portAddress, dddd, bt))
                {
                    return false;
                }
            }

            return true;
        }

        public bool SetPortValue(UInt16 portAddress, UInt32 portValue, byte bt)
        {
            if (hMod != IntPtr.Zero)
            {
                if (this.SetPVal == null)
                {
                    IntPtr pFunc = GetProcAddress(this.hMod, "SetPortVal");
                    if (pFunc != IntPtr.Zero)
                    {
                        this.SetPVal = (SetPortVal)Marshal.GetDelegateForFunctionPointer(pFunc, typeof(SetPortVal));
                    }
                    else
                    {
                        return false;
                    }
                }

                bool result = this.SetPVal(portAddress, portValue, bt);
                if (!result)
                {
                    return false;
                }
            }
            return true;
        }       
    }
}
