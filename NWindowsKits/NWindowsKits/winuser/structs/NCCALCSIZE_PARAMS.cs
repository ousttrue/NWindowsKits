// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/WinUser.h:2698
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct NCCALCSIZE_PARAMS
    {

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)] public RECT[] rgrc;
        public IntPtr lppos;
    }
}
