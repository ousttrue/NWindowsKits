// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/ObjIdl.h:11829
    public class IAdviseSink2 : IAdviseSink // 1
    {
        static Guid s_uuid = new Guid("00000125-0000-0000-c000-000000000046");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public void OnLinkSrcChange(IntPtr pmk)
        {
            if(m_OnLinkSrcChangeFunc==null){
                var fp = GetFunctionPointer(8);
                m_OnLinkSrcChangeFunc = (OnLinkSrcChangeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OnLinkSrcChangeFunc));
            } 
             m_OnLinkSrcChangeFunc(m_ptr, pmk);
        }
        delegate void OnLinkSrcChangeFunc(IntPtr self, IntPtr pmk);
        OnLinkSrcChangeFunc m_OnLinkSrcChangeFunc;

    }
}
