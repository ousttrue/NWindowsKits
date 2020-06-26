// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/urlmon.h:8888
    public class IInternetZoneManagerEx : IInternetZoneManager // 1
    {
        static Guid s_uuid = new Guid("a4c23339-8e06-431e-9bf4-7e711c085648");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int GetZoneActionPolicyEx(uint dwZone, uint dwAction, ref byte pPolicy, uint cbPolicy, URLZONEREG urlZoneReg, uint dwFlags)
        {
            if(m_GetZoneActionPolicyExFunc==null){
                var fp = GetFunctionPointer(15);
                m_GetZoneActionPolicyExFunc = (GetZoneActionPolicyExFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetZoneActionPolicyExFunc));
            } 
            return  m_GetZoneActionPolicyExFunc(m_ptr, dwZone, dwAction, ref pPolicy, cbPolicy, urlZoneReg, dwFlags);
        }
        delegate int GetZoneActionPolicyExFunc(IntPtr self, uint dwZone, uint dwAction, ref byte pPolicy, uint cbPolicy, URLZONEREG urlZoneReg, uint dwFlags);
        GetZoneActionPolicyExFunc m_GetZoneActionPolicyExFunc;

        public int SetZoneActionPolicyEx(uint dwZone, uint dwAction, ref byte pPolicy, uint cbPolicy, URLZONEREG urlZoneReg, uint dwFlags)
        {
            if(m_SetZoneActionPolicyExFunc==null){
                var fp = GetFunctionPointer(16);
                m_SetZoneActionPolicyExFunc = (SetZoneActionPolicyExFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetZoneActionPolicyExFunc));
            } 
            return  m_SetZoneActionPolicyExFunc(m_ptr, dwZone, dwAction, ref pPolicy, cbPolicy, urlZoneReg, dwFlags);
        }
        delegate int SetZoneActionPolicyExFunc(IntPtr self, uint dwZone, uint dwAction, ref byte pPolicy, uint cbPolicy, URLZONEREG urlZoneReg, uint dwFlags);
        SetZoneActionPolicyExFunc m_SetZoneActionPolicyExFunc;

    }
}
