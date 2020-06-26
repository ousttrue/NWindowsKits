// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/objidlbase.h:1714
    public class IInternalUnknown : IUnknown // 1
    {
        static Guid s_uuid = new Guid("00000021-0000-0000-c000-000000000046");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int QueryInternalInterface(ref Guid riid, ref IntPtr ppv)
        {
            if(m_QueryInternalInterfaceFunc==null){
                var fp = GetFunctionPointer(3);
                m_QueryInternalInterfaceFunc = (QueryInternalInterfaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(QueryInternalInterfaceFunc));
            } 
            return  m_QueryInternalInterfaceFunc(m_ptr, ref riid, ref ppv);
        }
        delegate int QueryInternalInterfaceFunc(IntPtr self, ref Guid riid, ref IntPtr ppv);
        QueryInternalInterfaceFunc m_QueryInternalInterfaceFunc;

    }
}
