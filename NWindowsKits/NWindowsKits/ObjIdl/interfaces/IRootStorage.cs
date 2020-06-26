// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/ObjIdl.h:11140
    public class IRootStorage : IUnknown // 1
    {
        static Guid s_uuid = new Guid("00000012-0000-0000-c000-000000000046");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int SwitchToFile(IntPtr pszFile)
        {
            if(m_SwitchToFileFunc==null){
                var fp = GetFunctionPointer(3);
                m_SwitchToFileFunc = (SwitchToFileFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SwitchToFileFunc));
            } 
            return  m_SwitchToFileFunc(m_ptr, pszFile);
        }
        delegate int SwitchToFileFunc(IntPtr self, IntPtr pszFile);
        SwitchToFileFunc m_SwitchToFileFunc;

    }
}
