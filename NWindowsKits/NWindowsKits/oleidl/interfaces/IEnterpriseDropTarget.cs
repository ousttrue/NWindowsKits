// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/oleidl.h:3721
    public class IEnterpriseDropTarget : IUnknown
    {
        static Guid s_uuid = new Guid("390e3878-fd55-4e18-819d-4682081c0cfd");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int SetDropSourceEnterpriseId([MarshalAs(UnmanagedType.LPWStr)] string identity)
        {
            if(m_SetDropSourceEnterpriseIdFunc==null){
                var fp = GetFunctionPointer(3);
                m_SetDropSourceEnterpriseIdFunc = (SetDropSourceEnterpriseIdFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetDropSourceEnterpriseIdFunc));
            } 
            return  m_SetDropSourceEnterpriseIdFunc(m_ptr, identity);
        }
        delegate int SetDropSourceEnterpriseIdFunc(IntPtr self, [MarshalAs(UnmanagedType.LPWStr)] string identity);
        SetDropSourceEnterpriseIdFunc m_SetDropSourceEnterpriseIdFunc;

        public int IsEvaluatingEdpPolicy(ref int value)
        {
            if(m_IsEvaluatingEdpPolicyFunc==null){
                var fp = GetFunctionPointer(4);
                m_IsEvaluatingEdpPolicyFunc = (IsEvaluatingEdpPolicyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IsEvaluatingEdpPolicyFunc));
            } 
            return  m_IsEvaluatingEdpPolicyFunc(m_ptr, ref value);
        }
        delegate int IsEvaluatingEdpPolicyFunc(IntPtr self, ref int value);
        IsEvaluatingEdpPolicyFunc m_IsEvaluatingEdpPolicyFunc;

    }
}
