// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/WinUser.h:1152
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct DEBUGHOOKINFO
    {

        public uint idThread;
        public uint idThreadInstaller;
        public long lParam;
        public ulong wParam;
        public int code;
    }
}
