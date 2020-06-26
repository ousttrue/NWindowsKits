// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/msxml.h:6582
    public class IXMLDOMEntity : IXMLDOMNode // 1
    {
        static Guid s_uuid = new Guid("2933bf8d-7b36-11d2-b20e-00c04f983e60");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int get_publicId(ref VARIANT publicID)
        {
            if(m_get_publicIdFunc==null){
                var fp = GetFunctionPointer(43);
                m_get_publicIdFunc = (get_publicIdFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(get_publicIdFunc));
            } 
            return  m_get_publicIdFunc(m_ptr, ref publicID);
        }
        delegate int get_publicIdFunc(IntPtr self, ref VARIANT publicID);
        get_publicIdFunc m_get_publicIdFunc;

        public int get_systemId(ref VARIANT systemID)
        {
            if(m_get_systemIdFunc==null){
                var fp = GetFunctionPointer(44);
                m_get_systemIdFunc = (get_systemIdFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(get_systemIdFunc));
            } 
            return  m_get_systemIdFunc(m_ptr, ref systemID);
        }
        delegate int get_systemIdFunc(IntPtr self, ref VARIANT systemID);
        get_systemIdFunc m_get_systemIdFunc;

        public int get_notationName(ref IntPtr name)
        {
            if(m_get_notationNameFunc==null){
                var fp = GetFunctionPointer(45);
                m_get_notationNameFunc = (get_notationNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(get_notationNameFunc));
            } 
            return  m_get_notationNameFunc(m_ptr, ref name);
        }
        delegate int get_notationNameFunc(IntPtr self, ref IntPtr name);
        get_notationNameFunc m_get_notationNameFunc;

    }
}
