// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/unknwnbase.h:299
    public class AsyncIUnknown : IUnknown // 1
    {
        static Guid s_uuid = new Guid("000e0000-0000-0000-c000-000000000046");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int Begin_QueryInterface(ref Guid riid)
        {
            if(m_Begin_QueryInterfaceFunc==null){
                var fp = GetFunctionPointer(3);
                m_Begin_QueryInterfaceFunc = (Begin_QueryInterfaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(Begin_QueryInterfaceFunc));
            } 
            
            return  m_Begin_QueryInterfaceFunc(m_ptr, ref riid);
        }
        delegate int Begin_QueryInterfaceFunc(IntPtr self, ref Guid riid);
        Begin_QueryInterfaceFunc m_Begin_QueryInterfaceFunc;

        public int Finish_QueryInterface(ref IntPtr ppvObject)
        {
            if(m_Finish_QueryInterfaceFunc==null){
                var fp = GetFunctionPointer(4);
                m_Finish_QueryInterfaceFunc = (Finish_QueryInterfaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(Finish_QueryInterfaceFunc));
            } 
            
            return  m_Finish_QueryInterfaceFunc(m_ptr, ref ppvObject);
        }
        delegate int Finish_QueryInterfaceFunc(IntPtr self, ref IntPtr ppvObject);
        Finish_QueryInterfaceFunc m_Finish_QueryInterfaceFunc;

        public int Begin_AddRef()
        {
            if(m_Begin_AddRefFunc==null){
                var fp = GetFunctionPointer(5);
                m_Begin_AddRefFunc = (Begin_AddRefFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(Begin_AddRefFunc));
            } 
            
            return  m_Begin_AddRefFunc(m_ptr);
        }
        delegate int Begin_AddRefFunc(IntPtr self);
        Begin_AddRefFunc m_Begin_AddRefFunc;

        public uint Finish_AddRef()
        {
            if(m_Finish_AddRefFunc==null){
                var fp = GetFunctionPointer(6);
                m_Finish_AddRefFunc = (Finish_AddRefFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(Finish_AddRefFunc));
            } 
            
            return  m_Finish_AddRefFunc(m_ptr);
        }
        delegate uint Finish_AddRefFunc(IntPtr self);
        Finish_AddRefFunc m_Finish_AddRefFunc;

        public int Begin_Release()
        {
            if(m_Begin_ReleaseFunc==null){
                var fp = GetFunctionPointer(7);
                m_Begin_ReleaseFunc = (Begin_ReleaseFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(Begin_ReleaseFunc));
            } 
            
            return  m_Begin_ReleaseFunc(m_ptr);
        }
        delegate int Begin_ReleaseFunc(IntPtr self);
        Begin_ReleaseFunc m_Begin_ReleaseFunc;

        public uint Finish_Release()
        {
            if(m_Finish_ReleaseFunc==null){
                var fp = GetFunctionPointer(8);
                m_Finish_ReleaseFunc = (Finish_ReleaseFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(Finish_ReleaseFunc));
            } 
            
            return  m_Finish_ReleaseFunc(m_ptr);
        }
        delegate uint Finish_ReleaseFunc(IntPtr self);
        Finish_ReleaseFunc m_Finish_ReleaseFunc;

    }
}