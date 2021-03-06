// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/oleidl.h:2147
    public class IOleInPlaceActiveObject : IOleWindow
    {
        static Guid s_uuid = new Guid("00000117-0000-0000-c000-000000000046");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int TranslateAcceleratorA(ref MSG lpmsg)
        {
            if(m_TranslateAcceleratorAFunc==null){
                var fp = GetFunctionPointer(5);
                m_TranslateAcceleratorAFunc = (TranslateAcceleratorAFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(TranslateAcceleratorAFunc));
            } 
            return  m_TranslateAcceleratorAFunc(m_ptr, ref lpmsg);
        }
        delegate int TranslateAcceleratorAFunc(IntPtr self, ref MSG lpmsg);
        TranslateAcceleratorAFunc m_TranslateAcceleratorAFunc;

        public int OnFrameWindowActivate(int fActivate)
        {
            if(m_OnFrameWindowActivateFunc==null){
                var fp = GetFunctionPointer(6);
                m_OnFrameWindowActivateFunc = (OnFrameWindowActivateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OnFrameWindowActivateFunc));
            } 
            return  m_OnFrameWindowActivateFunc(m_ptr, fActivate);
        }
        delegate int OnFrameWindowActivateFunc(IntPtr self, int fActivate);
        OnFrameWindowActivateFunc m_OnFrameWindowActivateFunc;

        public int OnDocWindowActivate(int fActivate)
        {
            if(m_OnDocWindowActivateFunc==null){
                var fp = GetFunctionPointer(7);
                m_OnDocWindowActivateFunc = (OnDocWindowActivateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OnDocWindowActivateFunc));
            } 
            return  m_OnDocWindowActivateFunc(m_ptr, fActivate);
        }
        delegate int OnDocWindowActivateFunc(IntPtr self, int fActivate);
        OnDocWindowActivateFunc m_OnDocWindowActivateFunc;

        public int ResizeBorder(ref RECT prcBorder, IntPtr pUIWindow, int fFrameWindow)
        {
            if(m_ResizeBorderFunc==null){
                var fp = GetFunctionPointer(8);
                m_ResizeBorderFunc = (ResizeBorderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ResizeBorderFunc));
            } 
            return  m_ResizeBorderFunc(m_ptr, ref prcBorder, pUIWindow, fFrameWindow);
        }
        delegate int ResizeBorderFunc(IntPtr self, ref RECT prcBorder, IntPtr pUIWindow, int fFrameWindow);
        ResizeBorderFunc m_ResizeBorderFunc;

        public int EnableModeless(int fEnable)
        {
            if(m_EnableModelessFunc==null){
                var fp = GetFunctionPointer(9);
                m_EnableModelessFunc = (EnableModelessFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(EnableModelessFunc));
            } 
            return  m_EnableModelessFunc(m_ptr, fEnable);
        }
        delegate int EnableModelessFunc(IntPtr self, int fEnable);
        EnableModelessFunc m_EnableModelessFunc;

    }
}
