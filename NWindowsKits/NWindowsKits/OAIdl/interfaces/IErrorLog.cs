// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/OAIdl.h:5185
    public class IErrorLog : IUnknown // 1
    {
        static Guid s_uuid = new Guid("3127ca40-446e-11ce-8135-00aa004bb851");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int AddError(IntPtr pszPropName, ref EXCEPINFO pExcepInfo)
        {
            if(m_AddErrorFunc==null){
                var fp = GetFunctionPointer(3);
                m_AddErrorFunc = (AddErrorFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AddErrorFunc));
            } 
            return  m_AddErrorFunc(m_ptr, pszPropName, ref pExcepInfo);
        }
        delegate int AddErrorFunc(IntPtr self, IntPtr pszPropName, ref EXCEPINFO pExcepInfo);
        AddErrorFunc m_AddErrorFunc;

    }
}
