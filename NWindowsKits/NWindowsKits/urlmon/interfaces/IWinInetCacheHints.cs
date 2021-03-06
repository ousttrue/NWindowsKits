// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/urlmon.h:4415
    public class IWinInetCacheHints : IUnknown
    {
        static Guid s_uuid = new Guid("dd1ec3b3-8391-4fdb-a9e6-347c3caaa7dd");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int SetCacheExtension([MarshalAs(UnmanagedType.LPWStr)] string pwzExt, IntPtr pszCacheFile, ref uint pcbCacheFile, ref uint pdwWinInetError, ref uint pdwReserved)
        {
            if(m_SetCacheExtensionFunc==null){
                var fp = GetFunctionPointer(3);
                m_SetCacheExtensionFunc = (SetCacheExtensionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetCacheExtensionFunc));
            } 
            return  m_SetCacheExtensionFunc(m_ptr, pwzExt, pszCacheFile, ref pcbCacheFile, ref pdwWinInetError, ref pdwReserved);
        }
        delegate int SetCacheExtensionFunc(IntPtr self, [MarshalAs(UnmanagedType.LPWStr)] string pwzExt, IntPtr pszCacheFile, ref uint pcbCacheFile, ref uint pdwWinInetError, ref uint pdwReserved);
        SetCacheExtensionFunc m_SetCacheExtensionFunc;

    }
}
