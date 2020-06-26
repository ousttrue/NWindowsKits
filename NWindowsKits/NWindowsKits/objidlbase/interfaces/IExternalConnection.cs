// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/objidlbase.h:1391
    public class IExternalConnection : IUnknown
    {
        static Guid s_uuid = new Guid("00000019-0000-0000-c000-000000000046");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public uint AddConnection(uint extconn, uint reserved)
        {
            if(m_AddConnectionFunc==null){
                var fp = GetFunctionPointer(3);
                m_AddConnectionFunc = (AddConnectionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AddConnectionFunc));
            } 
            return  m_AddConnectionFunc(m_ptr, extconn, reserved);
        }
        delegate uint AddConnectionFunc(IntPtr self, uint extconn, uint reserved);
        AddConnectionFunc m_AddConnectionFunc;

        public uint ReleaseConnection(uint extconn, uint reserved, int fLastReleaseCloses)
        {
            if(m_ReleaseConnectionFunc==null){
                var fp = GetFunctionPointer(4);
                m_ReleaseConnectionFunc = (ReleaseConnectionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReleaseConnectionFunc));
            } 
            return  m_ReleaseConnectionFunc(m_ptr, extconn, reserved, fLastReleaseCloses);
        }
        delegate uint ReleaseConnectionFunc(IntPtr self, uint extconn, uint reserved, int fLastReleaseCloses);
        ReleaseConnectionFunc m_ReleaseConnectionFunc;

    }
}
