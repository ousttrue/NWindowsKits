// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/wingdi.h:2249
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct DEVMODEW
    {
        // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/wingdi.h:2256
        [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
        public struct __Anonymous__0
        {
    
    
            [FieldOffset(0)] public __Anonymous__1 __field__0;
    
            [FieldOffset(0)] public __Anonymous__2 __field__1;
        }
    
        // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/wingdi.h:2258
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct __Anonymous__1
        {
    
            public short dmOrientation;
            public short dmPaperSize;
            public short dmPaperLength;
            public short dmPaperWidth;
            public short dmScale;
            public short dmCopies;
            public short dmDefaultSource;
            public short dmPrintQuality;
        }
    
        // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/wingdi.h:2269
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct __Anonymous__2
        {
    
            public POINTL dmPosition;
            public uint dmDisplayOrientation;
            public uint dmDisplayFixedOutput;
        }
    
        // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/wingdi.h:2285
        [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
        public struct __Anonymous__3
        {
    
    
            [FieldOffset(0)] public uint dmDisplayFlags;
    
            [FieldOffset(0)] public uint dmNup;
        }
    

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)] public string dmDeviceName;
        public ushort dmSpecVersion;
        public ushort dmDriverVersion;
        public ushort dmSize;
        public ushort dmDriverExtra;
        public uint dmFields;
        public __Anonymous__0 __field__6;
        public short dmColor;
        public short dmDuplex;
        public short dmYResolution;
        public short dmTTOption;
        public short dmCollate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)] public string dmFormName;
        public ushort dmLogPixels;
        public uint dmBitsPerPel;
        public uint dmPelsWidth;
        public uint dmPelsHeight;
        public __Anonymous__3 __field__17;
        public uint dmDisplayFrequency;
        public uint dmICMMethod;
        public uint dmICMIntent;
        public uint dmMediaType;
        public uint dmDitherType;
        public uint dmReserved1;
        public uint dmReserved2;
        public uint dmPanningWidth;
        public uint dmPanningHeight;
    }
}
