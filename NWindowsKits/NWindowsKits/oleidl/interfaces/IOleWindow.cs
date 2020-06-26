// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/oleidl.h:1560
    public class IOleWindow : IUnknown // 1
    {
        static Guid s_uuid = new Guid("00000114-0000-0000-c000-000000000046");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int GetWindow(ref HWND phwnd)
        {
            if(m_GetWindowFunc==null){
                var fp = GetFunctionPointer(3);
                m_GetWindowFunc = (GetWindowFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetWindowFunc));
            } 
            return  m_GetWindowFunc(m_ptr, ref phwnd);
        }
        delegate int GetWindowFunc(IntPtr self, ref HWND phwnd);
        GetWindowFunc m_GetWindowFunc;

        public int ContextSensitiveHelp(int fEnterMode)
        {
            if(m_ContextSensitiveHelpFunc==null){
                var fp = GetFunctionPointer(4);
                m_ContextSensitiveHelpFunc = (ContextSensitiveHelpFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ContextSensitiveHelpFunc));
            } 
            return  m_ContextSensitiveHelpFunc(m_ptr, fEnterMode);
        }
        delegate int ContextSensitiveHelpFunc(IntPtr self, int fEnterMode);
        ContextSensitiveHelpFunc m_ContextSensitiveHelpFunc;

    }
}
