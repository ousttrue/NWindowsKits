// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/shared/dxgi.h:1072
    public class IDXGISurface1 : IDXGISurface
    {
        static Guid s_uuid = new Guid("4ae63092-6327-4c1b-80ae-bfe12ea32b86");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int GetDC(int Discard, ref HDC phdc)
        {
            if(m_GetDCFunc==null){
                var fp = GetFunctionPointer(11);
                m_GetDCFunc = (GetDCFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDCFunc));
            } 
            return  m_GetDCFunc(m_ptr, Discard, ref phdc);
        }
        delegate int GetDCFunc(IntPtr self, int Discard, ref HDC phdc);
        GetDCFunc m_GetDCFunc;

        public int ReleaseDC(ref RECT pDirtyRect)
        {
            if(m_ReleaseDCFunc==null){
                var fp = GetFunctionPointer(12);
                m_ReleaseDCFunc = (ReleaseDCFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReleaseDCFunc));
            } 
            return  m_ReleaseDCFunc(m_ptr, ref pDirtyRect);
        }
        delegate int ReleaseDCFunc(IntPtr self, ref RECT pDirtyRect);
        ReleaseDCFunc m_ReleaseDCFunc;

    }
}
