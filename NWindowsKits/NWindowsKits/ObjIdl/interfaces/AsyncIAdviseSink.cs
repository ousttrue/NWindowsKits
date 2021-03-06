// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/ObjIdl.h:11534
    public class AsyncIAdviseSink : IUnknown
    {
        static Guid s_uuid = new Guid("00000150-0000-0000-c000-000000000046");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public void Begin_OnDataChange(ref FORMATETC pFormatetc, IntPtr pStgmed)
        {
            if(m_Begin_OnDataChangeFunc==null){
                var fp = GetFunctionPointer(3);
                m_Begin_OnDataChangeFunc = (Begin_OnDataChangeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(Begin_OnDataChangeFunc));
            } 
             m_Begin_OnDataChangeFunc(m_ptr, ref pFormatetc, pStgmed);
        }
        delegate void Begin_OnDataChangeFunc(IntPtr self, ref FORMATETC pFormatetc, IntPtr pStgmed);
        Begin_OnDataChangeFunc m_Begin_OnDataChangeFunc;

        public void Finish_OnDataChange()
        {
            if(m_Finish_OnDataChangeFunc==null){
                var fp = GetFunctionPointer(4);
                m_Finish_OnDataChangeFunc = (Finish_OnDataChangeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(Finish_OnDataChangeFunc));
            } 
             m_Finish_OnDataChangeFunc(m_ptr);
        }
        delegate void Finish_OnDataChangeFunc(IntPtr self);
        Finish_OnDataChangeFunc m_Finish_OnDataChangeFunc;

        public void Begin_OnViewChange(uint dwAspect, int lindex)
        {
            if(m_Begin_OnViewChangeFunc==null){
                var fp = GetFunctionPointer(5);
                m_Begin_OnViewChangeFunc = (Begin_OnViewChangeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(Begin_OnViewChangeFunc));
            } 
             m_Begin_OnViewChangeFunc(m_ptr, dwAspect, lindex);
        }
        delegate void Begin_OnViewChangeFunc(IntPtr self, uint dwAspect, int lindex);
        Begin_OnViewChangeFunc m_Begin_OnViewChangeFunc;

        public void Finish_OnViewChange()
        {
            if(m_Finish_OnViewChangeFunc==null){
                var fp = GetFunctionPointer(6);
                m_Finish_OnViewChangeFunc = (Finish_OnViewChangeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(Finish_OnViewChangeFunc));
            } 
             m_Finish_OnViewChangeFunc(m_ptr);
        }
        delegate void Finish_OnViewChangeFunc(IntPtr self);
        Finish_OnViewChangeFunc m_Finish_OnViewChangeFunc;

        public void Begin_OnRename(IntPtr pmk)
        {
            if(m_Begin_OnRenameFunc==null){
                var fp = GetFunctionPointer(7);
                m_Begin_OnRenameFunc = (Begin_OnRenameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(Begin_OnRenameFunc));
            } 
             m_Begin_OnRenameFunc(m_ptr, pmk);
        }
        delegate void Begin_OnRenameFunc(IntPtr self, IntPtr pmk);
        Begin_OnRenameFunc m_Begin_OnRenameFunc;

        public void Finish_OnRename()
        {
            if(m_Finish_OnRenameFunc==null){
                var fp = GetFunctionPointer(8);
                m_Finish_OnRenameFunc = (Finish_OnRenameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(Finish_OnRenameFunc));
            } 
             m_Finish_OnRenameFunc(m_ptr);
        }
        delegate void Finish_OnRenameFunc(IntPtr self);
        Finish_OnRenameFunc m_Finish_OnRenameFunc;

        public void Begin_OnSave()
        {
            if(m_Begin_OnSaveFunc==null){
                var fp = GetFunctionPointer(9);
                m_Begin_OnSaveFunc = (Begin_OnSaveFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(Begin_OnSaveFunc));
            } 
             m_Begin_OnSaveFunc(m_ptr);
        }
        delegate void Begin_OnSaveFunc(IntPtr self);
        Begin_OnSaveFunc m_Begin_OnSaveFunc;

        public void Finish_OnSave()
        {
            if(m_Finish_OnSaveFunc==null){
                var fp = GetFunctionPointer(10);
                m_Finish_OnSaveFunc = (Finish_OnSaveFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(Finish_OnSaveFunc));
            } 
             m_Finish_OnSaveFunc(m_ptr);
        }
        delegate void Finish_OnSaveFunc(IntPtr self);
        Finish_OnSaveFunc m_Finish_OnSaveFunc;

        public void Begin_OnClose()
        {
            if(m_Begin_OnCloseFunc==null){
                var fp = GetFunctionPointer(11);
                m_Begin_OnCloseFunc = (Begin_OnCloseFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(Begin_OnCloseFunc));
            } 
             m_Begin_OnCloseFunc(m_ptr);
        }
        delegate void Begin_OnCloseFunc(IntPtr self);
        Begin_OnCloseFunc m_Begin_OnCloseFunc;

        public void Finish_OnClose()
        {
            if(m_Finish_OnCloseFunc==null){
                var fp = GetFunctionPointer(12);
                m_Finish_OnCloseFunc = (Finish_OnCloseFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(Finish_OnCloseFunc));
            } 
             m_Finish_OnCloseFunc(m_ptr);
        }
        delegate void Finish_OnCloseFunc(IntPtr self);
        Finish_OnCloseFunc m_Finish_OnCloseFunc;

    }
}
