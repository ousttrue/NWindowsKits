// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/ObjIdl.h:14301
    public class IInitializeSpy : IUnknown // 1
    {
        static Guid s_uuid = new Guid("00000034-0000-0000-c000-000000000046");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int PreInitialize(uint dwCoInit, uint dwCurThreadAptRefs)
        {
            if(m_PreInitializeFunc==null){
                var fp = GetFunctionPointer(3);
                m_PreInitializeFunc = (PreInitializeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(PreInitializeFunc));
            } 
            return  m_PreInitializeFunc(m_ptr, dwCoInit, dwCurThreadAptRefs);
        }
        delegate int PreInitializeFunc(IntPtr self, uint dwCoInit, uint dwCurThreadAptRefs);
        PreInitializeFunc m_PreInitializeFunc;

        public int PostInitialize(int hrCoInit, uint dwCoInit, uint dwNewThreadAptRefs)
        {
            if(m_PostInitializeFunc==null){
                var fp = GetFunctionPointer(4);
                m_PostInitializeFunc = (PostInitializeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(PostInitializeFunc));
            } 
            return  m_PostInitializeFunc(m_ptr, hrCoInit, dwCoInit, dwNewThreadAptRefs);
        }
        delegate int PostInitializeFunc(IntPtr self, int hrCoInit, uint dwCoInit, uint dwNewThreadAptRefs);
        PostInitializeFunc m_PostInitializeFunc;

        public int PreUninitialize(uint dwCurThreadAptRefs)
        {
            if(m_PreUninitializeFunc==null){
                var fp = GetFunctionPointer(5);
                m_PreUninitializeFunc = (PreUninitializeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(PreUninitializeFunc));
            } 
            return  m_PreUninitializeFunc(m_ptr, dwCurThreadAptRefs);
        }
        delegate int PreUninitializeFunc(IntPtr self, uint dwCurThreadAptRefs);
        PreUninitializeFunc m_PreUninitializeFunc;

        public int PostUninitialize(uint dwNewThreadAptRefs)
        {
            if(m_PostUninitializeFunc==null){
                var fp = GetFunctionPointer(6);
                m_PostUninitializeFunc = (PostUninitializeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(PostUninitializeFunc));
            } 
            return  m_PostUninitializeFunc(m_ptr, dwNewThreadAptRefs);
        }
        delegate int PostUninitializeFunc(IntPtr self, uint dwNewThreadAptRefs);
        PostUninitializeFunc m_PostUninitializeFunc;

    }
}
