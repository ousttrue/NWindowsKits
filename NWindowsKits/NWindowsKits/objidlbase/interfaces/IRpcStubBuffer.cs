// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/objidlbase.h:3398
    public class IRpcStubBuffer : IUnknown
    {
        static Guid s_uuid = new Guid("d5f56afc-593b-101a-b569-08002b2dbf7a");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int Connect(IntPtr pUnkServer)
        {
            if(m_ConnectFunc==null){
                var fp = GetFunctionPointer(3);
                m_ConnectFunc = (ConnectFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ConnectFunc));
            } 
            return  m_ConnectFunc(m_ptr, pUnkServer);
        }
        delegate int ConnectFunc(IntPtr self, IntPtr pUnkServer);
        ConnectFunc m_ConnectFunc;

        public void Disconnect()
        {
            if(m_DisconnectFunc==null){
                var fp = GetFunctionPointer(4);
                m_DisconnectFunc = (DisconnectFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DisconnectFunc));
            } 
             m_DisconnectFunc(m_ptr);
        }
        delegate void DisconnectFunc(IntPtr self);
        DisconnectFunc m_DisconnectFunc;

        public int Invoke(ref RPCOLEMESSAGE _prpcmsg, IntPtr _pRpcChannelBuffer)
        {
            if(m_InvokeFunc==null){
                var fp = GetFunctionPointer(5);
                m_InvokeFunc = (InvokeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(InvokeFunc));
            } 
            return  m_InvokeFunc(m_ptr, ref _prpcmsg, _pRpcChannelBuffer);
        }
        delegate int InvokeFunc(IntPtr self, ref RPCOLEMESSAGE _prpcmsg, IntPtr _pRpcChannelBuffer);
        InvokeFunc m_InvokeFunc;

        public IntPtr IsIIDSupported(ref Guid riid)
        {
            if(m_IsIIDSupportedFunc==null){
                var fp = GetFunctionPointer(6);
                m_IsIIDSupportedFunc = (IsIIDSupportedFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IsIIDSupportedFunc));
            } 
            return  m_IsIIDSupportedFunc(m_ptr, ref riid);
        }
        delegate IntPtr IsIIDSupportedFunc(IntPtr self, ref Guid riid);
        IsIIDSupportedFunc m_IsIIDSupportedFunc;

        public uint CountRefs()
        {
            if(m_CountRefsFunc==null){
                var fp = GetFunctionPointer(7);
                m_CountRefsFunc = (CountRefsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CountRefsFunc));
            } 
            return  m_CountRefsFunc(m_ptr);
        }
        delegate uint CountRefsFunc(IntPtr self);
        CountRefsFunc m_CountRefsFunc;

        public int DebugServerQueryInterface(ref IntPtr ppv)
        {
            if(m_DebugServerQueryInterfaceFunc==null){
                var fp = GetFunctionPointer(8);
                m_DebugServerQueryInterfaceFunc = (DebugServerQueryInterfaceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DebugServerQueryInterfaceFunc));
            } 
            return  m_DebugServerQueryInterfaceFunc(m_ptr, ref ppv);
        }
        delegate int DebugServerQueryInterfaceFunc(IntPtr self, ref IntPtr ppv);
        DebugServerQueryInterfaceFunc m_DebugServerQueryInterfaceFunc;

        public void DebugServerRelease(IntPtr pv)
        {
            if(m_DebugServerReleaseFunc==null){
                var fp = GetFunctionPointer(9);
                m_DebugServerReleaseFunc = (DebugServerReleaseFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DebugServerReleaseFunc));
            } 
             m_DebugServerReleaseFunc(m_ptr, pv);
        }
        delegate void DebugServerReleaseFunc(IntPtr self, IntPtr pv);
        DebugServerReleaseFunc m_DebugServerReleaseFunc;

    }
}
