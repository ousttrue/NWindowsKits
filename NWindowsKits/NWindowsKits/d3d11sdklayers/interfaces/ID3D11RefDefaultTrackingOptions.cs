// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/d3d11sdklayers.h:640
    public class ID3D11RefDefaultTrackingOptions : IUnknown // 1
    {
        static Guid s_uuid = new Guid("03916615-c644-418c-9bf4-75db5be63ca0");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int SetTrackingOptions(uint ResourceTypeFlags, uint Options)
        {
            if(m_SetTrackingOptionsFunc==null){
                var fp = GetFunctionPointer(3);
                m_SetTrackingOptionsFunc = (SetTrackingOptionsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetTrackingOptionsFunc));
            } 
            return  m_SetTrackingOptionsFunc(m_ptr, ResourceTypeFlags, Options);
        }
        delegate int SetTrackingOptionsFunc(IntPtr self, uint ResourceTypeFlags, uint Options);
        SetTrackingOptionsFunc m_SetTrackingOptionsFunc;

    }
}
