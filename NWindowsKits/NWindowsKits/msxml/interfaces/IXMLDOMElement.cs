// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/msxml.h:3504
    public class IXMLDOMElement : IXMLDOMNode
    {
        static Guid s_uuid = new Guid("2933bf86-7b36-11d2-b20e-00c04f983e60");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int get_tagName(ref IntPtr tagName)
        {
            if(m_get_tagNameFunc==null){
                var fp = GetFunctionPointer(43);
                m_get_tagNameFunc = (get_tagNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(get_tagNameFunc));
            } 
            return  m_get_tagNameFunc(m_ptr, ref tagName);
        }
        delegate int get_tagNameFunc(IntPtr self, ref IntPtr tagName);
        get_tagNameFunc m_get_tagNameFunc;

        public int getAttribute(IntPtr name, ref VARIANT value)
        {
            if(m_getAttributeFunc==null){
                var fp = GetFunctionPointer(44);
                m_getAttributeFunc = (getAttributeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(getAttributeFunc));
            } 
            return  m_getAttributeFunc(m_ptr, name, ref value);
        }
        delegate int getAttributeFunc(IntPtr self, IntPtr name, ref VARIANT value);
        getAttributeFunc m_getAttributeFunc;

        public int setAttribute(IntPtr name, VARIANT value)
        {
            if(m_setAttributeFunc==null){
                var fp = GetFunctionPointer(45);
                m_setAttributeFunc = (setAttributeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(setAttributeFunc));
            } 
            return  m_setAttributeFunc(m_ptr, name, value);
        }
        delegate int setAttributeFunc(IntPtr self, IntPtr name, VARIANT value);
        setAttributeFunc m_setAttributeFunc;

        public int removeAttribute(IntPtr name)
        {
            if(m_removeAttributeFunc==null){
                var fp = GetFunctionPointer(46);
                m_removeAttributeFunc = (removeAttributeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(removeAttributeFunc));
            } 
            return  m_removeAttributeFunc(m_ptr, name);
        }
        delegate int removeAttributeFunc(IntPtr self, IntPtr name);
        removeAttributeFunc m_removeAttributeFunc;

        public int getAttributeNode(IntPtr name, ref IntPtr attributeNode)
        {
            if(m_getAttributeNodeFunc==null){
                var fp = GetFunctionPointer(47);
                m_getAttributeNodeFunc = (getAttributeNodeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(getAttributeNodeFunc));
            } 
            return  m_getAttributeNodeFunc(m_ptr, name, ref attributeNode);
        }
        delegate int getAttributeNodeFunc(IntPtr self, IntPtr name, ref IntPtr attributeNode);
        getAttributeNodeFunc m_getAttributeNodeFunc;

        public int setAttributeNode(IntPtr DOMAttribute, ref IntPtr attributeNode)
        {
            if(m_setAttributeNodeFunc==null){
                var fp = GetFunctionPointer(48);
                m_setAttributeNodeFunc = (setAttributeNodeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(setAttributeNodeFunc));
            } 
            return  m_setAttributeNodeFunc(m_ptr, DOMAttribute, ref attributeNode);
        }
        delegate int setAttributeNodeFunc(IntPtr self, IntPtr DOMAttribute, ref IntPtr attributeNode);
        setAttributeNodeFunc m_setAttributeNodeFunc;

        public int removeAttributeNode(IntPtr DOMAttribute, ref IntPtr attributeNode)
        {
            if(m_removeAttributeNodeFunc==null){
                var fp = GetFunctionPointer(49);
                m_removeAttributeNodeFunc = (removeAttributeNodeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(removeAttributeNodeFunc));
            } 
            return  m_removeAttributeNodeFunc(m_ptr, DOMAttribute, ref attributeNode);
        }
        delegate int removeAttributeNodeFunc(IntPtr self, IntPtr DOMAttribute, ref IntPtr attributeNode);
        removeAttributeNodeFunc m_removeAttributeNodeFunc;

        public int getElementsByTagName(IntPtr tagName, ref IntPtr resultList)
        {
            if(m_getElementsByTagNameFunc==null){
                var fp = GetFunctionPointer(50);
                m_getElementsByTagNameFunc = (getElementsByTagNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(getElementsByTagNameFunc));
            } 
            return  m_getElementsByTagNameFunc(m_ptr, tagName, ref resultList);
        }
        delegate int getElementsByTagNameFunc(IntPtr self, IntPtr tagName, ref IntPtr resultList);
        getElementsByTagNameFunc m_getElementsByTagNameFunc;

        public int normalize()
        {
            if(m_normalizeFunc==null){
                var fp = GetFunctionPointer(51);
                m_normalizeFunc = (normalizeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(normalizeFunc));
            } 
            return  m_normalizeFunc(m_ptr);
        }
        delegate int normalizeFunc(IntPtr self);
        normalizeFunc m_normalizeFunc;

    }
}
