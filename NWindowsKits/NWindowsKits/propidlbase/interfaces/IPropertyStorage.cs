// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/propidlbase.h:491
    public class IPropertyStorage : IUnknown
    {
        static Guid s_uuid = new Guid("00000138-0000-0000-c000-000000000046");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int ReadMultiple(uint cpspec, ref PROPSPEC rgpspec, ref PROPVARIANT rgpropvar)
        {
            if(m_ReadMultipleFunc==null){
                var fp = GetFunctionPointer(3);
                m_ReadMultipleFunc = (ReadMultipleFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReadMultipleFunc));
            } 
            return  m_ReadMultipleFunc(m_ptr, cpspec, ref rgpspec, ref rgpropvar);
        }
        delegate int ReadMultipleFunc(IntPtr self, uint cpspec, ref PROPSPEC rgpspec, ref PROPVARIANT rgpropvar);
        ReadMultipleFunc m_ReadMultipleFunc;

        public int WriteMultiple(uint cpspec, ref PROPSPEC rgpspec, ref PROPVARIANT rgpropvar, uint propidNameFirst)
        {
            if(m_WriteMultipleFunc==null){
                var fp = GetFunctionPointer(4);
                m_WriteMultipleFunc = (WriteMultipleFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(WriteMultipleFunc));
            } 
            return  m_WriteMultipleFunc(m_ptr, cpspec, ref rgpspec, ref rgpropvar, propidNameFirst);
        }
        delegate int WriteMultipleFunc(IntPtr self, uint cpspec, ref PROPSPEC rgpspec, ref PROPVARIANT rgpropvar, uint propidNameFirst);
        WriteMultipleFunc m_WriteMultipleFunc;

        public int DeleteMultiple(uint cpspec, ref PROPSPEC rgpspec)
        {
            if(m_DeleteMultipleFunc==null){
                var fp = GetFunctionPointer(5);
                m_DeleteMultipleFunc = (DeleteMultipleFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DeleteMultipleFunc));
            } 
            return  m_DeleteMultipleFunc(m_ptr, cpspec, ref rgpspec);
        }
        delegate int DeleteMultipleFunc(IntPtr self, uint cpspec, ref PROPSPEC rgpspec);
        DeleteMultipleFunc m_DeleteMultipleFunc;

        public int ReadPropertyNames(uint cpropid, IntPtr rgpropid, ref IntPtr rglpwstrName)
        {
            if(m_ReadPropertyNamesFunc==null){
                var fp = GetFunctionPointer(6);
                m_ReadPropertyNamesFunc = (ReadPropertyNamesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReadPropertyNamesFunc));
            } 
            return  m_ReadPropertyNamesFunc(m_ptr, cpropid, rgpropid, ref rglpwstrName);
        }
        delegate int ReadPropertyNamesFunc(IntPtr self, uint cpropid, IntPtr rgpropid, ref IntPtr rglpwstrName);
        ReadPropertyNamesFunc m_ReadPropertyNamesFunc;

        public int WritePropertyNames(uint cpropid, IntPtr rgpropid, ref IntPtr rglpwstrName)
        {
            if(m_WritePropertyNamesFunc==null){
                var fp = GetFunctionPointer(7);
                m_WritePropertyNamesFunc = (WritePropertyNamesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(WritePropertyNamesFunc));
            } 
            return  m_WritePropertyNamesFunc(m_ptr, cpropid, rgpropid, ref rglpwstrName);
        }
        delegate int WritePropertyNamesFunc(IntPtr self, uint cpropid, IntPtr rgpropid, ref IntPtr rglpwstrName);
        WritePropertyNamesFunc m_WritePropertyNamesFunc;

        public int DeletePropertyNames(uint cpropid, IntPtr rgpropid)
        {
            if(m_DeletePropertyNamesFunc==null){
                var fp = GetFunctionPointer(8);
                m_DeletePropertyNamesFunc = (DeletePropertyNamesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DeletePropertyNamesFunc));
            } 
            return  m_DeletePropertyNamesFunc(m_ptr, cpropid, rgpropid);
        }
        delegate int DeletePropertyNamesFunc(IntPtr self, uint cpropid, IntPtr rgpropid);
        DeletePropertyNamesFunc m_DeletePropertyNamesFunc;

        public int Commit(uint grfCommitFlags)
        {
            if(m_CommitFunc==null){
                var fp = GetFunctionPointer(9);
                m_CommitFunc = (CommitFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CommitFunc));
            } 
            return  m_CommitFunc(m_ptr, grfCommitFlags);
        }
        delegate int CommitFunc(IntPtr self, uint grfCommitFlags);
        CommitFunc m_CommitFunc;

        public int Revert()
        {
            if(m_RevertFunc==null){
                var fp = GetFunctionPointer(10);
                m_RevertFunc = (RevertFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RevertFunc));
            } 
            return  m_RevertFunc(m_ptr);
        }
        delegate int RevertFunc(IntPtr self);
        RevertFunc m_RevertFunc;

        public int Enum(ref IntPtr ppenum)
        {
            if(m_EnumFunc==null){
                var fp = GetFunctionPointer(11);
                m_EnumFunc = (EnumFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(EnumFunc));
            } 
            return  m_EnumFunc(m_ptr, ref ppenum);
        }
        delegate int EnumFunc(IntPtr self, ref IntPtr ppenum);
        EnumFunc m_EnumFunc;

        public int SetTimes(ref FILETIME pctime, ref FILETIME patime, ref FILETIME pmtime)
        {
            if(m_SetTimesFunc==null){
                var fp = GetFunctionPointer(12);
                m_SetTimesFunc = (SetTimesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetTimesFunc));
            } 
            return  m_SetTimesFunc(m_ptr, ref pctime, ref patime, ref pmtime);
        }
        delegate int SetTimesFunc(IntPtr self, ref FILETIME pctime, ref FILETIME patime, ref FILETIME pmtime);
        SetTimesFunc m_SetTimesFunc;

        public int SetClass(ref Guid clsid)
        {
            if(m_SetClassFunc==null){
                var fp = GetFunctionPointer(13);
                m_SetClassFunc = (SetClassFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetClassFunc));
            } 
            return  m_SetClassFunc(m_ptr, ref clsid);
        }
        delegate int SetClassFunc(IntPtr self, ref Guid clsid);
        SetClassFunc m_SetClassFunc;

        public int Stat(ref STATPROPSETSTG pstatpsstg)
        {
            if(m_StatFunc==null){
                var fp = GetFunctionPointer(14);
                m_StatFunc = (StatFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(StatFunc));
            } 
            return  m_StatFunc(m_ptr, ref pstatpsstg);
        }
        delegate int StatFunc(IntPtr self, ref STATPROPSETSTG pstatpsstg);
        StatFunc m_StatFunc;

    }
}
