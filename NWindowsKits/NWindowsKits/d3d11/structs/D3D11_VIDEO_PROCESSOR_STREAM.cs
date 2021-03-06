// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/d3d11.h:10442
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct D3D11_VIDEO_PROCESSOR_STREAM
    {

        public int Enable;
        public uint OutputIndex;
        public uint InputFrameOrField;
        public uint PastFrames;
        public uint FutureFrames;
        public IntPtr ppPastSurfaces;
        public IntPtr pInputSurface;
        public IntPtr ppFutureSurfaces;
        public IntPtr ppPastSurfacesRight;
        public IntPtr pInputSurfaceRight;
        public IntPtr ppFutureSurfacesRight;
    }
}
