// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/urlmon.h:8063
    public class IInternetHostSecurityManager : IUnknown
    {
        static Guid s_uuid = new Guid("3af280b6-cb3f-11d0-891e-00c04fb6bfc4");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int GetSecurityId(ref byte pbSecurityId, ref uint pcbSecurityId, ulong dwReserved)
        {
            if(m_GetSecurityIdFunc==null){
                var fp = GetFunctionPointer(3);
                m_GetSecurityIdFunc = (GetSecurityIdFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetSecurityIdFunc));
            } 
            return  m_GetSecurityIdFunc(m_ptr, ref pbSecurityId, ref pcbSecurityId, dwReserved);
        }
        delegate int GetSecurityIdFunc(IntPtr self, ref byte pbSecurityId, ref uint pcbSecurityId, ulong dwReserved);
        GetSecurityIdFunc m_GetSecurityIdFunc;

        public int ProcessUrlAction(uint dwAction, ref byte pPolicy, uint cbPolicy, ref byte pContext, uint cbContext, uint dwFlags, uint dwReserved)
        {
            if(m_ProcessUrlActionFunc==null){
                var fp = GetFunctionPointer(4);
                m_ProcessUrlActionFunc = (ProcessUrlActionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ProcessUrlActionFunc));
            } 
            return  m_ProcessUrlActionFunc(m_ptr, dwAction, ref pPolicy, cbPolicy, ref pContext, cbContext, dwFlags, dwReserved);
        }
        delegate int ProcessUrlActionFunc(IntPtr self, uint dwAction, ref byte pPolicy, uint cbPolicy, ref byte pContext, uint cbContext, uint dwFlags, uint dwReserved);
        ProcessUrlActionFunc m_ProcessUrlActionFunc;

        public int QueryCustomPolicy(ref GUID guidKey, ref IntPtr ppPolicy, ref uint pcbPolicy, ref byte pContext, uint cbContext, uint dwReserved)
        {
            if(m_QueryCustomPolicyFunc==null){
                var fp = GetFunctionPointer(5);
                m_QueryCustomPolicyFunc = (QueryCustomPolicyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(QueryCustomPolicyFunc));
            } 
            return  m_QueryCustomPolicyFunc(m_ptr, ref guidKey, ref ppPolicy, ref pcbPolicy, ref pContext, cbContext, dwReserved);
        }
        delegate int QueryCustomPolicyFunc(IntPtr self, ref GUID guidKey, ref IntPtr ppPolicy, ref uint pcbPolicy, ref byte pContext, uint cbContext, uint dwReserved);
        QueryCustomPolicyFunc m_QueryCustomPolicyFunc;

    }
}
