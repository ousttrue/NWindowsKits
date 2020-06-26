// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/objidlbase.h:1604
    public class AsyncIMultiQI : IUnknown
    {
        static Guid s_uuid = new Guid("000e0020-0000-0000-c000-000000000046");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int Begin_QueryMultipleInterfaces(uint cMQIs, ref MULTI_QI pMQIs)
        {
            if(m_Begin_QueryMultipleInterfacesFunc==null){
                var fp = GetFunctionPointer(3);
                m_Begin_QueryMultipleInterfacesFunc = (Begin_QueryMultipleInterfacesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(Begin_QueryMultipleInterfacesFunc));
            } 
            return  m_Begin_QueryMultipleInterfacesFunc(m_ptr, cMQIs, ref pMQIs);
        }
        delegate int Begin_QueryMultipleInterfacesFunc(IntPtr self, uint cMQIs, ref MULTI_QI pMQIs);
        Begin_QueryMultipleInterfacesFunc m_Begin_QueryMultipleInterfacesFunc;

        public int Finish_QueryMultipleInterfaces(ref MULTI_QI pMQIs)
        {
            if(m_Finish_QueryMultipleInterfacesFunc==null){
                var fp = GetFunctionPointer(4);
                m_Finish_QueryMultipleInterfacesFunc = (Finish_QueryMultipleInterfacesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(Finish_QueryMultipleInterfacesFunc));
            } 
            return  m_Finish_QueryMultipleInterfacesFunc(m_ptr, ref pMQIs);
        }
        delegate int Finish_QueryMultipleInterfacesFunc(IntPtr self, ref MULTI_QI pMQIs);
        Finish_QueryMultipleInterfacesFunc m_Finish_QueryMultipleInterfacesFunc;

    }
}
