// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/WinUser.h:7826
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct MENUITEMINFOA // 2
    {
        public uint cbSize;
        public uint fMask;
        public uint fType;
        public uint fState;
        public uint wID;
        public HMENU hSubMenu;
        public HBITMAP hbmpChecked;
        public HBITMAP hbmpUnchecked;
        public ulong dwItemData;
        public IntPtr dwTypeData;
        public uint cch;
        public HBITMAP hbmpItem;
    }
}
