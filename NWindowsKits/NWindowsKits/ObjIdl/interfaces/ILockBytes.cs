// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/ObjIdl.h:10629
    public class ILockBytes : IUnknown
    {
        static Guid s_uuid = new Guid("0000000a-0000-0000-c000-000000000046");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int ReadAt(ULARGE_INTEGER ulOffset, IntPtr pv, uint cb, IntPtr pcbRead)
        {
            if(m_ReadAtFunc==null){
                var fp = GetFunctionPointer(3);
                m_ReadAtFunc = (ReadAtFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReadAtFunc));
            } 
            return  m_ReadAtFunc(m_ptr, ulOffset, pv, cb, pcbRead);
        }
        delegate int ReadAtFunc(IntPtr self, ULARGE_INTEGER ulOffset, IntPtr pv, uint cb, IntPtr pcbRead);
        ReadAtFunc m_ReadAtFunc;

        public int WriteAt(ULARGE_INTEGER ulOffset, IntPtr pv, uint cb, IntPtr pcbWritten)
        {
            if(m_WriteAtFunc==null){
                var fp = GetFunctionPointer(4);
                m_WriteAtFunc = (WriteAtFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(WriteAtFunc));
            } 
            return  m_WriteAtFunc(m_ptr, ulOffset, pv, cb, pcbWritten);
        }
        delegate int WriteAtFunc(IntPtr self, ULARGE_INTEGER ulOffset, IntPtr pv, uint cb, IntPtr pcbWritten);
        WriteAtFunc m_WriteAtFunc;

        public int Flush()
        {
            if(m_FlushFunc==null){
                var fp = GetFunctionPointer(5);
                m_FlushFunc = (FlushFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(FlushFunc));
            } 
            return  m_FlushFunc(m_ptr);
        }
        delegate int FlushFunc(IntPtr self);
        FlushFunc m_FlushFunc;

        public int SetSize(ULARGE_INTEGER cb)
        {
            if(m_SetSizeFunc==null){
                var fp = GetFunctionPointer(6);
                m_SetSizeFunc = (SetSizeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetSizeFunc));
            } 
            return  m_SetSizeFunc(m_ptr, cb);
        }
        delegate int SetSizeFunc(IntPtr self, ULARGE_INTEGER cb);
        SetSizeFunc m_SetSizeFunc;

        public int LockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, uint dwLockType)
        {
            if(m_LockRegionFunc==null){
                var fp = GetFunctionPointer(7);
                m_LockRegionFunc = (LockRegionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(LockRegionFunc));
            } 
            return  m_LockRegionFunc(m_ptr, libOffset, cb, dwLockType);
        }
        delegate int LockRegionFunc(IntPtr self, ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, uint dwLockType);
        LockRegionFunc m_LockRegionFunc;

        public int UnlockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, uint dwLockType)
        {
            if(m_UnlockRegionFunc==null){
                var fp = GetFunctionPointer(8);
                m_UnlockRegionFunc = (UnlockRegionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(UnlockRegionFunc));
            } 
            return  m_UnlockRegionFunc(m_ptr, libOffset, cb, dwLockType);
        }
        delegate int UnlockRegionFunc(IntPtr self, ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, uint dwLockType);
        UnlockRegionFunc m_UnlockRegionFunc;

        public int Stat(ref STATSTG pstatstg, uint grfStatFlag)
        {
            if(m_StatFunc==null){
                var fp = GetFunctionPointer(9);
                m_StatFunc = (StatFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(StatFunc));
            } 
            return  m_StatFunc(m_ptr, ref pstatstg, grfStatFlag);
        }
        delegate int StatFunc(IntPtr self, ref STATSTG pstatstg, uint grfStatFlag);
        StatFunc m_StatFunc;

    }
}
