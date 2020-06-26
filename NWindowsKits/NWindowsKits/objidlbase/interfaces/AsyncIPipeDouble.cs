// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/objidlbase.h:6592
    public class AsyncIPipeDouble : IUnknown // 1
    {
        static Guid s_uuid = new Guid("db2f3acf-2f86-11d1-8e04-00c04fb9989a");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int Begin_Pull(uint cRequest)
        {
            if(m_Begin_PullFunc==null){
                var fp = GetFunctionPointer(3);
                m_Begin_PullFunc = (Begin_PullFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(Begin_PullFunc));
            } 
            return  m_Begin_PullFunc(m_ptr, cRequest);
        }
        delegate int Begin_PullFunc(IntPtr self, uint cRequest);
        Begin_PullFunc m_Begin_PullFunc;

        public int Finish_Pull(ref double buf, IntPtr pcReturned)
        {
            if(m_Finish_PullFunc==null){
                var fp = GetFunctionPointer(4);
                m_Finish_PullFunc = (Finish_PullFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(Finish_PullFunc));
            } 
            return  m_Finish_PullFunc(m_ptr, ref buf, pcReturned);
        }
        delegate int Finish_PullFunc(IntPtr self, ref double buf, IntPtr pcReturned);
        Finish_PullFunc m_Finish_PullFunc;

        public int Begin_Push(ref double buf, uint cSent)
        {
            if(m_Begin_PushFunc==null){
                var fp = GetFunctionPointer(5);
                m_Begin_PushFunc = (Begin_PushFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(Begin_PushFunc));
            } 
            return  m_Begin_PushFunc(m_ptr, ref buf, cSent);
        }
        delegate int Begin_PushFunc(IntPtr self, ref double buf, uint cSent);
        Begin_PushFunc m_Begin_PushFunc;

        public int Finish_Push()
        {
            if(m_Finish_PushFunc==null){
                var fp = GetFunctionPointer(6);
                m_Finish_PushFunc = (Finish_PushFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(Finish_PushFunc));
            } 
            return  m_Finish_PushFunc(m_ptr);
        }
        delegate int Finish_PushFunc(IntPtr self);
        Finish_PushFunc m_Finish_PushFunc;

    }
}
