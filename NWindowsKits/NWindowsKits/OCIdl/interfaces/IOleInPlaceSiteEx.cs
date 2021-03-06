// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/OCIdl.h:4224
    public class IOleInPlaceSiteEx : IOleInPlaceSite
    {
        static Guid s_uuid = new Guid("9c2cad80-3424-11cf-b670-00aa004cd6d8");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int OnInPlaceActivateEx(ref int pfNoRedraw, uint dwFlags)
        {
            if(m_OnInPlaceActivateExFunc==null){
                var fp = GetFunctionPointer(15);
                m_OnInPlaceActivateExFunc = (OnInPlaceActivateExFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OnInPlaceActivateExFunc));
            } 
            return  m_OnInPlaceActivateExFunc(m_ptr, ref pfNoRedraw, dwFlags);
        }
        delegate int OnInPlaceActivateExFunc(IntPtr self, ref int pfNoRedraw, uint dwFlags);
        OnInPlaceActivateExFunc m_OnInPlaceActivateExFunc;

        public int OnInPlaceDeactivateEx(int fNoRedraw)
        {
            if(m_OnInPlaceDeactivateExFunc==null){
                var fp = GetFunctionPointer(16);
                m_OnInPlaceDeactivateExFunc = (OnInPlaceDeactivateExFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OnInPlaceDeactivateExFunc));
            } 
            return  m_OnInPlaceDeactivateExFunc(m_ptr, fNoRedraw);
        }
        delegate int OnInPlaceDeactivateExFunc(IntPtr self, int fNoRedraw);
        OnInPlaceDeactivateExFunc m_OnInPlaceDeactivateExFunc;

        public int RequestUIActivate()
        {
            if(m_RequestUIActivateFunc==null){
                var fp = GetFunctionPointer(17);
                m_RequestUIActivateFunc = (RequestUIActivateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RequestUIActivateFunc));
            } 
            return  m_RequestUIActivateFunc(m_ptr);
        }
        delegate int RequestUIActivateFunc(IntPtr self);
        RequestUIActivateFunc m_RequestUIActivateFunc;

    }
}
