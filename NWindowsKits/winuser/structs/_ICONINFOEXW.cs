// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/winuser.h:10897
    [StructLayout(LayoutKind.Sequential)]
    public struct _ICONINFOEXW // 2
    {
        public uint cbSize;
        public int fIcon;
        public uint xHotspot;
        public uint yHotspot;
        public HBITMAP hbmMask;
        public HBITMAP hbmColor;
        public ushort wResID;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 260)] public ushort[] szModName;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 260)] public ushort[] szResName;
    }
}