// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/objidlbase.h:5304
    public class ICancelMethodCalls : IUnknown
    {
        static Guid s_uuid = new Guid("00000029-0000-0000-c000-000000000046");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int Cancel(uint ulSeconds)
        {
            if(m_CancelFunc==null){
                var fp = GetFunctionPointer(3);
                m_CancelFunc = (CancelFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CancelFunc));
            } 
            return  m_CancelFunc(m_ptr, ulSeconds);
        }
        delegate int CancelFunc(IntPtr self, uint ulSeconds);
        CancelFunc m_CancelFunc;

        public int TestCancel()
        {
            if(m_TestCancelFunc==null){
                var fp = GetFunctionPointer(4);
                m_TestCancelFunc = (TestCancelFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(TestCancelFunc));
            } 
            return  m_TestCancelFunc(m_ptr);
        }
        delegate int TestCancelFunc(IntPtr self);
        TestCancelFunc m_TestCancelFunc;

    }
}
