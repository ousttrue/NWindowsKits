// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/shared/dxgi.h:2413
    public class IDXGIFactory1 : IDXGIFactory // 1
    {
        static Guid s_uuid = new Guid("770aae78-f26f-4dba-a829-253c83d1b387");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int EnumAdapters1(uint Adapter, ref IntPtr ppAdapter)
        {
            if(m_EnumAdapters1Func==null){
                var fp = GetFunctionPointer(12);
                m_EnumAdapters1Func = (EnumAdapters1Func)Marshal.GetDelegateForFunctionPointer(fp, typeof(EnumAdapters1Func));
            } 
            return  m_EnumAdapters1Func(m_ptr, Adapter, ref ppAdapter);
        }
        delegate int EnumAdapters1Func(IntPtr self, uint Adapter, ref IntPtr ppAdapter);
        EnumAdapters1Func m_EnumAdapters1Func;

        public int IsCurrent()
        {
            if(m_IsCurrentFunc==null){
                var fp = GetFunctionPointer(13);
                m_IsCurrentFunc = (IsCurrentFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IsCurrentFunc));
            } 
            return  m_IsCurrentFunc(m_ptr);
        }
        delegate int IsCurrentFunc(IntPtr self);
        IsCurrentFunc m_IsCurrentFunc;

    }
}
