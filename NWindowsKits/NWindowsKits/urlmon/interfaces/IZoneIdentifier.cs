// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/urlmon.h:7793
    public class IZoneIdentifier : IUnknown
    {
        static Guid s_uuid = new Guid("cd45f185-1b21-48e2-967b-ead743a8914e");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int GetId(ref uint pdwZone)
        {
            if(m_GetIdFunc==null){
                var fp = GetFunctionPointer(3);
                m_GetIdFunc = (GetIdFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetIdFunc));
            } 
            return  m_GetIdFunc(m_ptr, ref pdwZone);
        }
        delegate int GetIdFunc(IntPtr self, ref uint pdwZone);
        GetIdFunc m_GetIdFunc;

        public int SetId(uint dwZone)
        {
            if(m_SetIdFunc==null){
                var fp = GetFunctionPointer(4);
                m_SetIdFunc = (SetIdFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetIdFunc));
            } 
            return  m_SetIdFunc(m_ptr, dwZone);
        }
        delegate int SetIdFunc(IntPtr self, uint dwZone);
        SetIdFunc m_SetIdFunc;

        public int Remove()
        {
            if(m_RemoveFunc==null){
                var fp = GetFunctionPointer(5);
                m_RemoveFunc = (RemoveFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RemoveFunc));
            } 
            return  m_RemoveFunc(m_ptr);
        }
        delegate int RemoveFunc(IntPtr self);
        RemoveFunc m_RemoveFunc;

    }
}
