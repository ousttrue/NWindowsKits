// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/d3d10.h:2729
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct D3D10_BUFFER_SRV
    {
        // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/d3d10.h:2731
        [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
        public struct __Anonymous__0
        {
    
    
            [FieldOffset(0)] public uint FirstElement;
    
            [FieldOffset(0)] public uint ElementOffset;
        }
    
        // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/d3d10.h:2736
        [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
        public struct __Anonymous__1
        {
    
    
            [FieldOffset(0)] public uint NumElements;
    
            [FieldOffset(0)] public uint ElementWidth;
        }
    

        public __Anonymous__0 __field__0;
        public __Anonymous__1 __field__1;
    }
}
