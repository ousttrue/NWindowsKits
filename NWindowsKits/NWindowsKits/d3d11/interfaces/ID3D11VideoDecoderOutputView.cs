// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/d3d11.h:11248
    public class ID3D11VideoDecoderOutputView : ID3D11View
    {
        static Guid s_uuid = new Guid("c2931aea-2a85-4f20-860f-fba1fd256e18");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public void GetDesc(ref D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC pDesc)
        {
            if(m_GetDescFunc==null){
                var fp = GetFunctionPointer(8);
                m_GetDescFunc = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
            } 
             m_GetDescFunc(m_ptr, ref pDesc);
        }
        delegate void GetDescFunc(IntPtr self, ref D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC pDesc);
        GetDescFunc m_GetDescFunc;

    }
}
