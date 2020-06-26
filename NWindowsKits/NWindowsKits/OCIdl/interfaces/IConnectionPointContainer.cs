// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/OCIdl.h:862
    public class IConnectionPointContainer : IUnknown // 1
    {
        static Guid s_uuid = new Guid("b196b284-bab4-101a-b69c-00aa00341d07");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int EnumConnectionPoints(ref IntPtr ppEnum)
        {
            if(m_EnumConnectionPointsFunc==null){
                var fp = GetFunctionPointer(3);
                m_EnumConnectionPointsFunc = (EnumConnectionPointsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(EnumConnectionPointsFunc));
            } 
            return  m_EnumConnectionPointsFunc(m_ptr, ref ppEnum);
        }
        delegate int EnumConnectionPointsFunc(IntPtr self, ref IntPtr ppEnum);
        EnumConnectionPointsFunc m_EnumConnectionPointsFunc;

        public int FindConnectionPoint(ref Guid riid, ref IntPtr ppCP)
        {
            if(m_FindConnectionPointFunc==null){
                var fp = GetFunctionPointer(4);
                m_FindConnectionPointFunc = (FindConnectionPointFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(FindConnectionPointFunc));
            } 
            return  m_FindConnectionPointFunc(m_ptr, ref riid, ref ppCP);
        }
        delegate int FindConnectionPointFunc(IntPtr self, ref Guid riid, ref IntPtr ppCP);
        FindConnectionPointFunc m_FindConnectionPointFunc;

    }
}
