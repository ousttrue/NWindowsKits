// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/OAIdl.h:4923
    public class IRecordInfo : IUnknown
    {
        static Guid s_uuid = new Guid("0000002f-0000-0000-c000-000000000046");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int RecordInit(IntPtr pvNew)
        {
            if(m_RecordInitFunc==null){
                var fp = GetFunctionPointer(3);
                m_RecordInitFunc = (RecordInitFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RecordInitFunc));
            } 
            return  m_RecordInitFunc(m_ptr, pvNew);
        }
        delegate int RecordInitFunc(IntPtr self, IntPtr pvNew);
        RecordInitFunc m_RecordInitFunc;

        public int RecordClear(IntPtr pvExisting)
        {
            if(m_RecordClearFunc==null){
                var fp = GetFunctionPointer(4);
                m_RecordClearFunc = (RecordClearFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RecordClearFunc));
            } 
            return  m_RecordClearFunc(m_ptr, pvExisting);
        }
        delegate int RecordClearFunc(IntPtr self, IntPtr pvExisting);
        RecordClearFunc m_RecordClearFunc;

        public int RecordCopy(IntPtr pvExisting, IntPtr pvNew)
        {
            if(m_RecordCopyFunc==null){
                var fp = GetFunctionPointer(5);
                m_RecordCopyFunc = (RecordCopyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RecordCopyFunc));
            } 
            return  m_RecordCopyFunc(m_ptr, pvExisting, pvNew);
        }
        delegate int RecordCopyFunc(IntPtr self, IntPtr pvExisting, IntPtr pvNew);
        RecordCopyFunc m_RecordCopyFunc;

        public int GetGuid(ref GUID pguid)
        {
            if(m_GetGuidFunc==null){
                var fp = GetFunctionPointer(6);
                m_GetGuidFunc = (GetGuidFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetGuidFunc));
            } 
            return  m_GetGuidFunc(m_ptr, ref pguid);
        }
        delegate int GetGuidFunc(IntPtr self, ref GUID pguid);
        GetGuidFunc m_GetGuidFunc;

        public int GetName(ref IntPtr pbstrName)
        {
            if(m_GetNameFunc==null){
                var fp = GetFunctionPointer(7);
                m_GetNameFunc = (GetNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetNameFunc));
            } 
            return  m_GetNameFunc(m_ptr, ref pbstrName);
        }
        delegate int GetNameFunc(IntPtr self, ref IntPtr pbstrName);
        GetNameFunc m_GetNameFunc;

        public int GetSize(IntPtr pcbSize)
        {
            if(m_GetSizeFunc==null){
                var fp = GetFunctionPointer(8);
                m_GetSizeFunc = (GetSizeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetSizeFunc));
            } 
            return  m_GetSizeFunc(m_ptr, pcbSize);
        }
        delegate int GetSizeFunc(IntPtr self, IntPtr pcbSize);
        GetSizeFunc m_GetSizeFunc;

        public int GetTypeInfo(ref IntPtr ppTypeInfo)
        {
            if(m_GetTypeInfoFunc==null){
                var fp = GetFunctionPointer(9);
                m_GetTypeInfoFunc = (GetTypeInfoFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetTypeInfoFunc));
            } 
            return  m_GetTypeInfoFunc(m_ptr, ref ppTypeInfo);
        }
        delegate int GetTypeInfoFunc(IntPtr self, ref IntPtr ppTypeInfo);
        GetTypeInfoFunc m_GetTypeInfoFunc;

        public int GetField(IntPtr pvData, IntPtr szFieldName, ref VARIANT pvarField)
        {
            if(m_GetFieldFunc==null){
                var fp = GetFunctionPointer(10);
                m_GetFieldFunc = (GetFieldFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFieldFunc));
            } 
            return  m_GetFieldFunc(m_ptr, pvData, szFieldName, ref pvarField);
        }
        delegate int GetFieldFunc(IntPtr self, IntPtr pvData, IntPtr szFieldName, ref VARIANT pvarField);
        GetFieldFunc m_GetFieldFunc;

        public int GetFieldNoCopy(IntPtr pvData, IntPtr szFieldName, ref VARIANT pvarField, ref IntPtr ppvDataCArray)
        {
            if(m_GetFieldNoCopyFunc==null){
                var fp = GetFunctionPointer(11);
                m_GetFieldNoCopyFunc = (GetFieldNoCopyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFieldNoCopyFunc));
            } 
            return  m_GetFieldNoCopyFunc(m_ptr, pvData, szFieldName, ref pvarField, ref ppvDataCArray);
        }
        delegate int GetFieldNoCopyFunc(IntPtr self, IntPtr pvData, IntPtr szFieldName, ref VARIANT pvarField, ref IntPtr ppvDataCArray);
        GetFieldNoCopyFunc m_GetFieldNoCopyFunc;

        public int PutField(uint wFlags, IntPtr pvData, IntPtr szFieldName, ref VARIANT pvarField)
        {
            if(m_PutFieldFunc==null){
                var fp = GetFunctionPointer(12);
                m_PutFieldFunc = (PutFieldFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(PutFieldFunc));
            } 
            return  m_PutFieldFunc(m_ptr, wFlags, pvData, szFieldName, ref pvarField);
        }
        delegate int PutFieldFunc(IntPtr self, uint wFlags, IntPtr pvData, IntPtr szFieldName, ref VARIANT pvarField);
        PutFieldFunc m_PutFieldFunc;

        public int PutFieldNoCopy(uint wFlags, IntPtr pvData, IntPtr szFieldName, ref VARIANT pvarField)
        {
            if(m_PutFieldNoCopyFunc==null){
                var fp = GetFunctionPointer(13);
                m_PutFieldNoCopyFunc = (PutFieldNoCopyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(PutFieldNoCopyFunc));
            } 
            return  m_PutFieldNoCopyFunc(m_ptr, wFlags, pvData, szFieldName, ref pvarField);
        }
        delegate int PutFieldNoCopyFunc(IntPtr self, uint wFlags, IntPtr pvData, IntPtr szFieldName, ref VARIANT pvarField);
        PutFieldNoCopyFunc m_PutFieldNoCopyFunc;

        public int GetFieldNames(IntPtr pcNames, ref IntPtr rgBstrNames)
        {
            if(m_GetFieldNamesFunc==null){
                var fp = GetFunctionPointer(14);
                m_GetFieldNamesFunc = (GetFieldNamesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFieldNamesFunc));
            } 
            return  m_GetFieldNamesFunc(m_ptr, pcNames, ref rgBstrNames);
        }
        delegate int GetFieldNamesFunc(IntPtr self, IntPtr pcNames, ref IntPtr rgBstrNames);
        GetFieldNamesFunc m_GetFieldNamesFunc;

        public int IsMatchingType(IntPtr pRecordInfo)
        {
            if(m_IsMatchingTypeFunc==null){
                var fp = GetFunctionPointer(15);
                m_IsMatchingTypeFunc = (IsMatchingTypeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IsMatchingTypeFunc));
            } 
            return  m_IsMatchingTypeFunc(m_ptr, pRecordInfo);
        }
        delegate int IsMatchingTypeFunc(IntPtr self, IntPtr pRecordInfo);
        IsMatchingTypeFunc m_IsMatchingTypeFunc;

        public IntPtr RecordCreate()
        {
            if(m_RecordCreateFunc==null){
                var fp = GetFunctionPointer(16);
                m_RecordCreateFunc = (RecordCreateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RecordCreateFunc));
            } 
            return  m_RecordCreateFunc(m_ptr);
        }
        delegate IntPtr RecordCreateFunc(IntPtr self);
        RecordCreateFunc m_RecordCreateFunc;

        public int RecordCreateCopy(IntPtr pvSource, ref IntPtr ppvDest)
        {
            if(m_RecordCreateCopyFunc==null){
                var fp = GetFunctionPointer(17);
                m_RecordCreateCopyFunc = (RecordCreateCopyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RecordCreateCopyFunc));
            } 
            return  m_RecordCreateCopyFunc(m_ptr, pvSource, ref ppvDest);
        }
        delegate int RecordCreateCopyFunc(IntPtr self, IntPtr pvSource, ref IntPtr ppvDest);
        RecordCreateCopyFunc m_RecordCreateCopyFunc;

        public int RecordDestroy(IntPtr pvRecord)
        {
            if(m_RecordDestroyFunc==null){
                var fp = GetFunctionPointer(18);
                m_RecordDestroyFunc = (RecordDestroyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RecordDestroyFunc));
            } 
            return  m_RecordDestroyFunc(m_ptr, pvRecord);
        }
        delegate int RecordDestroyFunc(IntPtr self, IntPtr pvRecord);
        RecordDestroyFunc m_RecordDestroyFunc;

    }
}
