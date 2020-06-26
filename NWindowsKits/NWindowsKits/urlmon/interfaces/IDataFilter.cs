// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/urlmon.h:9721
    public class IDataFilter : IUnknown // 1
    {
        static Guid s_uuid = new Guid("69d14c80-c18e-11d0-a9ce-006097942311");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int DoEncode(uint dwFlags, int lInBufferSize, ref byte pbInBuffer, int lOutBufferSize, ref byte pbOutBuffer, int lInBytesAvailable, ref int plInBytesRead, ref int plOutBytesWritten, uint dwReserved)
        {
            if(m_DoEncodeFunc==null){
                var fp = GetFunctionPointer(3);
                m_DoEncodeFunc = (DoEncodeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DoEncodeFunc));
            } 
            return  m_DoEncodeFunc(m_ptr, dwFlags, lInBufferSize, ref pbInBuffer, lOutBufferSize, ref pbOutBuffer, lInBytesAvailable, ref plInBytesRead, ref plOutBytesWritten, dwReserved);
        }
        delegate int DoEncodeFunc(IntPtr self, uint dwFlags, int lInBufferSize, ref byte pbInBuffer, int lOutBufferSize, ref byte pbOutBuffer, int lInBytesAvailable, ref int plInBytesRead, ref int plOutBytesWritten, uint dwReserved);
        DoEncodeFunc m_DoEncodeFunc;

        public int DoDecode(uint dwFlags, int lInBufferSize, ref byte pbInBuffer, int lOutBufferSize, ref byte pbOutBuffer, int lInBytesAvailable, ref int plInBytesRead, ref int plOutBytesWritten, uint dwReserved)
        {
            if(m_DoDecodeFunc==null){
                var fp = GetFunctionPointer(4);
                m_DoDecodeFunc = (DoDecodeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DoDecodeFunc));
            } 
            return  m_DoDecodeFunc(m_ptr, dwFlags, lInBufferSize, ref pbInBuffer, lOutBufferSize, ref pbOutBuffer, lInBytesAvailable, ref plInBytesRead, ref plOutBytesWritten, dwReserved);
        }
        delegate int DoDecodeFunc(IntPtr self, uint dwFlags, int lInBufferSize, ref byte pbInBuffer, int lOutBufferSize, ref byte pbOutBuffer, int lInBytesAvailable, ref int plInBytesRead, ref int plOutBytesWritten, uint dwReserved);
        DoDecodeFunc m_DoDecodeFunc;

        public int SetEncodingLevel(uint dwEncLevel)
        {
            if(m_SetEncodingLevelFunc==null){
                var fp = GetFunctionPointer(5);
                m_SetEncodingLevelFunc = (SetEncodingLevelFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetEncodingLevelFunc));
            } 
            return  m_SetEncodingLevelFunc(m_ptr, dwEncLevel);
        }
        delegate int SetEncodingLevelFunc(IntPtr self, uint dwEncLevel);
        SetEncodingLevelFunc m_SetEncodingLevelFunc;

    }
}
