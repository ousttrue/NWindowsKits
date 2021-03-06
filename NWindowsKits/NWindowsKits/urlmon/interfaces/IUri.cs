// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/urlmon.h:2923
    public class IUri : IUnknown
    {
        static Guid s_uuid = new Guid("a39ee748-6a27-4817-a6f2-13914bef5890");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int GetPropertyBSTR(Uri_PROPERTY uriProp, ref IntPtr pbstrProperty, uint dwFlags)
        {
            if(m_GetPropertyBSTRFunc==null){
                var fp = GetFunctionPointer(3);
                m_GetPropertyBSTRFunc = (GetPropertyBSTRFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPropertyBSTRFunc));
            } 
            return  m_GetPropertyBSTRFunc(m_ptr, uriProp, ref pbstrProperty, dwFlags);
        }
        delegate int GetPropertyBSTRFunc(IntPtr self, Uri_PROPERTY uriProp, ref IntPtr pbstrProperty, uint dwFlags);
        GetPropertyBSTRFunc m_GetPropertyBSTRFunc;

        public int GetPropertyLength(Uri_PROPERTY uriProp, ref uint pcchProperty, uint dwFlags)
        {
            if(m_GetPropertyLengthFunc==null){
                var fp = GetFunctionPointer(4);
                m_GetPropertyLengthFunc = (GetPropertyLengthFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPropertyLengthFunc));
            } 
            return  m_GetPropertyLengthFunc(m_ptr, uriProp, ref pcchProperty, dwFlags);
        }
        delegate int GetPropertyLengthFunc(IntPtr self, Uri_PROPERTY uriProp, ref uint pcchProperty, uint dwFlags);
        GetPropertyLengthFunc m_GetPropertyLengthFunc;

        public int GetPropertyDWORD(Uri_PROPERTY uriProp, ref uint pdwProperty, uint dwFlags)
        {
            if(m_GetPropertyDWORDFunc==null){
                var fp = GetFunctionPointer(5);
                m_GetPropertyDWORDFunc = (GetPropertyDWORDFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPropertyDWORDFunc));
            } 
            return  m_GetPropertyDWORDFunc(m_ptr, uriProp, ref pdwProperty, dwFlags);
        }
        delegate int GetPropertyDWORDFunc(IntPtr self, Uri_PROPERTY uriProp, ref uint pdwProperty, uint dwFlags);
        GetPropertyDWORDFunc m_GetPropertyDWORDFunc;

        public int HasProperty(Uri_PROPERTY uriProp, ref int pfHasProperty)
        {
            if(m_HasPropertyFunc==null){
                var fp = GetFunctionPointer(6);
                m_HasPropertyFunc = (HasPropertyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(HasPropertyFunc));
            } 
            return  m_HasPropertyFunc(m_ptr, uriProp, ref pfHasProperty);
        }
        delegate int HasPropertyFunc(IntPtr self, Uri_PROPERTY uriProp, ref int pfHasProperty);
        HasPropertyFunc m_HasPropertyFunc;

        public int GetAbsoluteUri(ref IntPtr pbstrAbsoluteUri)
        {
            if(m_GetAbsoluteUriFunc==null){
                var fp = GetFunctionPointer(7);
                m_GetAbsoluteUriFunc = (GetAbsoluteUriFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetAbsoluteUriFunc));
            } 
            return  m_GetAbsoluteUriFunc(m_ptr, ref pbstrAbsoluteUri);
        }
        delegate int GetAbsoluteUriFunc(IntPtr self, ref IntPtr pbstrAbsoluteUri);
        GetAbsoluteUriFunc m_GetAbsoluteUriFunc;

        public int GetAuthority(ref IntPtr pbstrAuthority)
        {
            if(m_GetAuthorityFunc==null){
                var fp = GetFunctionPointer(8);
                m_GetAuthorityFunc = (GetAuthorityFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetAuthorityFunc));
            } 
            return  m_GetAuthorityFunc(m_ptr, ref pbstrAuthority);
        }
        delegate int GetAuthorityFunc(IntPtr self, ref IntPtr pbstrAuthority);
        GetAuthorityFunc m_GetAuthorityFunc;

        public int GetDisplayUri(ref IntPtr pbstrDisplayString)
        {
            if(m_GetDisplayUriFunc==null){
                var fp = GetFunctionPointer(9);
                m_GetDisplayUriFunc = (GetDisplayUriFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDisplayUriFunc));
            } 
            return  m_GetDisplayUriFunc(m_ptr, ref pbstrDisplayString);
        }
        delegate int GetDisplayUriFunc(IntPtr self, ref IntPtr pbstrDisplayString);
        GetDisplayUriFunc m_GetDisplayUriFunc;

        public int GetDomain(ref IntPtr pbstrDomain)
        {
            if(m_GetDomainFunc==null){
                var fp = GetFunctionPointer(10);
                m_GetDomainFunc = (GetDomainFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDomainFunc));
            } 
            return  m_GetDomainFunc(m_ptr, ref pbstrDomain);
        }
        delegate int GetDomainFunc(IntPtr self, ref IntPtr pbstrDomain);
        GetDomainFunc m_GetDomainFunc;

        public int GetExtension(ref IntPtr pbstrExtension)
        {
            if(m_GetExtensionFunc==null){
                var fp = GetFunctionPointer(11);
                m_GetExtensionFunc = (GetExtensionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetExtensionFunc));
            } 
            return  m_GetExtensionFunc(m_ptr, ref pbstrExtension);
        }
        delegate int GetExtensionFunc(IntPtr self, ref IntPtr pbstrExtension);
        GetExtensionFunc m_GetExtensionFunc;

        public int GetFragment(ref IntPtr pbstrFragment)
        {
            if(m_GetFragmentFunc==null){
                var fp = GetFunctionPointer(12);
                m_GetFragmentFunc = (GetFragmentFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetFragmentFunc));
            } 
            return  m_GetFragmentFunc(m_ptr, ref pbstrFragment);
        }
        delegate int GetFragmentFunc(IntPtr self, ref IntPtr pbstrFragment);
        GetFragmentFunc m_GetFragmentFunc;

        public int GetHost(ref IntPtr pbstrHost)
        {
            if(m_GetHostFunc==null){
                var fp = GetFunctionPointer(13);
                m_GetHostFunc = (GetHostFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetHostFunc));
            } 
            return  m_GetHostFunc(m_ptr, ref pbstrHost);
        }
        delegate int GetHostFunc(IntPtr self, ref IntPtr pbstrHost);
        GetHostFunc m_GetHostFunc;

        public int GetPassword(ref IntPtr pbstrPassword)
        {
            if(m_GetPasswordFunc==null){
                var fp = GetFunctionPointer(14);
                m_GetPasswordFunc = (GetPasswordFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPasswordFunc));
            } 
            return  m_GetPasswordFunc(m_ptr, ref pbstrPassword);
        }
        delegate int GetPasswordFunc(IntPtr self, ref IntPtr pbstrPassword);
        GetPasswordFunc m_GetPasswordFunc;

        public int GetPath(ref IntPtr pbstrPath)
        {
            if(m_GetPathFunc==null){
                var fp = GetFunctionPointer(15);
                m_GetPathFunc = (GetPathFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPathFunc));
            } 
            return  m_GetPathFunc(m_ptr, ref pbstrPath);
        }
        delegate int GetPathFunc(IntPtr self, ref IntPtr pbstrPath);
        GetPathFunc m_GetPathFunc;

        public int GetPathAndQuery(ref IntPtr pbstrPathAndQuery)
        {
            if(m_GetPathAndQueryFunc==null){
                var fp = GetFunctionPointer(16);
                m_GetPathAndQueryFunc = (GetPathAndQueryFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPathAndQueryFunc));
            } 
            return  m_GetPathAndQueryFunc(m_ptr, ref pbstrPathAndQuery);
        }
        delegate int GetPathAndQueryFunc(IntPtr self, ref IntPtr pbstrPathAndQuery);
        GetPathAndQueryFunc m_GetPathAndQueryFunc;

        public int GetQuery(ref IntPtr pbstrQuery)
        {
            if(m_GetQueryFunc==null){
                var fp = GetFunctionPointer(17);
                m_GetQueryFunc = (GetQueryFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetQueryFunc));
            } 
            return  m_GetQueryFunc(m_ptr, ref pbstrQuery);
        }
        delegate int GetQueryFunc(IntPtr self, ref IntPtr pbstrQuery);
        GetQueryFunc m_GetQueryFunc;

        public int GetRawUri(ref IntPtr pbstrRawUri)
        {
            if(m_GetRawUriFunc==null){
                var fp = GetFunctionPointer(18);
                m_GetRawUriFunc = (GetRawUriFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetRawUriFunc));
            } 
            return  m_GetRawUriFunc(m_ptr, ref pbstrRawUri);
        }
        delegate int GetRawUriFunc(IntPtr self, ref IntPtr pbstrRawUri);
        GetRawUriFunc m_GetRawUriFunc;

        public int GetSchemeName(ref IntPtr pbstrSchemeName)
        {
            if(m_GetSchemeNameFunc==null){
                var fp = GetFunctionPointer(19);
                m_GetSchemeNameFunc = (GetSchemeNameFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetSchemeNameFunc));
            } 
            return  m_GetSchemeNameFunc(m_ptr, ref pbstrSchemeName);
        }
        delegate int GetSchemeNameFunc(IntPtr self, ref IntPtr pbstrSchemeName);
        GetSchemeNameFunc m_GetSchemeNameFunc;

        public int GetUserInfo(ref IntPtr pbstrUserInfo)
        {
            if(m_GetUserInfoFunc==null){
                var fp = GetFunctionPointer(20);
                m_GetUserInfoFunc = (GetUserInfoFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetUserInfoFunc));
            } 
            return  m_GetUserInfoFunc(m_ptr, ref pbstrUserInfo);
        }
        delegate int GetUserInfoFunc(IntPtr self, ref IntPtr pbstrUserInfo);
        GetUserInfoFunc m_GetUserInfoFunc;

        public int GetUserNameA(ref IntPtr pbstrUserName)
        {
            if(m_GetUserNameAFunc==null){
                var fp = GetFunctionPointer(21);
                m_GetUserNameAFunc = (GetUserNameAFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetUserNameAFunc));
            } 
            return  m_GetUserNameAFunc(m_ptr, ref pbstrUserName);
        }
        delegate int GetUserNameAFunc(IntPtr self, ref IntPtr pbstrUserName);
        GetUserNameAFunc m_GetUserNameAFunc;

        public int GetHostType(ref uint pdwHostType)
        {
            if(m_GetHostTypeFunc==null){
                var fp = GetFunctionPointer(22);
                m_GetHostTypeFunc = (GetHostTypeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetHostTypeFunc));
            } 
            return  m_GetHostTypeFunc(m_ptr, ref pdwHostType);
        }
        delegate int GetHostTypeFunc(IntPtr self, ref uint pdwHostType);
        GetHostTypeFunc m_GetHostTypeFunc;

        public int GetPort(ref uint pdwPort)
        {
            if(m_GetPortFunc==null){
                var fp = GetFunctionPointer(23);
                m_GetPortFunc = (GetPortFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPortFunc));
            } 
            return  m_GetPortFunc(m_ptr, ref pdwPort);
        }
        delegate int GetPortFunc(IntPtr self, ref uint pdwPort);
        GetPortFunc m_GetPortFunc;

        public int GetScheme(ref uint pdwScheme)
        {
            if(m_GetSchemeFunc==null){
                var fp = GetFunctionPointer(24);
                m_GetSchemeFunc = (GetSchemeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetSchemeFunc));
            } 
            return  m_GetSchemeFunc(m_ptr, ref pdwScheme);
        }
        delegate int GetSchemeFunc(IntPtr self, ref uint pdwScheme);
        GetSchemeFunc m_GetSchemeFunc;

        public int GetZone(ref uint pdwZone)
        {
            if(m_GetZoneFunc==null){
                var fp = GetFunctionPointer(25);
                m_GetZoneFunc = (GetZoneFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetZoneFunc));
            } 
            return  m_GetZoneFunc(m_ptr, ref pdwZone);
        }
        delegate int GetZoneFunc(IntPtr self, ref uint pdwZone);
        GetZoneFunc m_GetZoneFunc;

        public int GetProperties(ref uint pdwFlags)
        {
            if(m_GetPropertiesFunc==null){
                var fp = GetFunctionPointer(26);
                m_GetPropertiesFunc = (GetPropertiesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetPropertiesFunc));
            } 
            return  m_GetPropertiesFunc(m_ptr, ref pdwFlags);
        }
        delegate int GetPropertiesFunc(IntPtr self, ref uint pdwFlags);
        GetPropertiesFunc m_GetPropertiesFunc;

        public int IsEqual(IntPtr pUri, ref int pfEqual)
        {
            if(m_IsEqualFunc==null){
                var fp = GetFunctionPointer(27);
                m_IsEqualFunc = (IsEqualFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(IsEqualFunc));
            } 
            return  m_IsEqualFunc(m_ptr, pUri, ref pfEqual);
        }
        delegate int IsEqualFunc(IntPtr self, IntPtr pUri, ref int pfEqual);
        IsEqualFunc m_IsEqualFunc;

    }
}
