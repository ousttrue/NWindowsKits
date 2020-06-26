// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/d3d10.h:3929
    public class ID3D10SamplerState : ID3D10DeviceChild
    {
        static Guid s_uuid = new Guid("9b7e4c0c-342c-4106-a19f-4f2704f689f0");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public void GetDesc(ref D3D10_SAMPLER_DESC pDesc)
        {
            if(m_GetDescFunc==null){
                var fp = GetFunctionPointer(7);
                m_GetDescFunc = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
            } 
             m_GetDescFunc(m_ptr, ref pDesc);
        }
        delegate void GetDescFunc(IntPtr self, ref D3D10_SAMPLER_DESC pDesc);
        GetDescFunc m_GetDescFunc;

    }
}
