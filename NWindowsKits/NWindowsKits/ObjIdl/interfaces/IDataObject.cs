// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/ObjIdl.h:12165
    public class IDataObject : IUnknown
    {
        static Guid s_uuid = new Guid("0000010e-0000-0000-c000-000000000046");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int GetData(ref FORMATETC pformatetcIn, IntPtr pmedium)
        {
            if(m_GetDataFunc==null){
                var fp = GetFunctionPointer(3);
                m_GetDataFunc = (GetDataFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDataFunc));
            } 
            return  m_GetDataFunc(m_ptr, ref pformatetcIn, pmedium);
        }
        delegate int GetDataFunc(IntPtr self, ref FORMATETC pformatetcIn, IntPtr pmedium);
        GetDataFunc m_GetDataFunc;

        public int GetDataHere(ref FORMATETC pformatetc, IntPtr pmedium)
        {
            if(m_GetDataHereFunc==null){
                var fp = GetFunctionPointer(4);
                m_GetDataHereFunc = (GetDataHereFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDataHereFunc));
            } 
            return  m_GetDataHereFunc(m_ptr, ref pformatetc, pmedium);
        }
        delegate int GetDataHereFunc(IntPtr self, ref FORMATETC pformatetc, IntPtr pmedium);
        GetDataHereFunc m_GetDataHereFunc;

        public int QueryGetData(ref FORMATETC pformatetc)
        {
            if(m_QueryGetDataFunc==null){
                var fp = GetFunctionPointer(5);
                m_QueryGetDataFunc = (QueryGetDataFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(QueryGetDataFunc));
            } 
            return  m_QueryGetDataFunc(m_ptr, ref pformatetc);
        }
        delegate int QueryGetDataFunc(IntPtr self, ref FORMATETC pformatetc);
        QueryGetDataFunc m_QueryGetDataFunc;

        public int GetCanonicalFormatEtc(ref FORMATETC pformatectIn, ref FORMATETC pformatetcOut)
        {
            if(m_GetCanonicalFormatEtcFunc==null){
                var fp = GetFunctionPointer(6);
                m_GetCanonicalFormatEtcFunc = (GetCanonicalFormatEtcFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetCanonicalFormatEtcFunc));
            } 
            return  m_GetCanonicalFormatEtcFunc(m_ptr, ref pformatectIn, ref pformatetcOut);
        }
        delegate int GetCanonicalFormatEtcFunc(IntPtr self, ref FORMATETC pformatectIn, ref FORMATETC pformatetcOut);
        GetCanonicalFormatEtcFunc m_GetCanonicalFormatEtcFunc;

        public int SetData(ref FORMATETC pformatetc, IntPtr pmedium, int fRelease)
        {
            if(m_SetDataFunc==null){
                var fp = GetFunctionPointer(7);
                m_SetDataFunc = (SetDataFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetDataFunc));
            } 
            return  m_SetDataFunc(m_ptr, ref pformatetc, pmedium, fRelease);
        }
        delegate int SetDataFunc(IntPtr self, ref FORMATETC pformatetc, IntPtr pmedium, int fRelease);
        SetDataFunc m_SetDataFunc;

        public int EnumFormatEtc(uint dwDirection, ref IntPtr ppenumFormatEtc)
        {
            if(m_EnumFormatEtcFunc==null){
                var fp = GetFunctionPointer(8);
                m_EnumFormatEtcFunc = (EnumFormatEtcFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(EnumFormatEtcFunc));
            } 
            return  m_EnumFormatEtcFunc(m_ptr, dwDirection, ref ppenumFormatEtc);
        }
        delegate int EnumFormatEtcFunc(IntPtr self, uint dwDirection, ref IntPtr ppenumFormatEtc);
        EnumFormatEtcFunc m_EnumFormatEtcFunc;

        public int DAdvise(ref FORMATETC pformatetc, uint advf, IntPtr pAdvSink, ref uint pdwConnection)
        {
            if(m_DAdviseFunc==null){
                var fp = GetFunctionPointer(9);
                m_DAdviseFunc = (DAdviseFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DAdviseFunc));
            } 
            return  m_DAdviseFunc(m_ptr, ref pformatetc, advf, pAdvSink, ref pdwConnection);
        }
        delegate int DAdviseFunc(IntPtr self, ref FORMATETC pformatetc, uint advf, IntPtr pAdvSink, ref uint pdwConnection);
        DAdviseFunc m_DAdviseFunc;

        public int DUnadvise(uint dwConnection)
        {
            if(m_DUnadviseFunc==null){
                var fp = GetFunctionPointer(10);
                m_DUnadviseFunc = (DUnadviseFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DUnadviseFunc));
            } 
            return  m_DUnadviseFunc(m_ptr, dwConnection);
        }
        delegate int DUnadviseFunc(IntPtr self, uint dwConnection);
        DUnadviseFunc m_DUnadviseFunc;

        public int EnumDAdvise(ref IntPtr ppenumAdvise)
        {
            if(m_EnumDAdviseFunc==null){
                var fp = GetFunctionPointer(11);
                m_EnumDAdviseFunc = (EnumDAdviseFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(EnumDAdviseFunc));
            } 
            return  m_EnumDAdviseFunc(m_ptr, ref ppenumAdvise);
        }
        delegate int EnumDAdviseFunc(IntPtr self, ref IntPtr ppenumAdvise);
        EnumDAdviseFunc m_EnumDAdviseFunc;

    }
}
