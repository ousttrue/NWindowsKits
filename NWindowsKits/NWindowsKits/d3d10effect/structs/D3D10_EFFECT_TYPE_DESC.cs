// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/d3d10effect.h:271
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct D3D10_EFFECT_TYPE_DESC // 1
    {
        [MarshalAs(UnmanagedType.LPStr)] public string TypeName;
        public D3D_SHADER_VARIABLE_CLASS Class;
        public D3D_SHADER_VARIABLE_TYPE Type;
        public uint Elements;
        public uint Members;
        public uint Rows;
        public uint Columns;
        public uint PackedSize;
        public uint UnpackedSize;
        public uint Stride;
    }
}