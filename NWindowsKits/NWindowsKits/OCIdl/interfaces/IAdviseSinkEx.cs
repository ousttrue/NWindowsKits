// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/OCIdl.h:6324
    public class IAdviseSinkEx : IAdviseSink
    {
        static Guid s_uuid = new Guid("3af24290-0c96-11ce-a0cf-00aa00600ab8");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public void OnViewStatusChange(uint dwViewStatus)
        {
            if(m_OnViewStatusChangeFunc==null){
                var fp = GetFunctionPointer(8);
                m_OnViewStatusChangeFunc = (OnViewStatusChangeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OnViewStatusChangeFunc));
            } 
             m_OnViewStatusChangeFunc(m_ptr, dwViewStatus);
        }
        delegate void OnViewStatusChangeFunc(IntPtr self, uint dwViewStatus);
        OnViewStatusChangeFunc m_OnViewStatusChangeFunc;

    }
}
