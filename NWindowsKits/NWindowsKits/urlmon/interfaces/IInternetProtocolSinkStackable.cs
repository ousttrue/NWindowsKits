// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/urlmon.h:5894
    public class IInternetProtocolSinkStackable : IUnknown
    {
        static Guid s_uuid = new Guid("79eac9f0-baf9-11ce-8c82-00aa004ba90b");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int SwitchSink(IntPtr pOIProtSink)
        {
            if(m_SwitchSinkFunc==null){
                var fp = GetFunctionPointer(3);
                m_SwitchSinkFunc = (SwitchSinkFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SwitchSinkFunc));
            } 
            return  m_SwitchSinkFunc(m_ptr, pOIProtSink);
        }
        delegate int SwitchSinkFunc(IntPtr self, IntPtr pOIProtSink);
        SwitchSinkFunc m_SwitchSinkFunc;

        public int CommitSwitch()
        {
            if(m_CommitSwitchFunc==null){
                var fp = GetFunctionPointer(4);
                m_CommitSwitchFunc = (CommitSwitchFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CommitSwitchFunc));
            } 
            return  m_CommitSwitchFunc(m_ptr);
        }
        delegate int CommitSwitchFunc(IntPtr self);
        CommitSwitchFunc m_CommitSwitchFunc;

        public int RollbackSwitch()
        {
            if(m_RollbackSwitchFunc==null){
                var fp = GetFunctionPointer(5);
                m_RollbackSwitchFunc = (RollbackSwitchFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RollbackSwitchFunc));
            } 
            return  m_RollbackSwitchFunc(m_ptr);
        }
        delegate int RollbackSwitchFunc(IntPtr self);
        RollbackSwitchFunc m_RollbackSwitchFunc;

    }
}
