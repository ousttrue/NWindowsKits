// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/d3dcommon.h:472
    public class ID3DDestructionNotifier : IUnknown
    {
        static Guid s_uuid = new Guid("a06eb39a-50da-425b-8c31-4eecd6c270f3");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int RegisterDestructionCallback(PFN_DESTRUCTION_CALLBACK callbackFn, IntPtr pData, ref uint pCallbackID)
        {
            if(m_RegisterDestructionCallbackFunc==null){
                var fp = GetFunctionPointer(3);
                m_RegisterDestructionCallbackFunc = (RegisterDestructionCallbackFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RegisterDestructionCallbackFunc));
            } 
            return  m_RegisterDestructionCallbackFunc(m_ptr, callbackFn, pData, ref pCallbackID);
        }
        delegate int RegisterDestructionCallbackFunc(IntPtr self, PFN_DESTRUCTION_CALLBACK callbackFn, IntPtr pData, ref uint pCallbackID);
        RegisterDestructionCallbackFunc m_RegisterDestructionCallbackFunc;

        public int UnregisterDestructionCallback(uint callbackID)
        {
            if(m_UnregisterDestructionCallbackFunc==null){
                var fp = GetFunctionPointer(4);
                m_UnregisterDestructionCallbackFunc = (UnregisterDestructionCallbackFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(UnregisterDestructionCallbackFunc));
            } 
            return  m_UnregisterDestructionCallbackFunc(m_ptr, callbackID);
        }
        delegate int UnregisterDestructionCallbackFunc(IntPtr self, uint callbackID);
        UnregisterDestructionCallbackFunc m_UnregisterDestructionCallbackFunc;

    }
}
