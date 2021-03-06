// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/shared/dxgi1_2.h:1234
    public class IDXGISwapChain1 : IDXGISwapChain
    {
        static Guid s_uuid = new Guid("790a45f7-0d42-4876-983a-0a55cfe6f4aa");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int GetDesc1(ref DXGI_SWAP_CHAIN_DESC1 pDesc)
        {
            if(m_GetDesc1Func==null){
                var fp = GetFunctionPointer(18);
                m_GetDesc1Func = (GetDesc1Func)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDesc1Func));
            } 
            return  m_GetDesc1Func(m_ptr, ref pDesc);
        }
        delegate int GetDesc1Func(IntPtr self, ref DXGI_SWAP_CHAIN_DESC1 pDesc);
        GetDesc1Func m_GetDesc1Func;

        public int GetFullscreenDesc(ref DXGI_SWAP_CHAIN_FULLSCREEN_DESC pDesc)
        {
            if(m_GetFullscreenDescFunc==null){
                var fp = GetFunctionPointer(19);
                m_GetFullscreenDescFunc = (GetFullscreenDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFullscreenDescFunc));
            } 
            return  m_GetFullscreenDescFunc(m_ptr, ref pDesc);
        }
        delegate int GetFullscreenDescFunc(IntPtr self, ref DXGI_SWAP_CHAIN_FULLSCREEN_DESC pDesc);
        GetFullscreenDescFunc m_GetFullscreenDescFunc;

        public int GetHwnd(ref HWND pHwnd)
        {
            if(m_GetHwndFunc==null){
                var fp = GetFunctionPointer(20);
                m_GetHwndFunc = (GetHwndFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetHwndFunc));
            } 
            return  m_GetHwndFunc(m_ptr, ref pHwnd);
        }
        delegate int GetHwndFunc(IntPtr self, ref HWND pHwnd);
        GetHwndFunc m_GetHwndFunc;

        public int GetCoreWindow(ref Guid refiid, ref IntPtr ppUnk)
        {
            if(m_GetCoreWindowFunc==null){
                var fp = GetFunctionPointer(21);
                m_GetCoreWindowFunc = (GetCoreWindowFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetCoreWindowFunc));
            } 
            return  m_GetCoreWindowFunc(m_ptr, ref refiid, ref ppUnk);
        }
        delegate int GetCoreWindowFunc(IntPtr self, ref Guid refiid, ref IntPtr ppUnk);
        GetCoreWindowFunc m_GetCoreWindowFunc;

        public int Present1(uint SyncInterval, uint PresentFlags, ref DXGI_PRESENT_PARAMETERS pPresentParameters)
        {
            if(m_Present1Func==null){
                var fp = GetFunctionPointer(22);
                m_Present1Func = (Present1Func)Marshal.GetDelegateForFunctionPointer(fp, typeof(Present1Func));
            } 
            return  m_Present1Func(m_ptr, SyncInterval, PresentFlags, ref pPresentParameters);
        }
        delegate int Present1Func(IntPtr self, uint SyncInterval, uint PresentFlags, ref DXGI_PRESENT_PARAMETERS pPresentParameters);
        Present1Func m_Present1Func;

        public int IsTemporaryMonoSupported()
        {
            if(m_IsTemporaryMonoSupportedFunc==null){
                var fp = GetFunctionPointer(23);
                m_IsTemporaryMonoSupportedFunc = (IsTemporaryMonoSupportedFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IsTemporaryMonoSupportedFunc));
            } 
            return  m_IsTemporaryMonoSupportedFunc(m_ptr);
        }
        delegate int IsTemporaryMonoSupportedFunc(IntPtr self);
        IsTemporaryMonoSupportedFunc m_IsTemporaryMonoSupportedFunc;

        public int GetRestrictToOutput(ref IntPtr ppRestrictToOutput)
        {
            if(m_GetRestrictToOutputFunc==null){
                var fp = GetFunctionPointer(24);
                m_GetRestrictToOutputFunc = (GetRestrictToOutputFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetRestrictToOutputFunc));
            } 
            return  m_GetRestrictToOutputFunc(m_ptr, ref ppRestrictToOutput);
        }
        delegate int GetRestrictToOutputFunc(IntPtr self, ref IntPtr ppRestrictToOutput);
        GetRestrictToOutputFunc m_GetRestrictToOutputFunc;

        public int SetBackgroundColor(IntPtr pColor)
        {
            if(m_SetBackgroundColorFunc==null){
                var fp = GetFunctionPointer(25);
                m_SetBackgroundColorFunc = (SetBackgroundColorFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetBackgroundColorFunc));
            } 
            return  m_SetBackgroundColorFunc(m_ptr, pColor);
        }
        delegate int SetBackgroundColorFunc(IntPtr self, IntPtr pColor);
        SetBackgroundColorFunc m_SetBackgroundColorFunc;

        public int GetBackgroundColor(IntPtr pColor)
        {
            if(m_GetBackgroundColorFunc==null){
                var fp = GetFunctionPointer(26);
                m_GetBackgroundColorFunc = (GetBackgroundColorFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetBackgroundColorFunc));
            } 
            return  m_GetBackgroundColorFunc(m_ptr, pColor);
        }
        delegate int GetBackgroundColorFunc(IntPtr self, IntPtr pColor);
        GetBackgroundColorFunc m_GetBackgroundColorFunc;

        public int SetRotation(DXGI_MODE_ROTATION Rotation)
        {
            if(m_SetRotationFunc==null){
                var fp = GetFunctionPointer(27);
                m_SetRotationFunc = (SetRotationFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetRotationFunc));
            } 
            return  m_SetRotationFunc(m_ptr, Rotation);
        }
        delegate int SetRotationFunc(IntPtr self, DXGI_MODE_ROTATION Rotation);
        SetRotationFunc m_SetRotationFunc;

        public int GetRotation(ref DXGI_MODE_ROTATION pRotation)
        {
            if(m_GetRotationFunc==null){
                var fp = GetFunctionPointer(28);
                m_GetRotationFunc = (GetRotationFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetRotationFunc));
            } 
            return  m_GetRotationFunc(m_ptr, ref pRotation);
        }
        delegate int GetRotationFunc(IntPtr self, ref DXGI_MODE_ROTATION pRotation);
        GetRotationFunc m_GetRotationFunc;

    }
}
