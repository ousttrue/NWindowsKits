// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/WinUser.h:10897
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct ICONINFOEXW // 2
    {
        public uint cbSize;
        public int fIcon;
        public uint xHotspot;
        public uint yHotspot;
        public HBITMAP hbmMask;
        public HBITMAP hbmColor;
        public ushort wResID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)] public string szModName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)] public string szResName;
    }
}