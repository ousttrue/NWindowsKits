// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/ObjIdl.h:9740
    public class IROTData : IUnknown
    {
        static Guid s_uuid = new Guid("f29f6bc0-5021-11ce-aa15-00006901293f");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int GetComparisonData(ref byte pbData, uint cbMax, IntPtr pcbData)
        {
            if(m_GetComparisonDataFunc==null){
                var fp = GetFunctionPointer(3);
                m_GetComparisonDataFunc = (GetComparisonDataFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetComparisonDataFunc));
            } 
            return  m_GetComparisonDataFunc(m_ptr, ref pbData, cbMax, pcbData);
        }
        delegate int GetComparisonDataFunc(IntPtr self, ref byte pbData, uint cbMax, IntPtr pcbData);
        GetComparisonDataFunc m_GetComparisonDataFunc;

    }
}
