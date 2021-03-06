// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/propidlbase.h:707
    public class IPropertySetStorage : IUnknown
    {
        static Guid s_uuid = new Guid("0000013a-0000-0000-c000-000000000046");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int Create(ref Guid rfmtid, IntPtr pclsid, uint grfFlags, uint grfMode, ref IntPtr ppprstg)
        {
            if(m_CreateFunc==null){
                var fp = GetFunctionPointer(3);
                m_CreateFunc = (CreateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateFunc));
            } 
            return  m_CreateFunc(m_ptr, ref rfmtid, pclsid, grfFlags, grfMode, ref ppprstg);
        }
        delegate int CreateFunc(IntPtr self, ref Guid rfmtid, IntPtr pclsid, uint grfFlags, uint grfMode, ref IntPtr ppprstg);
        CreateFunc m_CreateFunc;

        public int Open(ref Guid rfmtid, uint grfMode, ref IntPtr ppprstg)
        {
            if(m_OpenFunc==null){
                var fp = GetFunctionPointer(4);
                m_OpenFunc = (OpenFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OpenFunc));
            } 
            return  m_OpenFunc(m_ptr, ref rfmtid, grfMode, ref ppprstg);
        }
        delegate int OpenFunc(IntPtr self, ref Guid rfmtid, uint grfMode, ref IntPtr ppprstg);
        OpenFunc m_OpenFunc;

        public int Delete(ref Guid rfmtid)
        {
            if(m_DeleteFunc==null){
                var fp = GetFunctionPointer(5);
                m_DeleteFunc = (DeleteFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DeleteFunc));
            } 
            return  m_DeleteFunc(m_ptr, ref rfmtid);
        }
        delegate int DeleteFunc(IntPtr self, ref Guid rfmtid);
        DeleteFunc m_DeleteFunc;

        public int Enum(ref IntPtr ppenum)
        {
            if(m_EnumFunc==null){
                var fp = GetFunctionPointer(6);
                m_EnumFunc = (EnumFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(EnumFunc));
            } 
            return  m_EnumFunc(m_ptr, ref ppenum);
        }
        delegate int EnumFunc(IntPtr self, ref IntPtr ppenum);
        EnumFunc m_EnumFunc;

    }
}
