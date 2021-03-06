// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/d3d10.h:2794
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct D3D10_SHADER_RESOURCE_VIEW_DESC
    {
        // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/d3d10.h:2798
        [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
        public struct __Anonymous__0
        {
    
    
            [FieldOffset(0)] public D3D10_BUFFER_SRV Buffer;
    
            [FieldOffset(0)] public D3D10_TEX1D_SRV Texture1D;
    
            [FieldOffset(0)] public D3D10_TEX1D_ARRAY_SRV Texture1DArray;
    
            [FieldOffset(0)] public D3D10_TEX2D_SRV Texture2D;
    
            [FieldOffset(0)] public D3D10_TEX2D_ARRAY_SRV Texture2DArray;
    
            [FieldOffset(0)] public D3D10_TEX2DMS_SRV Texture2DMS;
    
            [FieldOffset(0)] public D3D10_TEX2DMS_ARRAY_SRV Texture2DMSArray;
    
            [FieldOffset(0)] public D3D10_TEX3D_SRV Texture3D;
    
            [FieldOffset(0)] public D3D10_TEXCUBE_SRV TextureCube;
        }
    

        public DXGI_FORMAT Format;
        public D3D_SRV_DIMENSION ViewDimension;
        public __Anonymous__0 __field__2;
    }
}
