// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/OCIdl.h:1725
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct PROPPAGEINFO // 2
    {
        public uint cb;
        public IntPtr pszTitle;
        public SIZE size;
        public IntPtr pszDocString;
        public IntPtr pszHelpFile;
        public uint dwHelpContext;
    }
}