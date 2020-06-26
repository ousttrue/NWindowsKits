// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/ObjIdl.h:14062
    public class IProcessLock : IUnknown
    {
        static Guid s_uuid = new Guid("000001d5-0000-0000-c000-000000000046");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public uint AddRefOnProcess()
        {
            if(m_AddRefOnProcessFunc==null){
                var fp = GetFunctionPointer(3);
                m_AddRefOnProcessFunc = (AddRefOnProcessFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AddRefOnProcessFunc));
            } 
            return  m_AddRefOnProcessFunc(m_ptr);
        }
        delegate uint AddRefOnProcessFunc(IntPtr self);
        AddRefOnProcessFunc m_AddRefOnProcessFunc;

        public uint ReleaseRefOnProcess()
        {
            if(m_ReleaseRefOnProcessFunc==null){
                var fp = GetFunctionPointer(4);
                m_ReleaseRefOnProcessFunc = (ReleaseRefOnProcessFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReleaseRefOnProcessFunc));
            } 
            return  m_ReleaseRefOnProcessFunc(m_ptr);
        }
        delegate uint ReleaseRefOnProcessFunc(IntPtr self);
        ReleaseRefOnProcessFunc m_ReleaseRefOnProcessFunc;

    }
}
