// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/wingdi.h:1439
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct LOGPALETTE // 4
    {
        public ushort palVersion;
        public ushort palNumEntries;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] public PALETTEENTRY[] palPalEntry;
    }
}