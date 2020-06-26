// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/d3d10_1.h:506
    public class ID3D10Device1 : ID3D10Device // 1
    {
        static Guid s_uuid = new Guid("9b7e4c8f-342c-4106-a19f-4f2704f689f0");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int CreateShaderResourceView1(IntPtr pResource, ref D3D10_SHADER_RESOURCE_VIEW_DESC1 pDesc, ref IntPtr ppSRView)
        {
            if(m_CreateShaderResourceView1Func==null){
                var fp = GetFunctionPointer(98);
                m_CreateShaderResourceView1Func = (CreateShaderResourceView1Func)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateShaderResourceView1Func));
            } 
            return  m_CreateShaderResourceView1Func(m_ptr, pResource, ref pDesc, ref ppSRView);
        }
        delegate int CreateShaderResourceView1Func(IntPtr self, IntPtr pResource, ref D3D10_SHADER_RESOURCE_VIEW_DESC1 pDesc, ref IntPtr ppSRView);
        CreateShaderResourceView1Func m_CreateShaderResourceView1Func;

        public int CreateBlendState1(ref D3D10_BLEND_DESC1 pBlendStateDesc, ref IntPtr ppBlendState)
        {
            if(m_CreateBlendState1Func==null){
                var fp = GetFunctionPointer(99);
                m_CreateBlendState1Func = (CreateBlendState1Func)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateBlendState1Func));
            } 
            return  m_CreateBlendState1Func(m_ptr, ref pBlendStateDesc, ref ppBlendState);
        }
        delegate int CreateBlendState1Func(IntPtr self, ref D3D10_BLEND_DESC1 pBlendStateDesc, ref IntPtr ppBlendState);
        CreateBlendState1Func m_CreateBlendState1Func;

        public D3D10_FEATURE_LEVEL1 GetFeatureLevel()
        {
            if(m_GetFeatureLevelFunc==null){
                var fp = GetFunctionPointer(100);
                m_GetFeatureLevelFunc = (GetFeatureLevelFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFeatureLevelFunc));
            } 
            return  m_GetFeatureLevelFunc(m_ptr);
        }
        delegate D3D10_FEATURE_LEVEL1 GetFeatureLevelFunc(IntPtr self);
        GetFeatureLevelFunc m_GetFeatureLevelFunc;

    }
}
