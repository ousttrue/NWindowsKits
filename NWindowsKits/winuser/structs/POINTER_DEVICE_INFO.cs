// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/winuser.h:15304
    [StructLayout(LayoutKind.Sequential)]
    public struct POINTER_DEVICE_INFO // 1
    {
        public uint displayOrientation;
        public IntPtr device;
        public POINTER_DEVICE_TYPE pointerDeviceType;
        public HMONITOR monitor;
        public uint startingCursorId;
        public ushort maxActiveContacts;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 520)] public ushort[] productString;
    }
}