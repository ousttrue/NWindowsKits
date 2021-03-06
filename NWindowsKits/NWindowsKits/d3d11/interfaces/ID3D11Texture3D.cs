// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/d3d11.h:3016
    public class ID3D11Texture3D : ID3D11Resource
    {
        static Guid s_uuid = new Guid("037e866e-f56d-4357-a8af-9dabbe6e250e");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public void GetDesc(ref D3D11_TEXTURE3D_DESC pDesc)
        {
            if(m_GetDescFunc==null){
                var fp = GetFunctionPointer(10);
                m_GetDescFunc = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
            } 
             m_GetDescFunc(m_ptr, ref pDesc);
        }
        delegate void GetDescFunc(IntPtr self, ref D3D11_TEXTURE3D_DESC pDesc);
        GetDescFunc m_GetDescFunc;

    }
}
