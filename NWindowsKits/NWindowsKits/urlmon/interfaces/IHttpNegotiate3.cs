// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/urlmon.h:2433
    public class IHttpNegotiate3 : IHttpNegotiate2 // 1
    {
        static Guid s_uuid = new Guid("57b6c80a-34c2-4602-bc26-66a02fc57153");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int GetSerializedClientCertContext(ref IntPtr ppbCert, ref uint pcbCert)
        {
            if(m_GetSerializedClientCertContextFunc==null){
                var fp = GetFunctionPointer(6);
                m_GetSerializedClientCertContextFunc = (GetSerializedClientCertContextFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetSerializedClientCertContextFunc));
            } 
            
            return  m_GetSerializedClientCertContextFunc(m_ptr, ref ppbCert, ref pcbCert);
        }
        delegate int GetSerializedClientCertContextFunc(IntPtr self, ref IntPtr ppbCert, ref uint pcbCert);
        GetSerializedClientCertContextFunc m_GetSerializedClientCertContextFunc;

    }
}