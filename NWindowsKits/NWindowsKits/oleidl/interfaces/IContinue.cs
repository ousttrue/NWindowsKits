// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/oleidl.h:2831
    public class IContinue : IUnknown // 1
    {
        static Guid s_uuid = new Guid("0000012a-0000-0000-c000-000000000046");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int FContinue()
        {
            if(m_FContinueFunc==null){
                var fp = GetFunctionPointer(3);
                m_FContinueFunc = (FContinueFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(FContinueFunc));
            } 
            return  m_FContinueFunc(m_ptr);
        }
        delegate int FContinueFunc(IntPtr self);
        FContinueFunc m_FContinueFunc;

    }
}
