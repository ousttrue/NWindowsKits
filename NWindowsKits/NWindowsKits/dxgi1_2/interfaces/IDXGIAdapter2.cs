// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/shared/dxgi1_2.h:2010
    public class IDXGIAdapter2 : IDXGIAdapter1
    {
        static Guid s_uuid = new Guid("0aa1ae0a-fa0e-4b84-8644-e05ff8e5acb5");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int GetDesc2(ref DXGI_ADAPTER_DESC2 pDesc)
        {
            if(m_GetDesc2Func==null){
                var fp = GetFunctionPointer(11);
                m_GetDesc2Func = (GetDesc2Func)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDesc2Func));
            } 
            return  m_GetDesc2Func(m_ptr, ref pDesc);
        }
        delegate int GetDesc2Func(IntPtr self, ref DXGI_ADAPTER_DESC2 pDesc);
        GetDesc2Func m_GetDesc2Func;

    }
}
