// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/ObjIdl.h:13858
    public class IThumbnailExtractor : IUnknown
    {
        static Guid s_uuid = new Guid("969dc708-5c76-11d1-8d86-0000f804b057");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int ExtractThumbnail(IntPtr pStg, uint ulLength, uint ulHeight, IntPtr pulOutputLength, IntPtr pulOutputHeight, ref HBITMAP phOutputBitmap)
        {
            if(m_ExtractThumbnailFunc==null){
                var fp = GetFunctionPointer(3);
                m_ExtractThumbnailFunc = (ExtractThumbnailFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(ExtractThumbnailFunc));
            } 
            return  m_ExtractThumbnailFunc(m_ptr, pStg, ulLength, ulHeight, pulOutputLength, pulOutputHeight, ref phOutputBitmap);
        }
        delegate int ExtractThumbnailFunc(IntPtr self, IntPtr pStg, uint ulLength, uint ulHeight, IntPtr pulOutputLength, IntPtr pulOutputHeight, ref HBITMAP phOutputBitmap);
        ExtractThumbnailFunc m_ExtractThumbnailFunc;

        public int OnFileUpdated(IntPtr pStg)
        {
            if(m_OnFileUpdatedFunc==null){
                var fp = GetFunctionPointer(4);
                m_OnFileUpdatedFunc = (OnFileUpdatedFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OnFileUpdatedFunc));
            } 
            return  m_OnFileUpdatedFunc(m_ptr, pStg);
        }
        delegate int OnFileUpdatedFunc(IntPtr self, IntPtr pStg);
        OnFileUpdatedFunc m_OnFileUpdatedFunc;

    }
}
