// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/d3d11.h:11041
    public class ID3D11CryptoSession : ID3D11DeviceChild
    {
        static Guid s_uuid = new Guid("9b32f9ad-bdcc-40a6-a39d-d5c865845720");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public void GetCryptoType(ref GUID pCryptoType)
        {
            if(m_GetCryptoTypeFunc==null){
                var fp = GetFunctionPointer(7);
                m_GetCryptoTypeFunc = (GetCryptoTypeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetCryptoTypeFunc));
            } 
             m_GetCryptoTypeFunc(m_ptr, ref pCryptoType);
        }
        delegate void GetCryptoTypeFunc(IntPtr self, ref GUID pCryptoType);
        GetCryptoTypeFunc m_GetCryptoTypeFunc;

        public void GetDecoderProfile(ref GUID pDecoderProfile)
        {
            if(m_GetDecoderProfileFunc==null){
                var fp = GetFunctionPointer(8);
                m_GetDecoderProfileFunc = (GetDecoderProfileFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDecoderProfileFunc));
            } 
             m_GetDecoderProfileFunc(m_ptr, ref pDecoderProfile);
        }
        delegate void GetDecoderProfileFunc(IntPtr self, ref GUID pDecoderProfile);
        GetDecoderProfileFunc m_GetDecoderProfileFunc;

        public int GetCertificateSize(ref uint pCertificateSize)
        {
            if(m_GetCertificateSizeFunc==null){
                var fp = GetFunctionPointer(9);
                m_GetCertificateSizeFunc = (GetCertificateSizeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetCertificateSizeFunc));
            } 
            return  m_GetCertificateSizeFunc(m_ptr, ref pCertificateSize);
        }
        delegate int GetCertificateSizeFunc(IntPtr self, ref uint pCertificateSize);
        GetCertificateSizeFunc m_GetCertificateSizeFunc;

        public int GetCertificate(uint CertificateSize, ref byte pCertificate)
        {
            if(m_GetCertificateFunc==null){
                var fp = GetFunctionPointer(10);
                m_GetCertificateFunc = (GetCertificateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetCertificateFunc));
            } 
            return  m_GetCertificateFunc(m_ptr, CertificateSize, ref pCertificate);
        }
        delegate int GetCertificateFunc(IntPtr self, uint CertificateSize, ref byte pCertificate);
        GetCertificateFunc m_GetCertificateFunc;

        public void GetCryptoSessionHandle(ref IntPtr pCryptoSessionHandle)
        {
            if(m_GetCryptoSessionHandleFunc==null){
                var fp = GetFunctionPointer(11);
                m_GetCryptoSessionHandleFunc = (GetCryptoSessionHandleFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetCryptoSessionHandleFunc));
            } 
             m_GetCryptoSessionHandleFunc(m_ptr, ref pCryptoSessionHandle);
        }
        delegate void GetCryptoSessionHandleFunc(IntPtr self, ref IntPtr pCryptoSessionHandle);
        GetCryptoSessionHandleFunc m_GetCryptoSessionHandleFunc;

    }
}
