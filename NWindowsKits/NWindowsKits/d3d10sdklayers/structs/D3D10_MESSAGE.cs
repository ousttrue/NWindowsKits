// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/d3d10sdklayers.h:880
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct D3D10_MESSAGE // 1
    {
        public D3D10_MESSAGE_CATEGORY Category;
        public D3D10_MESSAGE_SEVERITY Severity;
        public D3D10_MESSAGE_ID ID;
        public IntPtr pDescription;
        public ulong DescriptionByteLength;
    }
}