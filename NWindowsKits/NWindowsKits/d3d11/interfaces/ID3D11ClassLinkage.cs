// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/d3d11.h:6999
    public class ID3D11ClassLinkage : ID3D11DeviceChild
    {
        static Guid s_uuid = new Guid("ddf57cba-9543-46e4-a12b-f207a0fe7fed");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int GetClassInstance([MarshalAs(UnmanagedType.LPStr)] string pClassInstanceName, uint InstanceIndex, ref IntPtr ppInstance)
        {
            if(m_GetClassInstanceFunc==null){
                var fp = GetFunctionPointer(7);
                m_GetClassInstanceFunc = (GetClassInstanceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetClassInstanceFunc));
            } 
            return  m_GetClassInstanceFunc(m_ptr, pClassInstanceName, InstanceIndex, ref ppInstance);
        }
        delegate int GetClassInstanceFunc(IntPtr self, [MarshalAs(UnmanagedType.LPStr)] string pClassInstanceName, uint InstanceIndex, ref IntPtr ppInstance);
        GetClassInstanceFunc m_GetClassInstanceFunc;

        public int CreateClassInstance([MarshalAs(UnmanagedType.LPStr)] string pClassTypeName, uint ConstantBufferOffset, uint ConstantVectorOffset, uint TextureOffset, uint SamplerOffset, ref IntPtr ppInstance)
        {
            if(m_CreateClassInstanceFunc==null){
                var fp = GetFunctionPointer(8);
                m_CreateClassInstanceFunc = (CreateClassInstanceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateClassInstanceFunc));
            } 
            return  m_CreateClassInstanceFunc(m_ptr, pClassTypeName, ConstantBufferOffset, ConstantVectorOffset, TextureOffset, SamplerOffset, ref ppInstance);
        }
        delegate int CreateClassInstanceFunc(IntPtr self, [MarshalAs(UnmanagedType.LPStr)] string pClassTypeName, uint ConstantBufferOffset, uint ConstantVectorOffset, uint TextureOffset, uint SamplerOffset, ref IntPtr ppInstance);
        CreateClassInstanceFunc m_CreateClassInstanceFunc;

    }
}
