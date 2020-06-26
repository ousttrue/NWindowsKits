// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/objidlbase.h:5894
    public class IAddrTrackingControl : IUnknown
    {
        static Guid s_uuid = new Guid("00000147-0000-0000-c000-000000000046");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int EnableCOMDynamicAddrTracking()
        {
            if(m_EnableCOMDynamicAddrTrackingFunc==null){
                var fp = GetFunctionPointer(3);
                m_EnableCOMDynamicAddrTrackingFunc = (EnableCOMDynamicAddrTrackingFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(EnableCOMDynamicAddrTrackingFunc));
            } 
            return  m_EnableCOMDynamicAddrTrackingFunc(m_ptr);
        }
        delegate int EnableCOMDynamicAddrTrackingFunc(IntPtr self);
        EnableCOMDynamicAddrTrackingFunc m_EnableCOMDynamicAddrTrackingFunc;

        public int DisableCOMDynamicAddrTracking()
        {
            if(m_DisableCOMDynamicAddrTrackingFunc==null){
                var fp = GetFunctionPointer(4);
                m_DisableCOMDynamicAddrTrackingFunc = (DisableCOMDynamicAddrTrackingFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DisableCOMDynamicAddrTrackingFunc));
            } 
            return  m_DisableCOMDynamicAddrTrackingFunc(m_ptr);
        }
        delegate int DisableCOMDynamicAddrTrackingFunc(IntPtr self);
        DisableCOMDynamicAddrTrackingFunc m_DisableCOMDynamicAddrTrackingFunc;

    }
}
