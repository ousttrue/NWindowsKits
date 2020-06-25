// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/objidlbase.h:6496
    public class IPipeDouble : IUnknown // 1
    {
        static Guid s_uuid = new Guid("db2f3ace-2f86-11d1-8e04-00c04fb9989a");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int Pull(ref double buf, uint cRequest, IntPtr pcReturned)
        {
            if(m_PullFunc==null){
                var fp = GetFunctionPointer(3);
                m_PullFunc = (PullFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(PullFunc));
            } 
            
            return  m_PullFunc(m_ptr, ref buf, cRequest, pcReturned);
        }
        delegate int PullFunc(IntPtr self, ref double buf, uint cRequest, IntPtr pcReturned);
        PullFunc m_PullFunc;

        public int Push(ref double buf, uint cSent)
        {
            if(m_PushFunc==null){
                var fp = GetFunctionPointer(4);
                m_PushFunc = (PushFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(PushFunc));
            } 
            
            return  m_PushFunc(m_ptr, ref buf, cSent);
        }
        delegate int PushFunc(IntPtr self, ref double buf, uint cSent);
        PushFunc m_PushFunc;

    }
}