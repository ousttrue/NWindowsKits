// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/d3d11.h:11585
    public class ID3D11VideoProcessorOutputView : ID3D11View
    {
        static Guid s_uuid = new Guid("a048285e-25a9-4527-bd93-d68b68c44254");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public void GetDesc(ref D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC pDesc)
        {
            if(m_GetDescFunc==null){
                var fp = GetFunctionPointer(8);
                m_GetDescFunc = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
            } 
             m_GetDescFunc(m_ptr, ref pDesc);
        }
        delegate void GetDescFunc(IntPtr self, ref D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC pDesc);
        GetDescFunc m_GetDescFunc;

    }
}
