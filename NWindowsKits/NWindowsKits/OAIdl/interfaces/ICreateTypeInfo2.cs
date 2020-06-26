// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/OAIdl.h:1344
    public class ICreateTypeInfo2 : ICreateTypeInfo
    {
        static Guid s_uuid = new Guid("0002040e-0000-0000-c000-000000000046");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int DeleteFuncDesc(uint index)
        {
            if(m_DeleteFuncDescFunc==null){
                var fp = GetFunctionPointer(26);
                m_DeleteFuncDescFunc = (DeleteFuncDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DeleteFuncDescFunc));
            } 
            return  m_DeleteFuncDescFunc(m_ptr, index);
        }
        delegate int DeleteFuncDescFunc(IntPtr self, uint index);
        DeleteFuncDescFunc m_DeleteFuncDescFunc;

        public int DeleteFuncDescByMemId(int memid, INVOKEKIND invKind)
        {
            if(m_DeleteFuncDescByMemIdFunc==null){
                var fp = GetFunctionPointer(27);
                m_DeleteFuncDescByMemIdFunc = (DeleteFuncDescByMemIdFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DeleteFuncDescByMemIdFunc));
            } 
            return  m_DeleteFuncDescByMemIdFunc(m_ptr, memid, invKind);
        }
        delegate int DeleteFuncDescByMemIdFunc(IntPtr self, int memid, INVOKEKIND invKind);
        DeleteFuncDescByMemIdFunc m_DeleteFuncDescByMemIdFunc;

        public int DeleteVarDesc(uint index)
        {
            if(m_DeleteVarDescFunc==null){
                var fp = GetFunctionPointer(28);
                m_DeleteVarDescFunc = (DeleteVarDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DeleteVarDescFunc));
            } 
            return  m_DeleteVarDescFunc(m_ptr, index);
        }
        delegate int DeleteVarDescFunc(IntPtr self, uint index);
        DeleteVarDescFunc m_DeleteVarDescFunc;

        public int DeleteVarDescByMemId(int memid)
        {
            if(m_DeleteVarDescByMemIdFunc==null){
                var fp = GetFunctionPointer(29);
                m_DeleteVarDescByMemIdFunc = (DeleteVarDescByMemIdFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DeleteVarDescByMemIdFunc));
            } 
            return  m_DeleteVarDescByMemIdFunc(m_ptr, memid);
        }
        delegate int DeleteVarDescByMemIdFunc(IntPtr self, int memid);
        DeleteVarDescByMemIdFunc m_DeleteVarDescByMemIdFunc;

        public int DeleteImplType(uint index)
        {
            if(m_DeleteImplTypeFunc==null){
                var fp = GetFunctionPointer(30);
                m_DeleteImplTypeFunc = (DeleteImplTypeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DeleteImplTypeFunc));
            } 
            return  m_DeleteImplTypeFunc(m_ptr, index);
        }
        delegate int DeleteImplTypeFunc(IntPtr self, uint index);
        DeleteImplTypeFunc m_DeleteImplTypeFunc;

        public int SetCustData(ref GUID guid, ref VARIANT pVarVal)
        {
            if(m_SetCustDataFunc==null){
                var fp = GetFunctionPointer(31);
                m_SetCustDataFunc = (SetCustDataFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetCustDataFunc));
            } 
            return  m_SetCustDataFunc(m_ptr, ref guid, ref pVarVal);
        }
        delegate int SetCustDataFunc(IntPtr self, ref GUID guid, ref VARIANT pVarVal);
        SetCustDataFunc m_SetCustDataFunc;

        public int SetFuncCustData(uint index, ref GUID guid, ref VARIANT pVarVal)
        {
            if(m_SetFuncCustDataFunc==null){
                var fp = GetFunctionPointer(32);
                m_SetFuncCustDataFunc = (SetFuncCustDataFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetFuncCustDataFunc));
            } 
            return  m_SetFuncCustDataFunc(m_ptr, index, ref guid, ref pVarVal);
        }
        delegate int SetFuncCustDataFunc(IntPtr self, uint index, ref GUID guid, ref VARIANT pVarVal);
        SetFuncCustDataFunc m_SetFuncCustDataFunc;

        public int SetParamCustData(uint indexFunc, uint indexParam, ref GUID guid, ref VARIANT pVarVal)
        {
            if(m_SetParamCustDataFunc==null){
                var fp = GetFunctionPointer(33);
                m_SetParamCustDataFunc = (SetParamCustDataFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetParamCustDataFunc));
            } 
            return  m_SetParamCustDataFunc(m_ptr, indexFunc, indexParam, ref guid, ref pVarVal);
        }
        delegate int SetParamCustDataFunc(IntPtr self, uint indexFunc, uint indexParam, ref GUID guid, ref VARIANT pVarVal);
        SetParamCustDataFunc m_SetParamCustDataFunc;

        public int SetVarCustData(uint index, ref GUID guid, ref VARIANT pVarVal)
        {
            if(m_SetVarCustDataFunc==null){
                var fp = GetFunctionPointer(34);
                m_SetVarCustDataFunc = (SetVarCustDataFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetVarCustDataFunc));
            } 
            return  m_SetVarCustDataFunc(m_ptr, index, ref guid, ref pVarVal);
        }
        delegate int SetVarCustDataFunc(IntPtr self, uint index, ref GUID guid, ref VARIANT pVarVal);
        SetVarCustDataFunc m_SetVarCustDataFunc;

        public int SetImplTypeCustData(uint index, ref GUID guid, ref VARIANT pVarVal)
        {
            if(m_SetImplTypeCustDataFunc==null){
                var fp = GetFunctionPointer(35);
                m_SetImplTypeCustDataFunc = (SetImplTypeCustDataFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetImplTypeCustDataFunc));
            } 
            return  m_SetImplTypeCustDataFunc(m_ptr, index, ref guid, ref pVarVal);
        }
        delegate int SetImplTypeCustDataFunc(IntPtr self, uint index, ref GUID guid, ref VARIANT pVarVal);
        SetImplTypeCustDataFunc m_SetImplTypeCustDataFunc;

        public int SetHelpStringContext(uint dwHelpStringContext)
        {
            if(m_SetHelpStringContextFunc==null){
                var fp = GetFunctionPointer(36);
                m_SetHelpStringContextFunc = (SetHelpStringContextFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetHelpStringContextFunc));
            } 
            return  m_SetHelpStringContextFunc(m_ptr, dwHelpStringContext);
        }
        delegate int SetHelpStringContextFunc(IntPtr self, uint dwHelpStringContext);
        SetHelpStringContextFunc m_SetHelpStringContextFunc;

        public int SetFuncHelpStringContext(uint index, uint dwHelpStringContext)
        {
            if(m_SetFuncHelpStringContextFunc==null){
                var fp = GetFunctionPointer(37);
                m_SetFuncHelpStringContextFunc = (SetFuncHelpStringContextFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetFuncHelpStringContextFunc));
            } 
            return  m_SetFuncHelpStringContextFunc(m_ptr, index, dwHelpStringContext);
        }
        delegate int SetFuncHelpStringContextFunc(IntPtr self, uint index, uint dwHelpStringContext);
        SetFuncHelpStringContextFunc m_SetFuncHelpStringContextFunc;

        public int SetVarHelpStringContext(uint index, uint dwHelpStringContext)
        {
            if(m_SetVarHelpStringContextFunc==null){
                var fp = GetFunctionPointer(38);
                m_SetVarHelpStringContextFunc = (SetVarHelpStringContextFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetVarHelpStringContextFunc));
            } 
            return  m_SetVarHelpStringContextFunc(m_ptr, index, dwHelpStringContext);
        }
        delegate int SetVarHelpStringContextFunc(IntPtr self, uint index, uint dwHelpStringContext);
        SetVarHelpStringContextFunc m_SetVarHelpStringContextFunc;

        public int Invalidate()
        {
            if(m_InvalidateFunc==null){
                var fp = GetFunctionPointer(39);
                m_InvalidateFunc = (InvalidateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(InvalidateFunc));
            } 
            return  m_InvalidateFunc(m_ptr);
        }
        delegate int InvalidateFunc(IntPtr self);
        InvalidateFunc m_InvalidateFunc;

        public int SetName(IntPtr szName)
        {
            if(m_SetNameFunc==null){
                var fp = GetFunctionPointer(40);
                m_SetNameFunc = (SetNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetNameFunc));
            } 
            return  m_SetNameFunc(m_ptr, szName);
        }
        delegate int SetNameFunc(IntPtr self, IntPtr szName);
        SetNameFunc m_SetNameFunc;

    }
}
