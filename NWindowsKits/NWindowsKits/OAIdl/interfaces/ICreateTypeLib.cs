// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/OAIdl.h:1778
    public class ICreateTypeLib : IUnknown
    {
        static Guid s_uuid = new Guid("00020406-0000-0000-c000-000000000046");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int CreateTypeInfo(IntPtr szName, TYPEKIND tkind, ref IntPtr ppCTInfo)
        {
            if(m_CreateTypeInfoFunc==null){
                var fp = GetFunctionPointer(3);
                m_CreateTypeInfoFunc = (CreateTypeInfoFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateTypeInfoFunc));
            } 
            return  m_CreateTypeInfoFunc(m_ptr, szName, tkind, ref ppCTInfo);
        }
        delegate int CreateTypeInfoFunc(IntPtr self, IntPtr szName, TYPEKIND tkind, ref IntPtr ppCTInfo);
        CreateTypeInfoFunc m_CreateTypeInfoFunc;

        public int SetName(IntPtr szName)
        {
            if(m_SetNameFunc==null){
                var fp = GetFunctionPointer(4);
                m_SetNameFunc = (SetNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetNameFunc));
            } 
            return  m_SetNameFunc(m_ptr, szName);
        }
        delegate int SetNameFunc(IntPtr self, IntPtr szName);
        SetNameFunc m_SetNameFunc;

        public int SetVersion(ushort wMajorVerNum, ushort wMinorVerNum)
        {
            if(m_SetVersionFunc==null){
                var fp = GetFunctionPointer(5);
                m_SetVersionFunc = (SetVersionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetVersionFunc));
            } 
            return  m_SetVersionFunc(m_ptr, wMajorVerNum, wMinorVerNum);
        }
        delegate int SetVersionFunc(IntPtr self, ushort wMajorVerNum, ushort wMinorVerNum);
        SetVersionFunc m_SetVersionFunc;

        public int SetGuid(ref GUID guid)
        {
            if(m_SetGuidFunc==null){
                var fp = GetFunctionPointer(6);
                m_SetGuidFunc = (SetGuidFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetGuidFunc));
            } 
            return  m_SetGuidFunc(m_ptr, ref guid);
        }
        delegate int SetGuidFunc(IntPtr self, ref GUID guid);
        SetGuidFunc m_SetGuidFunc;

        public int SetDocString(IntPtr szDoc)
        {
            if(m_SetDocStringFunc==null){
                var fp = GetFunctionPointer(7);
                m_SetDocStringFunc = (SetDocStringFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetDocStringFunc));
            } 
            return  m_SetDocStringFunc(m_ptr, szDoc);
        }
        delegate int SetDocStringFunc(IntPtr self, IntPtr szDoc);
        SetDocStringFunc m_SetDocStringFunc;

        public int SetHelpFileName(IntPtr szHelpFileName)
        {
            if(m_SetHelpFileNameFunc==null){
                var fp = GetFunctionPointer(8);
                m_SetHelpFileNameFunc = (SetHelpFileNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetHelpFileNameFunc));
            } 
            return  m_SetHelpFileNameFunc(m_ptr, szHelpFileName);
        }
        delegate int SetHelpFileNameFunc(IntPtr self, IntPtr szHelpFileName);
        SetHelpFileNameFunc m_SetHelpFileNameFunc;

        public int SetHelpContext(uint dwHelpContext)
        {
            if(m_SetHelpContextFunc==null){
                var fp = GetFunctionPointer(9);
                m_SetHelpContextFunc = (SetHelpContextFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetHelpContextFunc));
            } 
            return  m_SetHelpContextFunc(m_ptr, dwHelpContext);
        }
        delegate int SetHelpContextFunc(IntPtr self, uint dwHelpContext);
        SetHelpContextFunc m_SetHelpContextFunc;

        public int SetLcid(uint lcid)
        {
            if(m_SetLcidFunc==null){
                var fp = GetFunctionPointer(10);
                m_SetLcidFunc = (SetLcidFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetLcidFunc));
            } 
            return  m_SetLcidFunc(m_ptr, lcid);
        }
        delegate int SetLcidFunc(IntPtr self, uint lcid);
        SetLcidFunc m_SetLcidFunc;

        public int SetLibFlags(uint uLibFlags)
        {
            if(m_SetLibFlagsFunc==null){
                var fp = GetFunctionPointer(11);
                m_SetLibFlagsFunc = (SetLibFlagsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetLibFlagsFunc));
            } 
            return  m_SetLibFlagsFunc(m_ptr, uLibFlags);
        }
        delegate int SetLibFlagsFunc(IntPtr self, uint uLibFlags);
        SetLibFlagsFunc m_SetLibFlagsFunc;

        public int SaveAllChanges()
        {
            if(m_SaveAllChangesFunc==null){
                var fp = GetFunctionPointer(12);
                m_SaveAllChangesFunc = (SaveAllChangesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SaveAllChangesFunc));
            } 
            return  m_SaveAllChangesFunc(m_ptr);
        }
        delegate int SaveAllChangesFunc(IntPtr self);
        SaveAllChangesFunc m_SaveAllChangesFunc;

    }
}
