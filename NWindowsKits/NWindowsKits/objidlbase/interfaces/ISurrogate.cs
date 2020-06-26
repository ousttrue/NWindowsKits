// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/objidlbase.h:4606
    public class ISurrogate : IUnknown // 1
    {
        static Guid s_uuid = new Guid("00000022-0000-0000-c000-000000000046");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int LoadDllServer(ref Guid Clsid)
        {
            if(m_LoadDllServerFunc==null){
                var fp = GetFunctionPointer(3);
                m_LoadDllServerFunc = (LoadDllServerFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(LoadDllServerFunc));
            } 
            return  m_LoadDllServerFunc(m_ptr, ref Clsid);
        }
        delegate int LoadDllServerFunc(IntPtr self, ref Guid Clsid);
        LoadDllServerFunc m_LoadDllServerFunc;

        public int FreeSurrogate()
        {
            if(m_FreeSurrogateFunc==null){
                var fp = GetFunctionPointer(4);
                m_FreeSurrogateFunc = (FreeSurrogateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(FreeSurrogateFunc));
            } 
            return  m_FreeSurrogateFunc(m_ptr);
        }
        delegate int FreeSurrogateFunc(IntPtr self);
        FreeSurrogateFunc m_FreeSurrogateFunc;

    }
}
