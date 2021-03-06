// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/urlmon.h:9473
    public class ISoftDistExt : IUnknown
    {
        static Guid s_uuid = new Guid("b15b8dc1-c7e1-11d0-8680-00aa00bdcb71");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int ProcessSoftDist([MarshalAs(UnmanagedType.LPWStr)] string szCDFURL, IntPtr pSoftDistElement, ref LPSOFTDISTINFO lpsdi)
        {
            if(m_ProcessSoftDistFunc==null){
                var fp = GetFunctionPointer(3);
                m_ProcessSoftDistFunc = (ProcessSoftDistFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ProcessSoftDistFunc));
            } 
            return  m_ProcessSoftDistFunc(m_ptr, szCDFURL, pSoftDistElement, ref lpsdi);
        }
        delegate int ProcessSoftDistFunc(IntPtr self, [MarshalAs(UnmanagedType.LPWStr)] string szCDFURL, IntPtr pSoftDistElement, ref LPSOFTDISTINFO lpsdi);
        ProcessSoftDistFunc m_ProcessSoftDistFunc;

        public int GetFirstCodeBase(ref IntPtr szCodeBase, ref uint dwMaxSize)
        {
            if(m_GetFirstCodeBaseFunc==null){
                var fp = GetFunctionPointer(4);
                m_GetFirstCodeBaseFunc = (GetFirstCodeBaseFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFirstCodeBaseFunc));
            } 
            return  m_GetFirstCodeBaseFunc(m_ptr, ref szCodeBase, ref dwMaxSize);
        }
        delegate int GetFirstCodeBaseFunc(IntPtr self, ref IntPtr szCodeBase, ref uint dwMaxSize);
        GetFirstCodeBaseFunc m_GetFirstCodeBaseFunc;

        public int GetNextCodeBase(ref IntPtr szCodeBase, ref uint dwMaxSize)
        {
            if(m_GetNextCodeBaseFunc==null){
                var fp = GetFunctionPointer(5);
                m_GetNextCodeBaseFunc = (GetNextCodeBaseFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetNextCodeBaseFunc));
            } 
            return  m_GetNextCodeBaseFunc(m_ptr, ref szCodeBase, ref dwMaxSize);
        }
        delegate int GetNextCodeBaseFunc(IntPtr self, ref IntPtr szCodeBase, ref uint dwMaxSize);
        GetNextCodeBaseFunc m_GetNextCodeBaseFunc;

        public int AsyncInstallDistributionUnit(IntPtr pbc, IntPtr pvReserved, uint flags, ref LPCODEBASEHOLD lpcbh)
        {
            if(m_AsyncInstallDistributionUnitFunc==null){
                var fp = GetFunctionPointer(6);
                m_AsyncInstallDistributionUnitFunc = (AsyncInstallDistributionUnitFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AsyncInstallDistributionUnitFunc));
            } 
            return  m_AsyncInstallDistributionUnitFunc(m_ptr, pbc, pvReserved, flags, ref lpcbh);
        }
        delegate int AsyncInstallDistributionUnitFunc(IntPtr self, IntPtr pbc, IntPtr pvReserved, uint flags, ref LPCODEBASEHOLD lpcbh);
        AsyncInstallDistributionUnitFunc m_AsyncInstallDistributionUnitFunc;

    }
}
