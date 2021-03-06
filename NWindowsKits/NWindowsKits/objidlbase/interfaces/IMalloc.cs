// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/objidlbase.h:1147
    public class IMalloc : IUnknown
    {
        static Guid s_uuid = new Guid("00000002-0000-0000-c000-000000000046");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public IntPtr Alloc(ulong cb)
        {
            if(m_AllocFunc==null){
                var fp = GetFunctionPointer(3);
                m_AllocFunc = (AllocFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AllocFunc));
            } 
            return  m_AllocFunc(m_ptr, cb);
        }
        delegate IntPtr AllocFunc(IntPtr self, ulong cb);
        AllocFunc m_AllocFunc;

        public IntPtr Realloc(IntPtr pv, ulong cb)
        {
            if(m_ReallocFunc==null){
                var fp = GetFunctionPointer(4);
                m_ReallocFunc = (ReallocFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReallocFunc));
            } 
            return  m_ReallocFunc(m_ptr, pv, cb);
        }
        delegate IntPtr ReallocFunc(IntPtr self, IntPtr pv, ulong cb);
        ReallocFunc m_ReallocFunc;

        public void Free(IntPtr pv)
        {
            if(m_FreeFunc==null){
                var fp = GetFunctionPointer(5);
                m_FreeFunc = (FreeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(FreeFunc));
            } 
             m_FreeFunc(m_ptr, pv);
        }
        delegate void FreeFunc(IntPtr self, IntPtr pv);
        FreeFunc m_FreeFunc;

        public ulong GetSize(IntPtr pv)
        {
            if(m_GetSizeFunc==null){
                var fp = GetFunctionPointer(6);
                m_GetSizeFunc = (GetSizeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetSizeFunc));
            } 
            return  m_GetSizeFunc(m_ptr, pv);
        }
        delegate ulong GetSizeFunc(IntPtr self, IntPtr pv);
        GetSizeFunc m_GetSizeFunc;

        public int DidAlloc(IntPtr pv)
        {
            if(m_DidAllocFunc==null){
                var fp = GetFunctionPointer(7);
                m_DidAllocFunc = (DidAllocFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DidAllocFunc));
            } 
            return  m_DidAllocFunc(m_ptr, pv);
        }
        delegate int DidAllocFunc(IntPtr self, IntPtr pv);
        DidAllocFunc m_DidAllocFunc;

        public void HeapMinimize()
        {
            if(m_HeapMinimizeFunc==null){
                var fp = GetFunctionPointer(8);
                m_HeapMinimizeFunc = (HeapMinimizeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(HeapMinimizeFunc));
            } 
             m_HeapMinimizeFunc(m_ptr);
        }
        delegate void HeapMinimizeFunc(IntPtr self);
        HeapMinimizeFunc m_HeapMinimizeFunc;

    }
}
