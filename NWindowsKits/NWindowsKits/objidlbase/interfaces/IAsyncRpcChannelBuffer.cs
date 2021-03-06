// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/objidlbase.h:2790
    public class IAsyncRpcChannelBuffer : IRpcChannelBuffer2
    {
        static Guid s_uuid = new Guid("a5029fb6-3c34-11d1-9c99-00c04fb998aa");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int Send(ref RPCOLEMESSAGE pMsg, IntPtr pSync, IntPtr pulStatus)
        {
            if(m_SendFunc==null){
                var fp = GetFunctionPointer(9);
                m_SendFunc = (SendFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SendFunc));
            } 
            return  m_SendFunc(m_ptr, ref pMsg, pSync, pulStatus);
        }
        delegate int SendFunc(IntPtr self, ref RPCOLEMESSAGE pMsg, IntPtr pSync, IntPtr pulStatus);
        SendFunc m_SendFunc;

        public int Receive(ref RPCOLEMESSAGE pMsg, IntPtr pulStatus)
        {
            if(m_ReceiveFunc==null){
                var fp = GetFunctionPointer(10);
                m_ReceiveFunc = (ReceiveFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReceiveFunc));
            } 
            return  m_ReceiveFunc(m_ptr, ref pMsg, pulStatus);
        }
        delegate int ReceiveFunc(IntPtr self, ref RPCOLEMESSAGE pMsg, IntPtr pulStatus);
        ReceiveFunc m_ReceiveFunc;

        public int GetDestCtxEx(ref RPCOLEMESSAGE pMsg, ref uint pdwDestContext, ref IntPtr ppvDestContext)
        {
            if(m_GetDestCtxExFunc==null){
                var fp = GetFunctionPointer(11);
                m_GetDestCtxExFunc = (GetDestCtxExFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDestCtxExFunc));
            } 
            return  m_GetDestCtxExFunc(m_ptr, ref pMsg, ref pdwDestContext, ref ppvDestContext);
        }
        delegate int GetDestCtxExFunc(IntPtr self, ref RPCOLEMESSAGE pMsg, ref uint pdwDestContext, ref IntPtr ppvDestContext);
        GetDestCtxExFunc m_GetDestCtxExFunc;

    }
}
