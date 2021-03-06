// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/oleidl.h:2650
    public class IOleInPlaceSite : IOleWindow
    {
        static Guid s_uuid = new Guid("00000119-0000-0000-c000-000000000046");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int CanInPlaceActivate()
        {
            if(m_CanInPlaceActivateFunc==null){
                var fp = GetFunctionPointer(5);
                m_CanInPlaceActivateFunc = (CanInPlaceActivateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CanInPlaceActivateFunc));
            } 
            return  m_CanInPlaceActivateFunc(m_ptr);
        }
        delegate int CanInPlaceActivateFunc(IntPtr self);
        CanInPlaceActivateFunc m_CanInPlaceActivateFunc;

        public int OnInPlaceActivate()
        {
            if(m_OnInPlaceActivateFunc==null){
                var fp = GetFunctionPointer(6);
                m_OnInPlaceActivateFunc = (OnInPlaceActivateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OnInPlaceActivateFunc));
            } 
            return  m_OnInPlaceActivateFunc(m_ptr);
        }
        delegate int OnInPlaceActivateFunc(IntPtr self);
        OnInPlaceActivateFunc m_OnInPlaceActivateFunc;

        public int OnUIActivate()
        {
            if(m_OnUIActivateFunc==null){
                var fp = GetFunctionPointer(7);
                m_OnUIActivateFunc = (OnUIActivateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OnUIActivateFunc));
            } 
            return  m_OnUIActivateFunc(m_ptr);
        }
        delegate int OnUIActivateFunc(IntPtr self);
        OnUIActivateFunc m_OnUIActivateFunc;

        public int GetWindowContext(ref IntPtr ppFrame, ref IntPtr ppDoc, ref RECT lprcPosRect, ref RECT lprcClipRect, ref LPOLEINPLACEFRAMEINFO lpFrameInfo)
        {
            if(m_GetWindowContextFunc==null){
                var fp = GetFunctionPointer(8);
                m_GetWindowContextFunc = (GetWindowContextFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetWindowContextFunc));
            } 
            return  m_GetWindowContextFunc(m_ptr, ref ppFrame, ref ppDoc, ref lprcPosRect, ref lprcClipRect, ref lpFrameInfo);
        }
        delegate int GetWindowContextFunc(IntPtr self, ref IntPtr ppFrame, ref IntPtr ppDoc, ref RECT lprcPosRect, ref RECT lprcClipRect, ref LPOLEINPLACEFRAMEINFO lpFrameInfo);
        GetWindowContextFunc m_GetWindowContextFunc;

        public int Scroll(SIZE scrollExtant)
        {
            if(m_ScrollFunc==null){
                var fp = GetFunctionPointer(9);
                m_ScrollFunc = (ScrollFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ScrollFunc));
            } 
            return  m_ScrollFunc(m_ptr, scrollExtant);
        }
        delegate int ScrollFunc(IntPtr self, SIZE scrollExtant);
        ScrollFunc m_ScrollFunc;

        public int OnUIDeactivate(int fUndoable)
        {
            if(m_OnUIDeactivateFunc==null){
                var fp = GetFunctionPointer(10);
                m_OnUIDeactivateFunc = (OnUIDeactivateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OnUIDeactivateFunc));
            } 
            return  m_OnUIDeactivateFunc(m_ptr, fUndoable);
        }
        delegate int OnUIDeactivateFunc(IntPtr self, int fUndoable);
        OnUIDeactivateFunc m_OnUIDeactivateFunc;

        public int OnInPlaceDeactivate()
        {
            if(m_OnInPlaceDeactivateFunc==null){
                var fp = GetFunctionPointer(11);
                m_OnInPlaceDeactivateFunc = (OnInPlaceDeactivateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OnInPlaceDeactivateFunc));
            } 
            return  m_OnInPlaceDeactivateFunc(m_ptr);
        }
        delegate int OnInPlaceDeactivateFunc(IntPtr self);
        OnInPlaceDeactivateFunc m_OnInPlaceDeactivateFunc;

        public int DiscardUndoState()
        {
            if(m_DiscardUndoStateFunc==null){
                var fp = GetFunctionPointer(12);
                m_DiscardUndoStateFunc = (DiscardUndoStateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DiscardUndoStateFunc));
            } 
            return  m_DiscardUndoStateFunc(m_ptr);
        }
        delegate int DiscardUndoStateFunc(IntPtr self);
        DiscardUndoStateFunc m_DiscardUndoStateFunc;

        public int DeactivateAndUndo()
        {
            if(m_DeactivateAndUndoFunc==null){
                var fp = GetFunctionPointer(13);
                m_DeactivateAndUndoFunc = (DeactivateAndUndoFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DeactivateAndUndoFunc));
            } 
            return  m_DeactivateAndUndoFunc(m_ptr);
        }
        delegate int DeactivateAndUndoFunc(IntPtr self);
        DeactivateAndUndoFunc m_DeactivateAndUndoFunc;

        public int OnPosRectChange(ref RECT lprcPosRect)
        {
            if(m_OnPosRectChangeFunc==null){
                var fp = GetFunctionPointer(14);
                m_OnPosRectChangeFunc = (OnPosRectChangeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OnPosRectChangeFunc));
            } 
            return  m_OnPosRectChangeFunc(m_ptr, ref lprcPosRect);
        }
        delegate int OnPosRectChangeFunc(IntPtr self, ref RECT lprcPosRect);
        OnPosRectChangeFunc m_OnPosRectChangeFunc;

    }
}
