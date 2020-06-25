// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/OAIdl.h:2200
    public class IDispatch : IUnknown // 4
    {
        static Guid s_uuid = new Guid("00020400-0000-0000-c000-000000000046");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int GetTypeInfoCount(ref uint pctinfo)
        {
            if(m_GetTypeInfoCountFunc==null){
                var fp = GetFunctionPointer(3);
                m_GetTypeInfoCountFunc = (GetTypeInfoCountFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetTypeInfoCountFunc));
            } 
            
            return  m_GetTypeInfoCountFunc(m_ptr, ref pctinfo);
        }
        delegate int GetTypeInfoCountFunc(IntPtr self, ref uint pctinfo);
        GetTypeInfoCountFunc m_GetTypeInfoCountFunc;

        public int GetTypeInfo(uint iTInfo, uint lcid, ref IntPtr ppTInfo)
        {
            if(m_GetTypeInfoFunc==null){
                var fp = GetFunctionPointer(4);
                m_GetTypeInfoFunc = (GetTypeInfoFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetTypeInfoFunc));
            } 
            
            return  m_GetTypeInfoFunc(m_ptr, iTInfo, lcid, ref ppTInfo);
        }
        delegate int GetTypeInfoFunc(IntPtr self, uint iTInfo, uint lcid, ref IntPtr ppTInfo);
        GetTypeInfoFunc m_GetTypeInfoFunc;

        public int GetIDsOfNames(ref Guid riid, ref IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
        {
            if(m_GetIDsOfNamesFunc==null){
                var fp = GetFunctionPointer(5);
                m_GetIDsOfNamesFunc = (GetIDsOfNamesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetIDsOfNamesFunc));
            } 
            
            return  m_GetIDsOfNamesFunc(m_ptr, ref riid, ref rgszNames, cNames, lcid, rgDispId);
        }
        delegate int GetIDsOfNamesFunc(IntPtr self, ref Guid riid, ref IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
        GetIDsOfNamesFunc m_GetIDsOfNamesFunc;

        public int Invoke(int dispIdMember, ref Guid riid, uint lcid, ushort wFlags, ref DISPPARAMS pDispParams, ref VARIANT pVarResult, ref EXCEPINFO pExcepInfo, ref uint puArgErr)
        {
            if(m_InvokeFunc==null){
                var fp = GetFunctionPointer(6);
                m_InvokeFunc = (InvokeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(InvokeFunc));
            } 
            
            return  m_InvokeFunc(m_ptr, dispIdMember, ref riid, lcid, wFlags, ref pDispParams, ref pVarResult, ref pExcepInfo, ref puArgErr);
        }
        delegate int InvokeFunc(IntPtr self, int dispIdMember, ref Guid riid, uint lcid, ushort wFlags, ref DISPPARAMS pDispParams, ref VARIANT pVarResult, ref EXCEPINFO pExcepInfo, ref uint puArgErr);
        InvokeFunc m_InvokeFunc;

    }
}