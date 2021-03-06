// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/ObjIdl.h:11348
    public class IAdviseSink : IUnknown
    {
        static Guid s_uuid = new Guid("0000010f-0000-0000-c000-000000000046");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public void OnDataChange(ref FORMATETC pFormatetc, IntPtr pStgmed)
        {
            if(m_OnDataChangeFunc==null){
                var fp = GetFunctionPointer(3);
                m_OnDataChangeFunc = (OnDataChangeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OnDataChangeFunc));
            } 
             m_OnDataChangeFunc(m_ptr, ref pFormatetc, pStgmed);
        }
        delegate void OnDataChangeFunc(IntPtr self, ref FORMATETC pFormatetc, IntPtr pStgmed);
        OnDataChangeFunc m_OnDataChangeFunc;

        public void OnViewChange(uint dwAspect, int lindex)
        {
            if(m_OnViewChangeFunc==null){
                var fp = GetFunctionPointer(4);
                m_OnViewChangeFunc = (OnViewChangeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OnViewChangeFunc));
            } 
             m_OnViewChangeFunc(m_ptr, dwAspect, lindex);
        }
        delegate void OnViewChangeFunc(IntPtr self, uint dwAspect, int lindex);
        OnViewChangeFunc m_OnViewChangeFunc;

        public void OnRename(IntPtr pmk)
        {
            if(m_OnRenameFunc==null){
                var fp = GetFunctionPointer(5);
                m_OnRenameFunc = (OnRenameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OnRenameFunc));
            } 
             m_OnRenameFunc(m_ptr, pmk);
        }
        delegate void OnRenameFunc(IntPtr self, IntPtr pmk);
        OnRenameFunc m_OnRenameFunc;

        public void OnSave()
        {
            if(m_OnSaveFunc==null){
                var fp = GetFunctionPointer(6);
                m_OnSaveFunc = (OnSaveFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OnSaveFunc));
            } 
             m_OnSaveFunc(m_ptr);
        }
        delegate void OnSaveFunc(IntPtr self);
        OnSaveFunc m_OnSaveFunc;

        public void OnClose()
        {
            if(m_OnCloseFunc==null){
                var fp = GetFunctionPointer(7);
                m_OnCloseFunc = (OnCloseFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OnCloseFunc));
            } 
             m_OnCloseFunc(m_ptr);
        }
        delegate void OnCloseFunc(IntPtr self);
        OnCloseFunc m_OnCloseFunc;

    }
}
