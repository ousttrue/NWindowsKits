// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/WinUser.h:15539
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct GESTURENOTIFYSTRUCT // 2
    {
        public uint cbSize;
        public uint dwFlags;
        public HWND hwndTarget;
        public POINTS ptsLocation;
        public uint dwInstanceID;
    }
}