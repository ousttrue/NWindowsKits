// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/OCIdl.h:5305
    public class IEnumOleUndoUnits : IUnknown // 2
    {
        static Guid s_uuid = new Guid("b3e7c340-ef97-11ce-9bc9-00aa00608e01");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int Next(uint cElt, ref IntPtr rgElt, IntPtr pcEltFetched)
        {
            if(m_NextFunc==null){
                var fp = GetFunctionPointer(3);
                m_NextFunc = (NextFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(NextFunc));
            } 
            
            return  m_NextFunc(m_ptr, cElt, ref rgElt, pcEltFetched);
        }
        delegate int NextFunc(IntPtr self, uint cElt, ref IntPtr rgElt, IntPtr pcEltFetched);
        NextFunc m_NextFunc;

        public int Skip(uint cElt)
        {
            if(m_SkipFunc==null){
                var fp = GetFunctionPointer(4);
                m_SkipFunc = (SkipFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SkipFunc));
            } 
            
            return  m_SkipFunc(m_ptr, cElt);
        }
        delegate int SkipFunc(IntPtr self, uint cElt);
        SkipFunc m_SkipFunc;

        public int Reset()
        {
            if(m_ResetFunc==null){
                var fp = GetFunctionPointer(5);
                m_ResetFunc = (ResetFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ResetFunc));
            } 
            
            return  m_ResetFunc(m_ptr);
        }
        delegate int ResetFunc(IntPtr self);
        ResetFunc m_ResetFunc;

        public int Clone(ref IntPtr ppEnum)
        {
            if(m_CloneFunc==null){
                var fp = GetFunctionPointer(6);
                m_CloneFunc = (CloneFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CloneFunc));
            } 
            
            return  m_CloneFunc(m_ptr, ref ppEnum);
        }
        delegate int CloneFunc(IntPtr self, ref IntPtr ppEnum);
        CloneFunc m_CloneFunc;

    }
}