// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/d3d11.h:4824
    public class ID3D11UnorderedAccessView : ID3D11View
    {
        static Guid s_uuid = new Guid("28acf509-7f5c-48f6-8611-f316010a6380");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public void GetDesc(ref D3D11_UNORDERED_ACCESS_VIEW_DESC pDesc)
        {
            if(m_GetDescFunc==null){
                var fp = GetFunctionPointer(8);
                m_GetDescFunc = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
            } 
             m_GetDescFunc(m_ptr, ref pDesc);
        }
        delegate void GetDescFunc(IntPtr self, ref D3D11_UNORDERED_ACCESS_VIEW_DESC pDesc);
        GetDescFunc m_GetDescFunc;

    }
}
