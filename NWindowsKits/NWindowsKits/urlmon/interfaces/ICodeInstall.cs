// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/urlmon.h:2774
    public class ICodeInstall : IWindowForBindingUI
    {
        static Guid s_uuid = new Guid("79eac9d1-baf9-11ce-8c82-00aa004ba90b");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int OnCodeInstallProblem(uint ulStatusCode, [MarshalAs(UnmanagedType.LPWStr)] string szDestination, [MarshalAs(UnmanagedType.LPWStr)] string szSource, uint dwReserved)
        {
            if(m_OnCodeInstallProblemFunc==null){
                var fp = GetFunctionPointer(4);
                m_OnCodeInstallProblemFunc = (OnCodeInstallProblemFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OnCodeInstallProblemFunc));
            } 
            return  m_OnCodeInstallProblemFunc(m_ptr, ulStatusCode, szDestination, szSource, dwReserved);
        }
        delegate int OnCodeInstallProblemFunc(IntPtr self, uint ulStatusCode, [MarshalAs(UnmanagedType.LPWStr)] string szDestination, [MarshalAs(UnmanagedType.LPWStr)] string szSource, uint dwReserved);
        OnCodeInstallProblemFunc m_OnCodeInstallProblemFunc;

    }
}
