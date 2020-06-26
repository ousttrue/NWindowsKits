// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/urlmon.h:4311
    public class IWinInetHttpTimeouts : IUnknown
    {
        static Guid s_uuid = new Guid("f286fa56-c1fd-4270-8e67-b3eb790a81e8");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int GetRequestTimeouts(ref uint pdwConnectTimeout, ref uint pdwSendTimeout, ref uint pdwReceiveTimeout)
        {
            if(m_GetRequestTimeoutsFunc==null){
                var fp = GetFunctionPointer(3);
                m_GetRequestTimeoutsFunc = (GetRequestTimeoutsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetRequestTimeoutsFunc));
            } 
            return  m_GetRequestTimeoutsFunc(m_ptr, ref pdwConnectTimeout, ref pdwSendTimeout, ref pdwReceiveTimeout);
        }
        delegate int GetRequestTimeoutsFunc(IntPtr self, ref uint pdwConnectTimeout, ref uint pdwSendTimeout, ref uint pdwReceiveTimeout);
        GetRequestTimeoutsFunc m_GetRequestTimeoutsFunc;

    }
}
