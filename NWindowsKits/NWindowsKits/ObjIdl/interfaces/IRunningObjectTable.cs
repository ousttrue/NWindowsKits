// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/ObjIdl.h:8985
    public class IRunningObjectTable : IUnknown // 1
    {
        static Guid s_uuid = new Guid("00000010-0000-0000-c000-000000000046");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int Register(uint grfFlags, IntPtr punkObject, IntPtr pmkObjectName, ref uint pdwRegister)
        {
            if(m_RegisterFunc==null){
                var fp = GetFunctionPointer(3);
                m_RegisterFunc = (RegisterFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RegisterFunc));
            } 
            
            return  m_RegisterFunc(m_ptr, grfFlags, punkObject, pmkObjectName, ref pdwRegister);
        }
        delegate int RegisterFunc(IntPtr self, uint grfFlags, IntPtr punkObject, IntPtr pmkObjectName, ref uint pdwRegister);
        RegisterFunc m_RegisterFunc;

        public int Revoke(uint dwRegister)
        {
            if(m_RevokeFunc==null){
                var fp = GetFunctionPointer(4);
                m_RevokeFunc = (RevokeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RevokeFunc));
            } 
            
            return  m_RevokeFunc(m_ptr, dwRegister);
        }
        delegate int RevokeFunc(IntPtr self, uint dwRegister);
        RevokeFunc m_RevokeFunc;

        public int IsRunning(IntPtr pmkObjectName)
        {
            if(m_IsRunningFunc==null){
                var fp = GetFunctionPointer(5);
                m_IsRunningFunc = (IsRunningFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IsRunningFunc));
            } 
            
            return  m_IsRunningFunc(m_ptr, pmkObjectName);
        }
        delegate int IsRunningFunc(IntPtr self, IntPtr pmkObjectName);
        IsRunningFunc m_IsRunningFunc;

        public int GetObjectA(IntPtr pmkObjectName, ref IntPtr ppunkObject)
        {
            if(m_GetObjectAFunc==null){
                var fp = GetFunctionPointer(6);
                m_GetObjectAFunc = (GetObjectAFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetObjectAFunc));
            } 
            
            return  m_GetObjectAFunc(m_ptr, pmkObjectName, ref ppunkObject);
        }
        delegate int GetObjectAFunc(IntPtr self, IntPtr pmkObjectName, ref IntPtr ppunkObject);
        GetObjectAFunc m_GetObjectAFunc;

        public int NoteChangeTime(uint dwRegister, ref FILETIME pfiletime)
        {
            if(m_NoteChangeTimeFunc==null){
                var fp = GetFunctionPointer(7);
                m_NoteChangeTimeFunc = (NoteChangeTimeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(NoteChangeTimeFunc));
            } 
            
            return  m_NoteChangeTimeFunc(m_ptr, dwRegister, ref pfiletime);
        }
        delegate int NoteChangeTimeFunc(IntPtr self, uint dwRegister, ref FILETIME pfiletime);
        NoteChangeTimeFunc m_NoteChangeTimeFunc;

        public int GetTimeOfLastChange(IntPtr pmkObjectName, ref FILETIME pfiletime)
        {
            if(m_GetTimeOfLastChangeFunc==null){
                var fp = GetFunctionPointer(8);
                m_GetTimeOfLastChangeFunc = (GetTimeOfLastChangeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetTimeOfLastChangeFunc));
            } 
            
            return  m_GetTimeOfLastChangeFunc(m_ptr, pmkObjectName, ref pfiletime);
        }
        delegate int GetTimeOfLastChangeFunc(IntPtr self, IntPtr pmkObjectName, ref FILETIME pfiletime);
        GetTimeOfLastChangeFunc m_GetTimeOfLastChangeFunc;

        public int EnumRunning(ref IntPtr ppenumMoniker)
        {
            if(m_EnumRunningFunc==null){
                var fp = GetFunctionPointer(9);
                m_EnumRunningFunc = (EnumRunningFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(EnumRunningFunc));
            } 
            
            return  m_EnumRunningFunc(m_ptr, ref ppenumMoniker);
        }
        delegate int EnumRunningFunc(IntPtr self, ref IntPtr ppenumMoniker);
        EnumRunningFunc m_EnumRunningFunc;

    }
}