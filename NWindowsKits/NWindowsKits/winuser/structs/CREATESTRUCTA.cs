// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/WinUser.h:3198
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct CREATESTRUCTA
    {

        public IntPtr lpCreateParams;
        public HINSTANCE hInstance;
        public HMENU hMenu;
        public HWND hwndParent;
        public int cy;
        public int cx;
        public int y;
        public int x;
        public int style;
        [MarshalAs(UnmanagedType.LPStr)] public string lpszName;
        [MarshalAs(UnmanagedType.LPStr)] public string lpszClass;
        public uint dwExStyle;
    }
}
