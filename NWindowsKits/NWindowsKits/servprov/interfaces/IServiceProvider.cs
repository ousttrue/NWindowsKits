// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/servprov.h:97
    public class IServiceProvider : IUnknown
    {
        static Guid s_uuid = new Guid("6d5140c1-7436-11ce-8034-00aa006009fa");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int QueryService(ref GUID guidService, ref Guid riid, ref IntPtr ppvObject)
        {
            if(m_QueryServiceFunc==null){
                var fp = GetFunctionPointer(3);
                m_QueryServiceFunc = (QueryServiceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(QueryServiceFunc));
            } 
            return  m_QueryServiceFunc(m_ptr, ref guidService, ref riid, ref ppvObject);
        }
        delegate int QueryServiceFunc(IntPtr self, ref GUID guidService, ref Guid riid, ref IntPtr ppvObject);
        QueryServiceFunc m_QueryServiceFunc;

    }
}
