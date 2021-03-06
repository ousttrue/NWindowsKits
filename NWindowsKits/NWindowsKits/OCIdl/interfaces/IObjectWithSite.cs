// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/OCIdl.h:5752
    public class IObjectWithSite : IUnknown
    {
        static Guid s_uuid = new Guid("fc4801a3-2ba9-11cf-a229-00aa003d7352");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int SetSite(IntPtr pUnkSite)
        {
            if(m_SetSiteFunc==null){
                var fp = GetFunctionPointer(3);
                m_SetSiteFunc = (SetSiteFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetSiteFunc));
            } 
            return  m_SetSiteFunc(m_ptr, pUnkSite);
        }
        delegate int SetSiteFunc(IntPtr self, IntPtr pUnkSite);
        SetSiteFunc m_SetSiteFunc;

        public int GetSite(ref Guid riid, ref IntPtr ppvSite)
        {
            if(m_GetSiteFunc==null){
                var fp = GetFunctionPointer(4);
                m_GetSiteFunc = (GetSiteFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetSiteFunc));
            } 
            return  m_GetSiteFunc(m_ptr, ref riid, ref ppvSite);
        }
        delegate int GetSiteFunc(IntPtr self, ref Guid riid, ref IntPtr ppvSite);
        GetSiteFunc m_GetSiteFunc;

    }
}
