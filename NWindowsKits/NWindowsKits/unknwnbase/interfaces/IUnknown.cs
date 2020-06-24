// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/include/10.0.18362.0/um/unknwnbase.h:108
    public class IUnknown : ComPtr // 44
    {
        static Guid s_uuid = new Guid("00000000-0000-0000-c000-000000000046");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int QueryInterface(ref Guid riid, ref IntPtr ppvObject)
        {
            var fp = GetFunctionPointer(0);
            if(m_QueryInterfaceFunc==null) m_QueryInterfaceFunc = (QueryInterfaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(QueryInterfaceFunc));
            
            return  m_QueryInterfaceFunc(m_ptr, ref riid, ref ppvObject);
        }
        delegate int QueryInterfaceFunc(IntPtr self, ref Guid riid, ref IntPtr ppvObject);
        QueryInterfaceFunc m_QueryInterfaceFunc;

        public uint AddRef()
        {
            var fp = GetFunctionPointer(1);
            if(m_AddRefFunc==null) m_AddRefFunc = (AddRefFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AddRefFunc));
            
            return  m_AddRefFunc(m_ptr);
        }
        delegate uint AddRefFunc(IntPtr self);
        AddRefFunc m_AddRefFunc;

        public uint Release()
        {
            var fp = GetFunctionPointer(2);
            if(m_ReleaseFunc==null) m_ReleaseFunc = (ReleaseFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReleaseFunc));
            
            return  m_ReleaseFunc(m_ptr);
        }
        delegate uint ReleaseFunc(IntPtr self);
        ReleaseFunc m_ReleaseFunc;

    }
}