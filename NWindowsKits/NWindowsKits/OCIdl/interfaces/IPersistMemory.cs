// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/OCIdl.h:2386
    public class IPersistMemory : IPersist
    {
        static Guid s_uuid = new Guid("bd1ae5e0-a6ae-11ce-bd37-504200c10000");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int IsDirty()
        {
            if(m_IsDirtyFunc==null){
                var fp = GetFunctionPointer(4);
                m_IsDirtyFunc = (IsDirtyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IsDirtyFunc));
            } 
            return  m_IsDirtyFunc(m_ptr);
        }
        delegate int IsDirtyFunc(IntPtr self);
        IsDirtyFunc m_IsDirtyFunc;

        public int Load(IntPtr pMem, uint cbSize)
        {
            if(m_LoadFunc==null){
                var fp = GetFunctionPointer(5);
                m_LoadFunc = (LoadFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(LoadFunc));
            } 
            return  m_LoadFunc(m_ptr, pMem, cbSize);
        }
        delegate int LoadFunc(IntPtr self, IntPtr pMem, uint cbSize);
        LoadFunc m_LoadFunc;

        public int Save(IntPtr pMem, int fClearDirty, uint cbSize)
        {
            if(m_SaveFunc==null){
                var fp = GetFunctionPointer(6);
                m_SaveFunc = (SaveFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SaveFunc));
            } 
            return  m_SaveFunc(m_ptr, pMem, fClearDirty, cbSize);
        }
        delegate int SaveFunc(IntPtr self, IntPtr pMem, int fClearDirty, uint cbSize);
        SaveFunc m_SaveFunc;

        public int GetSizeMax(IntPtr pCbSize)
        {
            if(m_GetSizeMaxFunc==null){
                var fp = GetFunctionPointer(7);
                m_GetSizeMaxFunc = (GetSizeMaxFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetSizeMaxFunc));
            } 
            return  m_GetSizeMaxFunc(m_ptr, pCbSize);
        }
        delegate int GetSizeMaxFunc(IntPtr self, IntPtr pCbSize);
        GetSizeMaxFunc m_GetSizeMaxFunc;

        public int InitNew()
        {
            if(m_InitNewFunc==null){
                var fp = GetFunctionPointer(8);
                m_InitNewFunc = (InitNewFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(InitNewFunc));
            } 
            return  m_InitNewFunc(m_ptr);
        }
        delegate int InitNewFunc(IntPtr self);
        InitNewFunc m_InitNewFunc;

    }
}
