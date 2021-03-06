// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/shared/dxgi.h:1710
    public class IDXGISwapChain : IDXGIDeviceSubObject
    {
        static Guid s_uuid = new Guid("310d36a0-d2e7-4c0a-aa04-6a9d23b8886a");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int Present(uint SyncInterval, uint Flags)
        {
            if(m_PresentFunc==null){
                var fp = GetFunctionPointer(8);
                m_PresentFunc = (PresentFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(PresentFunc));
            } 
            return  m_PresentFunc(m_ptr, SyncInterval, Flags);
        }
        delegate int PresentFunc(IntPtr self, uint SyncInterval, uint Flags);
        PresentFunc m_PresentFunc;

        public int GetBuffer(uint Buffer, ref Guid riid, ref IntPtr ppSurface)
        {
            if(m_GetBufferFunc==null){
                var fp = GetFunctionPointer(9);
                m_GetBufferFunc = (GetBufferFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetBufferFunc));
            } 
            return  m_GetBufferFunc(m_ptr, Buffer, ref riid, ref ppSurface);
        }
        delegate int GetBufferFunc(IntPtr self, uint Buffer, ref Guid riid, ref IntPtr ppSurface);
        GetBufferFunc m_GetBufferFunc;

        public int SetFullscreenState(int Fullscreen, IntPtr pTarget)
        {
            if(m_SetFullscreenStateFunc==null){
                var fp = GetFunctionPointer(10);
                m_SetFullscreenStateFunc = (SetFullscreenStateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetFullscreenStateFunc));
            } 
            return  m_SetFullscreenStateFunc(m_ptr, Fullscreen, pTarget);
        }
        delegate int SetFullscreenStateFunc(IntPtr self, int Fullscreen, IntPtr pTarget);
        SetFullscreenStateFunc m_SetFullscreenStateFunc;

        public int GetFullscreenState(ref int pFullscreen, ref IntPtr ppTarget)
        {
            if(m_GetFullscreenStateFunc==null){
                var fp = GetFunctionPointer(11);
                m_GetFullscreenStateFunc = (GetFullscreenStateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFullscreenStateFunc));
            } 
            return  m_GetFullscreenStateFunc(m_ptr, ref pFullscreen, ref ppTarget);
        }
        delegate int GetFullscreenStateFunc(IntPtr self, ref int pFullscreen, ref IntPtr ppTarget);
        GetFullscreenStateFunc m_GetFullscreenStateFunc;

        public int GetDesc(ref DXGI_SWAP_CHAIN_DESC pDesc)
        {
            if(m_GetDescFunc==null){
                var fp = GetFunctionPointer(12);
                m_GetDescFunc = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
            } 
            return  m_GetDescFunc(m_ptr, ref pDesc);
        }
        delegate int GetDescFunc(IntPtr self, ref DXGI_SWAP_CHAIN_DESC pDesc);
        GetDescFunc m_GetDescFunc;

        public int ResizeBuffers(uint BufferCount, uint Width, uint Height, DXGI_FORMAT NewFormat, uint SwapChainFlags)
        {
            if(m_ResizeBuffersFunc==null){
                var fp = GetFunctionPointer(13);
                m_ResizeBuffersFunc = (ResizeBuffersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ResizeBuffersFunc));
            } 
            return  m_ResizeBuffersFunc(m_ptr, BufferCount, Width, Height, NewFormat, SwapChainFlags);
        }
        delegate int ResizeBuffersFunc(IntPtr self, uint BufferCount, uint Width, uint Height, DXGI_FORMAT NewFormat, uint SwapChainFlags);
        ResizeBuffersFunc m_ResizeBuffersFunc;

        public int ResizeTarget(ref DXGI_MODE_DESC pNewTargetParameters)
        {
            if(m_ResizeTargetFunc==null){
                var fp = GetFunctionPointer(14);
                m_ResizeTargetFunc = (ResizeTargetFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ResizeTargetFunc));
            } 
            return  m_ResizeTargetFunc(m_ptr, ref pNewTargetParameters);
        }
        delegate int ResizeTargetFunc(IntPtr self, ref DXGI_MODE_DESC pNewTargetParameters);
        ResizeTargetFunc m_ResizeTargetFunc;

        public int GetContainingOutput(ref IntPtr ppOutput)
        {
            if(m_GetContainingOutputFunc==null){
                var fp = GetFunctionPointer(15);
                m_GetContainingOutputFunc = (GetContainingOutputFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetContainingOutputFunc));
            } 
            return  m_GetContainingOutputFunc(m_ptr, ref ppOutput);
        }
        delegate int GetContainingOutputFunc(IntPtr self, ref IntPtr ppOutput);
        GetContainingOutputFunc m_GetContainingOutputFunc;

        public int GetFrameStatistics(ref DXGI_FRAME_STATISTICS pStats)
        {
            if(m_GetFrameStatisticsFunc==null){
                var fp = GetFunctionPointer(16);
                m_GetFrameStatisticsFunc = (GetFrameStatisticsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFrameStatisticsFunc));
            } 
            return  m_GetFrameStatisticsFunc(m_ptr, ref pStats);
        }
        delegate int GetFrameStatisticsFunc(IntPtr self, ref DXGI_FRAME_STATISTICS pStats);
        GetFrameStatisticsFunc m_GetFrameStatisticsFunc;

        public int GetLastPresentCount(ref uint pLastPresentCount)
        {
            if(m_GetLastPresentCountFunc==null){
                var fp = GetFunctionPointer(17);
                m_GetLastPresentCountFunc = (GetLastPresentCountFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetLastPresentCountFunc));
            } 
            return  m_GetLastPresentCountFunc(m_ptr, ref pLastPresentCount);
        }
        delegate int GetLastPresentCountFunc(IntPtr self, ref uint pLastPresentCount);
        GetLastPresentCountFunc m_GetLastPresentCountFunc;

    }
}
