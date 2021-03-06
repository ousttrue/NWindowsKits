// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/OCIdl.h:1221
    public class IProvideClassInfo2 : IProvideClassInfo
    {
        static Guid s_uuid = new Guid("a6bc3ac0-dbaa-11ce-9de3-00aa004bb851");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int GetGUID(uint dwGuidKind, ref GUID pGUID)
        {
            if(m_GetGUIDFunc==null){
                var fp = GetFunctionPointer(4);
                m_GetGUIDFunc = (GetGUIDFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetGUIDFunc));
            } 
            return  m_GetGUIDFunc(m_ptr, dwGuidKind, ref pGUID);
        }
        delegate int GetGUIDFunc(IntPtr self, uint dwGuidKind, ref GUID pGUID);
        GetGUIDFunc m_GetGUIDFunc;

    }
}
