// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/winuser.h:1765
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct WNDCLASSEXA // 4
    {
        public uint cbSize;
        public uint style;
        public WNDPROC lpfnWndProc;
        public int cbClsExtra;
        public int cbWndExtra;
        public HMODULE hInstance;
        public HCURSOR hIcon;
        public HCURSOR hCursor;
        public HBRUSH hbrBackground;
        [MarshalAs(UnmanagedType.LPStr)] public string lpszMenuName;
        [MarshalAs(UnmanagedType.LPStr)] public string lpszClassName;
        public HCURSOR hIconSm;
    }
}
