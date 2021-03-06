// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/d3d11.h:2214
    public class ID3D11Resource : ID3D11DeviceChild
    {
        static Guid s_uuid = new Guid("dc8e63f3-d12b-4952-b47b-5e45026a862d");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public void GetType(ref D3D11_RESOURCE_DIMENSION pResourceDimension)
        {
            if(m_GetTypeFunc==null){
                var fp = GetFunctionPointer(7);
                m_GetTypeFunc = (GetTypeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetTypeFunc));
            } 
             m_GetTypeFunc(m_ptr, ref pResourceDimension);
        }
        delegate void GetTypeFunc(IntPtr self, ref D3D11_RESOURCE_DIMENSION pResourceDimension);
        GetTypeFunc m_GetTypeFunc;

        public void SetEvictionPriority(uint EvictionPriority)
        {
            if(m_SetEvictionPriorityFunc==null){
                var fp = GetFunctionPointer(8);
                m_SetEvictionPriorityFunc = (SetEvictionPriorityFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetEvictionPriorityFunc));
            } 
             m_SetEvictionPriorityFunc(m_ptr, EvictionPriority);
        }
        delegate void SetEvictionPriorityFunc(IntPtr self, uint EvictionPriority);
        SetEvictionPriorityFunc m_SetEvictionPriorityFunc;

        public uint GetEvictionPriority()
        {
            if(m_GetEvictionPriorityFunc==null){
                var fp = GetFunctionPointer(9);
                m_GetEvictionPriorityFunc = (GetEvictionPriorityFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetEvictionPriorityFunc));
            } 
            return  m_GetEvictionPriorityFunc(m_ptr);
        }
        delegate uint GetEvictionPriorityFunc(IntPtr self);
        GetEvictionPriorityFunc m_GetEvictionPriorityFunc;

    }
}
