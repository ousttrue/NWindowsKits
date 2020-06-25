// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/OAIdl.h:5269
    public class IPropertyBag : IUnknown // 1
    {
        static Guid s_uuid = new Guid("55272a00-42cb-11ce-8135-00aa004bb851");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int Read(IntPtr pszPropName, ref VARIANT pVar, IntPtr pErrorLog)
        {
            if(m_ReadFunc==null){
                var fp = GetFunctionPointer(3);
                m_ReadFunc = (ReadFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReadFunc));
            } 
            
            return  m_ReadFunc(m_ptr, pszPropName, ref pVar, pErrorLog);
        }
        delegate int ReadFunc(IntPtr self, IntPtr pszPropName, ref VARIANT pVar, IntPtr pErrorLog);
        ReadFunc m_ReadFunc;

        public int Write(IntPtr pszPropName, ref VARIANT pVar)
        {
            if(m_WriteFunc==null){
                var fp = GetFunctionPointer(4);
                m_WriteFunc = (WriteFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(WriteFunc));
            } 
            
            return  m_WriteFunc(m_ptr, pszPropName, ref pVar);
        }
        delegate int WriteFunc(IntPtr self, IntPtr pszPropName, ref VARIANT pVar);
        WriteFunc m_WriteFunc;

    }
}