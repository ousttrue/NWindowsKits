// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/OCIdl.h:2787
    public class ISimpleFrameSite : IUnknown
    {
        static Guid s_uuid = new Guid("742b0e01-14e6-101b-914e-00aa00300cab");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int PreMessageFilter(HWND hWnd, uint msg, ulong wp, long lp, IntPtr plResult, ref uint pdwCookie)
        {
            if(m_PreMessageFilterFunc==null){
                var fp = GetFunctionPointer(3);
                m_PreMessageFilterFunc = (PreMessageFilterFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(PreMessageFilterFunc));
            } 
            return  m_PreMessageFilterFunc(m_ptr, hWnd, msg, wp, lp, plResult, ref pdwCookie);
        }
        delegate int PreMessageFilterFunc(IntPtr self, HWND hWnd, uint msg, ulong wp, long lp, IntPtr plResult, ref uint pdwCookie);
        PreMessageFilterFunc m_PreMessageFilterFunc;

        public int PostMessageFilter(HWND hWnd, uint msg, ulong wp, long lp, IntPtr plResult, uint dwCookie)
        {
            if(m_PostMessageFilterFunc==null){
                var fp = GetFunctionPointer(4);
                m_PostMessageFilterFunc = (PostMessageFilterFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(PostMessageFilterFunc));
            } 
            return  m_PostMessageFilterFunc(m_ptr, hWnd, msg, wp, lp, plResult, dwCookie);
        }
        delegate int PostMessageFilterFunc(IntPtr self, HWND hWnd, uint msg, ulong wp, long lp, IntPtr plResult, uint dwCookie);
        PostMessageFilterFunc m_PostMessageFilterFunc;

    }
}
