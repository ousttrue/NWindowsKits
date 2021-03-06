// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/ObjIdl.h:13570
    public class IDirectWriterLock : IUnknown
    {
        static Guid s_uuid = new Guid("0e6d4d92-6738-11cf-9608-00aa00680db4");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int WaitForWriteAccess(uint dwTimeout)
        {
            if(m_WaitForWriteAccessFunc==null){
                var fp = GetFunctionPointer(3);
                m_WaitForWriteAccessFunc = (WaitForWriteAccessFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(WaitForWriteAccessFunc));
            } 
            return  m_WaitForWriteAccessFunc(m_ptr, dwTimeout);
        }
        delegate int WaitForWriteAccessFunc(IntPtr self, uint dwTimeout);
        WaitForWriteAccessFunc m_WaitForWriteAccessFunc;

        public int ReleaseWriteAccess()
        {
            if(m_ReleaseWriteAccessFunc==null){
                var fp = GetFunctionPointer(4);
                m_ReleaseWriteAccessFunc = (ReleaseWriteAccessFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ReleaseWriteAccessFunc));
            } 
            return  m_ReleaseWriteAccessFunc(m_ptr);
        }
        delegate int ReleaseWriteAccessFunc(IntPtr self);
        ReleaseWriteAccessFunc m_ReleaseWriteAccessFunc;

        public int HaveWriteAccess()
        {
            if(m_HaveWriteAccessFunc==null){
                var fp = GetFunctionPointer(5);
                m_HaveWriteAccessFunc = (HaveWriteAccessFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(HaveWriteAccessFunc));
            } 
            return  m_HaveWriteAccessFunc(m_ptr);
        }
        delegate int HaveWriteAccessFunc(IntPtr self);
        HaveWriteAccessFunc m_HaveWriteAccessFunc;

    }
}
