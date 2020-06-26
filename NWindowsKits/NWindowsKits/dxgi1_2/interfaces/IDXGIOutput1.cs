// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/shared/dxgi1_2.h:2173
    public class IDXGIOutput1 : IDXGIOutput
    {
        static Guid s_uuid = new Guid("00cddea8-939b-4b83-a340-a685226666cc");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int GetDisplayModeList1(DXGI_FORMAT EnumFormat, uint Flags, ref uint pNumModes, ref DXGI_MODE_DESC1 pDesc)
        {
            if(m_GetDisplayModeList1Func==null){
                var fp = GetFunctionPointer(19);
                m_GetDisplayModeList1Func = (GetDisplayModeList1Func)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDisplayModeList1Func));
            } 
            return  m_GetDisplayModeList1Func(m_ptr, EnumFormat, Flags, ref pNumModes, ref pDesc);
        }
        delegate int GetDisplayModeList1Func(IntPtr self, DXGI_FORMAT EnumFormat, uint Flags, ref uint pNumModes, ref DXGI_MODE_DESC1 pDesc);
        GetDisplayModeList1Func m_GetDisplayModeList1Func;

        public int FindClosestMatchingMode1(ref DXGI_MODE_DESC1 pModeToMatch, ref DXGI_MODE_DESC1 pClosestMatch, IntPtr pConcernedDevice)
        {
            if(m_FindClosestMatchingMode1Func==null){
                var fp = GetFunctionPointer(20);
                m_FindClosestMatchingMode1Func = (FindClosestMatchingMode1Func)Marshal.GetDelegateForFunctionPointer(fp, typeof(FindClosestMatchingMode1Func));
            } 
            return  m_FindClosestMatchingMode1Func(m_ptr, ref pModeToMatch, ref pClosestMatch, pConcernedDevice);
        }
        delegate int FindClosestMatchingMode1Func(IntPtr self, ref DXGI_MODE_DESC1 pModeToMatch, ref DXGI_MODE_DESC1 pClosestMatch, IntPtr pConcernedDevice);
        FindClosestMatchingMode1Func m_FindClosestMatchingMode1Func;

        public int GetDisplaySurfaceData1(IntPtr pDestination)
        {
            if(m_GetDisplaySurfaceData1Func==null){
                var fp = GetFunctionPointer(21);
                m_GetDisplaySurfaceData1Func = (GetDisplaySurfaceData1Func)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDisplaySurfaceData1Func));
            } 
            return  m_GetDisplaySurfaceData1Func(m_ptr, pDestination);
        }
        delegate int GetDisplaySurfaceData1Func(IntPtr self, IntPtr pDestination);
        GetDisplaySurfaceData1Func m_GetDisplaySurfaceData1Func;

        public int DuplicateOutput(IntPtr pDevice, ref IntPtr ppOutputDuplication)
        {
            if(m_DuplicateOutputFunc==null){
                var fp = GetFunctionPointer(22);
                m_DuplicateOutputFunc = (DuplicateOutputFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DuplicateOutputFunc));
            } 
            return  m_DuplicateOutputFunc(m_ptr, pDevice, ref ppOutputDuplication);
        }
        delegate int DuplicateOutputFunc(IntPtr self, IntPtr pDevice, ref IntPtr ppOutputDuplication);
        DuplicateOutputFunc m_DuplicateOutputFunc;

    }
}
