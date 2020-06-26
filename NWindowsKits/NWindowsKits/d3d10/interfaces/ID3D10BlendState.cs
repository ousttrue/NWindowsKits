// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/d3d10.h:1214
    public class ID3D10BlendState : ID3D10DeviceChild // 1
    {
        static Guid s_uuid = new Guid("edad8d19-8a35-4d6d-8566-2ea276cde161");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public void GetDesc(ref D3D10_BLEND_DESC pDesc)
        {
            if(m_GetDescFunc==null){
                var fp = GetFunctionPointer(7);
                m_GetDescFunc = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
            } 
             m_GetDescFunc(m_ptr, ref pDesc);
        }
        delegate void GetDescFunc(IntPtr self, ref D3D10_BLEND_DESC pDesc);
        GetDescFunc m_GetDescFunc;

    }
}
