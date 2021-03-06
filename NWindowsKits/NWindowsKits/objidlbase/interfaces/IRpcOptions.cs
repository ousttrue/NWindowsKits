// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/objidlbase.h:4314
    public class IRpcOptions : IUnknown
    {
        static Guid s_uuid = new Guid("00000144-0000-0000-c000-000000000046");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int Set(IntPtr pPrx, RPCOPT_PROPERTIES dwProperty, ulong dwValue)
        {
            if(m_SetFunc==null){
                var fp = GetFunctionPointer(3);
                m_SetFunc = (SetFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetFunc));
            } 
            return  m_SetFunc(m_ptr, pPrx, dwProperty, dwValue);
        }
        delegate int SetFunc(IntPtr self, IntPtr pPrx, RPCOPT_PROPERTIES dwProperty, ulong dwValue);
        SetFunc m_SetFunc;

        public int Query(IntPtr pPrx, RPCOPT_PROPERTIES dwProperty, ref ulong pdwValue)
        {
            if(m_QueryFunc==null){
                var fp = GetFunctionPointer(4);
                m_QueryFunc = (QueryFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(QueryFunc));
            } 
            return  m_QueryFunc(m_ptr, pPrx, dwProperty, ref pdwValue);
        }
        delegate int QueryFunc(IntPtr self, IntPtr pPrx, RPCOPT_PROPERTIES dwProperty, ref ulong pdwValue);
        QueryFunc m_QueryFunc;

    }
}
