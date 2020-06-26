// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/urlmon.h:5258
    public class IInternetProtocolRoot : IUnknown // 1
    {
        static Guid s_uuid = new Guid("79eac9e3-baf9-11ce-8c82-00aa004ba90b");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int Start([MarshalAs(UnmanagedType.LPWStr)] string szUrl, IntPtr pOIProtSink, IntPtr pOIBindInfo, uint grfPI, ulong dwReserved)
        {
            if(m_StartFunc==null){
                var fp = GetFunctionPointer(3);
                m_StartFunc = (StartFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(StartFunc));
            } 
            return  m_StartFunc(m_ptr, szUrl, pOIProtSink, pOIBindInfo, grfPI, dwReserved);
        }
        delegate int StartFunc(IntPtr self, [MarshalAs(UnmanagedType.LPWStr)] string szUrl, IntPtr pOIProtSink, IntPtr pOIBindInfo, uint grfPI, ulong dwReserved);
        StartFunc m_StartFunc;

        public int Continue(ref PROTOCOLDATA pProtocolData)
        {
            if(m_ContinueFunc==null){
                var fp = GetFunctionPointer(4);
                m_ContinueFunc = (ContinueFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ContinueFunc));
            } 
            return  m_ContinueFunc(m_ptr, ref pProtocolData);
        }
        delegate int ContinueFunc(IntPtr self, ref PROTOCOLDATA pProtocolData);
        ContinueFunc m_ContinueFunc;

        public int Abort(int hrReason, uint dwOptions)
        {
            if(m_AbortFunc==null){
                var fp = GetFunctionPointer(5);
                m_AbortFunc = (AbortFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AbortFunc));
            } 
            return  m_AbortFunc(m_ptr, hrReason, dwOptions);
        }
        delegate int AbortFunc(IntPtr self, int hrReason, uint dwOptions);
        AbortFunc m_AbortFunc;

        public int Terminate(uint dwOptions)
        {
            if(m_TerminateFunc==null){
                var fp = GetFunctionPointer(6);
                m_TerminateFunc = (TerminateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(TerminateFunc));
            } 
            return  m_TerminateFunc(m_ptr, dwOptions);
        }
        delegate int TerminateFunc(IntPtr self, uint dwOptions);
        TerminateFunc m_TerminateFunc;

        public int Suspend()
        {
            if(m_SuspendFunc==null){
                var fp = GetFunctionPointer(7);
                m_SuspendFunc = (SuspendFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SuspendFunc));
            } 
            return  m_SuspendFunc(m_ptr);
        }
        delegate int SuspendFunc(IntPtr self);
        SuspendFunc m_SuspendFunc;

        public int Resume()
        {
            if(m_ResumeFunc==null){
                var fp = GetFunctionPointer(8);
                m_ResumeFunc = (ResumeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ResumeFunc));
            } 
            return  m_ResumeFunc(m_ptr);
        }
        delegate int ResumeFunc(IntPtr self);
        ResumeFunc m_ResumeFunc;

    }
}
