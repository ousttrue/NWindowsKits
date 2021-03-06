// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/d3dcommon.h:370
    public class ID3D10Blob : IUnknown
    {
        static Guid s_uuid = new Guid("8ba5fb08-5195-40e2-ac58-0d989c3a0102");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public IntPtr GetBufferPointer()
        {
            if(m_GetBufferPointerFunc==null){
                var fp = GetFunctionPointer(3);
                m_GetBufferPointerFunc = (GetBufferPointerFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetBufferPointerFunc));
            } 
            return  m_GetBufferPointerFunc(m_ptr);
        }
        delegate IntPtr GetBufferPointerFunc(IntPtr self);
        GetBufferPointerFunc m_GetBufferPointerFunc;

        public ulong GetBufferSize()
        {
            if(m_GetBufferSizeFunc==null){
                var fp = GetFunctionPointer(4);
                m_GetBufferSizeFunc = (GetBufferSizeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetBufferSizeFunc));
            } 
            return  m_GetBufferSizeFunc(m_ptr);
        }
        delegate ulong GetBufferSizeFunc(IntPtr self);
        GetBufferSizeFunc m_GetBufferSizeFunc;

    }
}
