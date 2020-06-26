// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/OAIdl.h:994
    public class ICreateTypeInfo : IUnknown
    {
        static Guid s_uuid = new Guid("00020405-0000-0000-c000-000000000046");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int SetGuid(ref GUID guid)
        {
            if(m_SetGuidFunc==null){
                var fp = GetFunctionPointer(3);
                m_SetGuidFunc = (SetGuidFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetGuidFunc));
            } 
            return  m_SetGuidFunc(m_ptr, ref guid);
        }
        delegate int SetGuidFunc(IntPtr self, ref GUID guid);
        SetGuidFunc m_SetGuidFunc;

        public int SetTypeFlags(uint uTypeFlags)
        {
            if(m_SetTypeFlagsFunc==null){
                var fp = GetFunctionPointer(4);
                m_SetTypeFlagsFunc = (SetTypeFlagsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetTypeFlagsFunc));
            } 
            return  m_SetTypeFlagsFunc(m_ptr, uTypeFlags);
        }
        delegate int SetTypeFlagsFunc(IntPtr self, uint uTypeFlags);
        SetTypeFlagsFunc m_SetTypeFlagsFunc;

        public int SetDocString(IntPtr pStrDoc)
        {
            if(m_SetDocStringFunc==null){
                var fp = GetFunctionPointer(5);
                m_SetDocStringFunc = (SetDocStringFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetDocStringFunc));
            } 
            return  m_SetDocStringFunc(m_ptr, pStrDoc);
        }
        delegate int SetDocStringFunc(IntPtr self, IntPtr pStrDoc);
        SetDocStringFunc m_SetDocStringFunc;

        public int SetHelpContext(uint dwHelpContext)
        {
            if(m_SetHelpContextFunc==null){
                var fp = GetFunctionPointer(6);
                m_SetHelpContextFunc = (SetHelpContextFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetHelpContextFunc));
            } 
            return  m_SetHelpContextFunc(m_ptr, dwHelpContext);
        }
        delegate int SetHelpContextFunc(IntPtr self, uint dwHelpContext);
        SetHelpContextFunc m_SetHelpContextFunc;

        public int SetVersion(ushort wMajorVerNum, ushort wMinorVerNum)
        {
            if(m_SetVersionFunc==null){
                var fp = GetFunctionPointer(7);
                m_SetVersionFunc = (SetVersionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetVersionFunc));
            } 
            return  m_SetVersionFunc(m_ptr, wMajorVerNum, wMinorVerNum);
        }
        delegate int SetVersionFunc(IntPtr self, ushort wMajorVerNum, ushort wMinorVerNum);
        SetVersionFunc m_SetVersionFunc;

        public int AddRefTypeInfo(IntPtr pTInfo, IntPtr phRefType)
        {
            if(m_AddRefTypeInfoFunc==null){
                var fp = GetFunctionPointer(8);
                m_AddRefTypeInfoFunc = (AddRefTypeInfoFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AddRefTypeInfoFunc));
            } 
            return  m_AddRefTypeInfoFunc(m_ptr, pTInfo, phRefType);
        }
        delegate int AddRefTypeInfoFunc(IntPtr self, IntPtr pTInfo, IntPtr phRefType);
        AddRefTypeInfoFunc m_AddRefTypeInfoFunc;

        public int AddFuncDesc(uint index, ref FUNCDESC pFuncDesc)
        {
            if(m_AddFuncDescFunc==null){
                var fp = GetFunctionPointer(9);
                m_AddFuncDescFunc = (AddFuncDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AddFuncDescFunc));
            } 
            return  m_AddFuncDescFunc(m_ptr, index, ref pFuncDesc);
        }
        delegate int AddFuncDescFunc(IntPtr self, uint index, ref FUNCDESC pFuncDesc);
        AddFuncDescFunc m_AddFuncDescFunc;

        public int AddImplType(uint index, uint hRefType)
        {
            if(m_AddImplTypeFunc==null){
                var fp = GetFunctionPointer(10);
                m_AddImplTypeFunc = (AddImplTypeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AddImplTypeFunc));
            } 
            return  m_AddImplTypeFunc(m_ptr, index, hRefType);
        }
        delegate int AddImplTypeFunc(IntPtr self, uint index, uint hRefType);
        AddImplTypeFunc m_AddImplTypeFunc;

        public int SetImplTypeFlags(uint index, int implTypeFlags)
        {
            if(m_SetImplTypeFlagsFunc==null){
                var fp = GetFunctionPointer(11);
                m_SetImplTypeFlagsFunc = (SetImplTypeFlagsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetImplTypeFlagsFunc));
            } 
            return  m_SetImplTypeFlagsFunc(m_ptr, index, implTypeFlags);
        }
        delegate int SetImplTypeFlagsFunc(IntPtr self, uint index, int implTypeFlags);
        SetImplTypeFlagsFunc m_SetImplTypeFlagsFunc;

        public int SetAlignment(ushort cbAlignment)
        {
            if(m_SetAlignmentFunc==null){
                var fp = GetFunctionPointer(12);
                m_SetAlignmentFunc = (SetAlignmentFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetAlignmentFunc));
            } 
            return  m_SetAlignmentFunc(m_ptr, cbAlignment);
        }
        delegate int SetAlignmentFunc(IntPtr self, ushort cbAlignment);
        SetAlignmentFunc m_SetAlignmentFunc;

        public int SetSchema(IntPtr pStrSchema)
        {
            if(m_SetSchemaFunc==null){
                var fp = GetFunctionPointer(13);
                m_SetSchemaFunc = (SetSchemaFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetSchemaFunc));
            } 
            return  m_SetSchemaFunc(m_ptr, pStrSchema);
        }
        delegate int SetSchemaFunc(IntPtr self, IntPtr pStrSchema);
        SetSchemaFunc m_SetSchemaFunc;

        public int AddVarDesc(uint index, ref VARDESC pVarDesc)
        {
            if(m_AddVarDescFunc==null){
                var fp = GetFunctionPointer(14);
                m_AddVarDescFunc = (AddVarDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AddVarDescFunc));
            } 
            return  m_AddVarDescFunc(m_ptr, index, ref pVarDesc);
        }
        delegate int AddVarDescFunc(IntPtr self, uint index, ref VARDESC pVarDesc);
        AddVarDescFunc m_AddVarDescFunc;

        public int SetFuncAndParamNames(uint index, ref IntPtr rgszNames, uint cNames)
        {
            if(m_SetFuncAndParamNamesFunc==null){
                var fp = GetFunctionPointer(15);
                m_SetFuncAndParamNamesFunc = (SetFuncAndParamNamesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetFuncAndParamNamesFunc));
            } 
            return  m_SetFuncAndParamNamesFunc(m_ptr, index, ref rgszNames, cNames);
        }
        delegate int SetFuncAndParamNamesFunc(IntPtr self, uint index, ref IntPtr rgszNames, uint cNames);
        SetFuncAndParamNamesFunc m_SetFuncAndParamNamesFunc;

        public int SetVarName(uint index, IntPtr szName)
        {
            if(m_SetVarNameFunc==null){
                var fp = GetFunctionPointer(16);
                m_SetVarNameFunc = (SetVarNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetVarNameFunc));
            } 
            return  m_SetVarNameFunc(m_ptr, index, szName);
        }
        delegate int SetVarNameFunc(IntPtr self, uint index, IntPtr szName);
        SetVarNameFunc m_SetVarNameFunc;

        public int SetTypeDescAlias(ref TYPEDESC pTDescAlias)
        {
            if(m_SetTypeDescAliasFunc==null){
                var fp = GetFunctionPointer(17);
                m_SetTypeDescAliasFunc = (SetTypeDescAliasFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetTypeDescAliasFunc));
            } 
            return  m_SetTypeDescAliasFunc(m_ptr, ref pTDescAlias);
        }
        delegate int SetTypeDescAliasFunc(IntPtr self, ref TYPEDESC pTDescAlias);
        SetTypeDescAliasFunc m_SetTypeDescAliasFunc;

        public int DefineFuncAsDllEntry(uint index, IntPtr szDllName, IntPtr szProcName)
        {
            if(m_DefineFuncAsDllEntryFunc==null){
                var fp = GetFunctionPointer(18);
                m_DefineFuncAsDllEntryFunc = (DefineFuncAsDllEntryFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DefineFuncAsDllEntryFunc));
            } 
            return  m_DefineFuncAsDllEntryFunc(m_ptr, index, szDllName, szProcName);
        }
        delegate int DefineFuncAsDllEntryFunc(IntPtr self, uint index, IntPtr szDllName, IntPtr szProcName);
        DefineFuncAsDllEntryFunc m_DefineFuncAsDllEntryFunc;

        public int SetFuncDocString(uint index, IntPtr szDocString)
        {
            if(m_SetFuncDocStringFunc==null){
                var fp = GetFunctionPointer(19);
                m_SetFuncDocStringFunc = (SetFuncDocStringFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetFuncDocStringFunc));
            } 
            return  m_SetFuncDocStringFunc(m_ptr, index, szDocString);
        }
        delegate int SetFuncDocStringFunc(IntPtr self, uint index, IntPtr szDocString);
        SetFuncDocStringFunc m_SetFuncDocStringFunc;

        public int SetVarDocString(uint index, IntPtr szDocString)
        {
            if(m_SetVarDocStringFunc==null){
                var fp = GetFunctionPointer(20);
                m_SetVarDocStringFunc = (SetVarDocStringFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetVarDocStringFunc));
            } 
            return  m_SetVarDocStringFunc(m_ptr, index, szDocString);
        }
        delegate int SetVarDocStringFunc(IntPtr self, uint index, IntPtr szDocString);
        SetVarDocStringFunc m_SetVarDocStringFunc;

        public int SetFuncHelpContext(uint index, uint dwHelpContext)
        {
            if(m_SetFuncHelpContextFunc==null){
                var fp = GetFunctionPointer(21);
                m_SetFuncHelpContextFunc = (SetFuncHelpContextFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetFuncHelpContextFunc));
            } 
            return  m_SetFuncHelpContextFunc(m_ptr, index, dwHelpContext);
        }
        delegate int SetFuncHelpContextFunc(IntPtr self, uint index, uint dwHelpContext);
        SetFuncHelpContextFunc m_SetFuncHelpContextFunc;

        public int SetVarHelpContext(uint index, uint dwHelpContext)
        {
            if(m_SetVarHelpContextFunc==null){
                var fp = GetFunctionPointer(22);
                m_SetVarHelpContextFunc = (SetVarHelpContextFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetVarHelpContextFunc));
            } 
            return  m_SetVarHelpContextFunc(m_ptr, index, dwHelpContext);
        }
        delegate int SetVarHelpContextFunc(IntPtr self, uint index, uint dwHelpContext);
        SetVarHelpContextFunc m_SetVarHelpContextFunc;

        public int SetMops(uint index, IntPtr bstrMops)
        {
            if(m_SetMopsFunc==null){
                var fp = GetFunctionPointer(23);
                m_SetMopsFunc = (SetMopsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetMopsFunc));
            } 
            return  m_SetMopsFunc(m_ptr, index, bstrMops);
        }
        delegate int SetMopsFunc(IntPtr self, uint index, IntPtr bstrMops);
        SetMopsFunc m_SetMopsFunc;

        public int SetTypeIdldesc(ref IDLDESC pIdlDesc)
        {
            if(m_SetTypeIdldescFunc==null){
                var fp = GetFunctionPointer(24);
                m_SetTypeIdldescFunc = (SetTypeIdldescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetTypeIdldescFunc));
            } 
            return  m_SetTypeIdldescFunc(m_ptr, ref pIdlDesc);
        }
        delegate int SetTypeIdldescFunc(IntPtr self, ref IDLDESC pIdlDesc);
        SetTypeIdldescFunc m_SetTypeIdldescFunc;

        public int LayOut()
        {
            if(m_LayOutFunc==null){
                var fp = GetFunctionPointer(25);
                m_LayOutFunc = (LayOutFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(LayOutFunc));
            } 
            return  m_LayOutFunc(m_ptr);
        }
        delegate int LayOutFunc(IntPtr self);
        LayOutFunc m_LayOutFunc;

    }
}
