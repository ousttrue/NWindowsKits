// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/d3d11sdklayers.h:560
    public class ID3D11RefTrackingOptions : IUnknown // 1
    {
        static Guid s_uuid = new Guid("193dacdf-0db2-4c05-a55c-ef06cac56fd9");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int SetTrackingOptions(uint uOptions)
        {
            if(m_SetTrackingOptionsFunc==null){
                var fp = GetFunctionPointer(3);
                m_SetTrackingOptionsFunc = (SetTrackingOptionsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetTrackingOptionsFunc));
            } 
            return  m_SetTrackingOptionsFunc(m_ptr, uOptions);
        }
        delegate int SetTrackingOptionsFunc(IntPtr self, uint uOptions);
        SetTrackingOptionsFunc m_SetTrackingOptionsFunc;

    }
}
