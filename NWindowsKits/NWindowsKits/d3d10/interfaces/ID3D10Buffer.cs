// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/d3d10.h:1691
    public class ID3D10Buffer : ID3D10Resource // 1
    {
        static Guid s_uuid = new Guid("9b7e4c02-342c-4106-a19f-4f2704f689f0");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int Map(D3D10_MAP MapType, uint MapFlags, ref IntPtr ppData)
        {
            if(m_MapFunc==null){
                var fp = GetFunctionPointer(10);
                m_MapFunc = (MapFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(MapFunc));
            } 
            return  m_MapFunc(m_ptr, MapType, MapFlags, ref ppData);
        }
        delegate int MapFunc(IntPtr self, D3D10_MAP MapType, uint MapFlags, ref IntPtr ppData);
        MapFunc m_MapFunc;

        public void Unmap()
        {
            if(m_UnmapFunc==null){
                var fp = GetFunctionPointer(11);
                m_UnmapFunc = (UnmapFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(UnmapFunc));
            } 
             m_UnmapFunc(m_ptr);
        }
        delegate void UnmapFunc(IntPtr self);
        UnmapFunc m_UnmapFunc;

        public void GetDesc(ref D3D10_BUFFER_DESC pDesc)
        {
            if(m_GetDescFunc==null){
                var fp = GetFunctionPointer(12);
                m_GetDescFunc = (GetDescFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescFunc));
            } 
             m_GetDescFunc(m_ptr, ref pDesc);
        }
        delegate void GetDescFunc(IntPtr self, ref D3D10_BUFFER_DESC pDesc);
        GetDescFunc m_GetDescFunc;

    }
}
