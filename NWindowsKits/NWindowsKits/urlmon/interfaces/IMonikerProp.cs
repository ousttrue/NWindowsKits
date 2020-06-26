// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/urlmon.h:957
    public class IMonikerProp : IUnknown
    {
        static Guid s_uuid = new Guid("a5ca5f7f-1847-4d87-9c5b-918509f7511d");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int PutProperty(MONIKERPROPERTY mkp, [MarshalAs(UnmanagedType.LPWStr)] string val)
        {
            if(m_PutPropertyFunc==null){
                var fp = GetFunctionPointer(3);
                m_PutPropertyFunc = (PutPropertyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(PutPropertyFunc));
            } 
            return  m_PutPropertyFunc(m_ptr, mkp, val);
        }
        delegate int PutPropertyFunc(IntPtr self, MONIKERPROPERTY mkp, [MarshalAs(UnmanagedType.LPWStr)] string val);
        PutPropertyFunc m_PutPropertyFunc;

    }
}
