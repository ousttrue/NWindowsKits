// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/ObjIdl.h:9151
    public class IPersist : IUnknown
    {
        static Guid s_uuid = new Guid("0000010c-0000-0000-c000-000000000046");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int GetClassID(IntPtr pClassID)
        {
            if(m_GetClassIDFunc==null){
                var fp = GetFunctionPointer(3);
                m_GetClassIDFunc = (GetClassIDFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetClassIDFunc));
            } 
            return  m_GetClassIDFunc(m_ptr, pClassID);
        }
        delegate int GetClassIDFunc(IntPtr self, IntPtr pClassID);
        GetClassIDFunc m_GetClassIDFunc;

    }
}
