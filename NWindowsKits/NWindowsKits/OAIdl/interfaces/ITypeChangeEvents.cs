// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/OAIdl.h:4265
    public class ITypeChangeEvents : IUnknown
    {
        static Guid s_uuid = new Guid("00020410-0000-0000-c000-000000000046");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int RequestTypeChange(CHANGEKIND changeKind, IntPtr pTInfoBefore, IntPtr pStrName, ref int pfCancel)
        {
            if(m_RequestTypeChangeFunc==null){
                var fp = GetFunctionPointer(3);
                m_RequestTypeChangeFunc = (RequestTypeChangeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RequestTypeChangeFunc));
            } 
            return  m_RequestTypeChangeFunc(m_ptr, changeKind, pTInfoBefore, pStrName, ref pfCancel);
        }
        delegate int RequestTypeChangeFunc(IntPtr self, CHANGEKIND changeKind, IntPtr pTInfoBefore, IntPtr pStrName, ref int pfCancel);
        RequestTypeChangeFunc m_RequestTypeChangeFunc;

        public int AfterTypeChange(CHANGEKIND changeKind, IntPtr pTInfoAfter, IntPtr pStrName)
        {
            if(m_AfterTypeChangeFunc==null){
                var fp = GetFunctionPointer(4);
                m_AfterTypeChangeFunc = (AfterTypeChangeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AfterTypeChangeFunc));
            } 
            return  m_AfterTypeChangeFunc(m_ptr, changeKind, pTInfoAfter, pStrName);
        }
        delegate int AfterTypeChangeFunc(IntPtr self, CHANGEKIND changeKind, IntPtr pTInfoAfter, IntPtr pStrName);
        AfterTypeChangeFunc m_AfterTypeChangeFunc;

    }
}
