// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/shared/dxgi1_2.h:1585
    public class IDXGIFactory2 : IDXGIFactory1 // 1
    {
        static Guid s_uuid = new Guid("50c83a1c-e072-4c48-87b0-3630fa36a6d0");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int IsWindowedStereoEnabled()
        {
            if(m_IsWindowedStereoEnabledFunc==null){
                var fp = GetFunctionPointer(14);
                m_IsWindowedStereoEnabledFunc = (IsWindowedStereoEnabledFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IsWindowedStereoEnabledFunc));
            } 
            return  m_IsWindowedStereoEnabledFunc(m_ptr);
        }
        delegate int IsWindowedStereoEnabledFunc(IntPtr self);
        IsWindowedStereoEnabledFunc m_IsWindowedStereoEnabledFunc;

        public int CreateSwapChainForHwnd(IntPtr pDevice, HWND hWnd, ref DXGI_SWAP_CHAIN_DESC1 pDesc, ref DXGI_SWAP_CHAIN_FULLSCREEN_DESC pFullscreenDesc, IntPtr pRestrictToOutput, ref IntPtr ppSwapChain)
        {
            if(m_CreateSwapChainForHwndFunc==null){
                var fp = GetFunctionPointer(15);
                m_CreateSwapChainForHwndFunc = (CreateSwapChainForHwndFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateSwapChainForHwndFunc));
            } 
            return  m_CreateSwapChainForHwndFunc(m_ptr, pDevice, hWnd, ref pDesc, ref pFullscreenDesc, pRestrictToOutput, ref ppSwapChain);
        }
        delegate int CreateSwapChainForHwndFunc(IntPtr self, IntPtr pDevice, HWND hWnd, ref DXGI_SWAP_CHAIN_DESC1 pDesc, ref DXGI_SWAP_CHAIN_FULLSCREEN_DESC pFullscreenDesc, IntPtr pRestrictToOutput, ref IntPtr ppSwapChain);
        CreateSwapChainForHwndFunc m_CreateSwapChainForHwndFunc;

        public int CreateSwapChainForCoreWindow(IntPtr pDevice, IntPtr pWindow, ref DXGI_SWAP_CHAIN_DESC1 pDesc, IntPtr pRestrictToOutput, ref IntPtr ppSwapChain)
        {
            if(m_CreateSwapChainForCoreWindowFunc==null){
                var fp = GetFunctionPointer(16);
                m_CreateSwapChainForCoreWindowFunc = (CreateSwapChainForCoreWindowFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateSwapChainForCoreWindowFunc));
            } 
            return  m_CreateSwapChainForCoreWindowFunc(m_ptr, pDevice, pWindow, ref pDesc, pRestrictToOutput, ref ppSwapChain);
        }
        delegate int CreateSwapChainForCoreWindowFunc(IntPtr self, IntPtr pDevice, IntPtr pWindow, ref DXGI_SWAP_CHAIN_DESC1 pDesc, IntPtr pRestrictToOutput, ref IntPtr ppSwapChain);
        CreateSwapChainForCoreWindowFunc m_CreateSwapChainForCoreWindowFunc;

        public int GetSharedResourceAdapterLuid(IntPtr hResource, ref LUID pLuid)
        {
            if(m_GetSharedResourceAdapterLuidFunc==null){
                var fp = GetFunctionPointer(17);
                m_GetSharedResourceAdapterLuidFunc = (GetSharedResourceAdapterLuidFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetSharedResourceAdapterLuidFunc));
            } 
            return  m_GetSharedResourceAdapterLuidFunc(m_ptr, hResource, ref pLuid);
        }
        delegate int GetSharedResourceAdapterLuidFunc(IntPtr self, IntPtr hResource, ref LUID pLuid);
        GetSharedResourceAdapterLuidFunc m_GetSharedResourceAdapterLuidFunc;

        public int RegisterStereoStatusWindow(HWND WindowHandle, uint wMsg, ref uint pdwCookie)
        {
            if(m_RegisterStereoStatusWindowFunc==null){
                var fp = GetFunctionPointer(18);
                m_RegisterStereoStatusWindowFunc = (RegisterStereoStatusWindowFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RegisterStereoStatusWindowFunc));
            } 
            return  m_RegisterStereoStatusWindowFunc(m_ptr, WindowHandle, wMsg, ref pdwCookie);
        }
        delegate int RegisterStereoStatusWindowFunc(IntPtr self, HWND WindowHandle, uint wMsg, ref uint pdwCookie);
        RegisterStereoStatusWindowFunc m_RegisterStereoStatusWindowFunc;

        public int RegisterStereoStatusEvent(IntPtr hEvent, ref uint pdwCookie)
        {
            if(m_RegisterStereoStatusEventFunc==null){
                var fp = GetFunctionPointer(19);
                m_RegisterStereoStatusEventFunc = (RegisterStereoStatusEventFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RegisterStereoStatusEventFunc));
            } 
            return  m_RegisterStereoStatusEventFunc(m_ptr, hEvent, ref pdwCookie);
        }
        delegate int RegisterStereoStatusEventFunc(IntPtr self, IntPtr hEvent, ref uint pdwCookie);
        RegisterStereoStatusEventFunc m_RegisterStereoStatusEventFunc;

        public void UnregisterStereoStatus(uint dwCookie)
        {
            if(m_UnregisterStereoStatusFunc==null){
                var fp = GetFunctionPointer(20);
                m_UnregisterStereoStatusFunc = (UnregisterStereoStatusFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(UnregisterStereoStatusFunc));
            } 
             m_UnregisterStereoStatusFunc(m_ptr, dwCookie);
        }
        delegate void UnregisterStereoStatusFunc(IntPtr self, uint dwCookie);
        UnregisterStereoStatusFunc m_UnregisterStereoStatusFunc;

        public int RegisterOcclusionStatusWindow(HWND WindowHandle, uint wMsg, ref uint pdwCookie)
        {
            if(m_RegisterOcclusionStatusWindowFunc==null){
                var fp = GetFunctionPointer(21);
                m_RegisterOcclusionStatusWindowFunc = (RegisterOcclusionStatusWindowFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RegisterOcclusionStatusWindowFunc));
            } 
            return  m_RegisterOcclusionStatusWindowFunc(m_ptr, WindowHandle, wMsg, ref pdwCookie);
        }
        delegate int RegisterOcclusionStatusWindowFunc(IntPtr self, HWND WindowHandle, uint wMsg, ref uint pdwCookie);
        RegisterOcclusionStatusWindowFunc m_RegisterOcclusionStatusWindowFunc;

        public int RegisterOcclusionStatusEvent(IntPtr hEvent, ref uint pdwCookie)
        {
            if(m_RegisterOcclusionStatusEventFunc==null){
                var fp = GetFunctionPointer(22);
                m_RegisterOcclusionStatusEventFunc = (RegisterOcclusionStatusEventFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RegisterOcclusionStatusEventFunc));
            } 
            return  m_RegisterOcclusionStatusEventFunc(m_ptr, hEvent, ref pdwCookie);
        }
        delegate int RegisterOcclusionStatusEventFunc(IntPtr self, IntPtr hEvent, ref uint pdwCookie);
        RegisterOcclusionStatusEventFunc m_RegisterOcclusionStatusEventFunc;

        public void UnregisterOcclusionStatus(uint dwCookie)
        {
            if(m_UnregisterOcclusionStatusFunc==null){
                var fp = GetFunctionPointer(23);
                m_UnregisterOcclusionStatusFunc = (UnregisterOcclusionStatusFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(UnregisterOcclusionStatusFunc));
            } 
             m_UnregisterOcclusionStatusFunc(m_ptr, dwCookie);
        }
        delegate void UnregisterOcclusionStatusFunc(IntPtr self, uint dwCookie);
        UnregisterOcclusionStatusFunc m_UnregisterOcclusionStatusFunc;

        public int CreateSwapChainForComposition(IntPtr pDevice, ref DXGI_SWAP_CHAIN_DESC1 pDesc, IntPtr pRestrictToOutput, ref IntPtr ppSwapChain)
        {
            if(m_CreateSwapChainForCompositionFunc==null){
                var fp = GetFunctionPointer(24);
                m_CreateSwapChainForCompositionFunc = (CreateSwapChainForCompositionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateSwapChainForCompositionFunc));
            } 
            return  m_CreateSwapChainForCompositionFunc(m_ptr, pDevice, ref pDesc, pRestrictToOutput, ref ppSwapChain);
        }
        delegate int CreateSwapChainForCompositionFunc(IntPtr self, IntPtr pDevice, ref DXGI_SWAP_CHAIN_DESC1 pDesc, IntPtr pRestrictToOutput, ref IntPtr ppSwapChain);
        CreateSwapChainForCompositionFunc m_CreateSwapChainForCompositionFunc;

    }
}
