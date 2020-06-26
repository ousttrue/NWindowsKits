// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/msxml.h:8207
    public class IXMLHttpRequest : IDispatch // 1
    {
        static Guid s_uuid = new Guid("ed8c108d-4349-11d2-91a4-00c04f7969e8");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int open(IntPtr bstrMethod, IntPtr bstrUrl, VARIANT varAsync, VARIANT bstrUser, VARIANT bstrPassword)
        {
            if(m_openFunc==null){
                var fp = GetFunctionPointer(7);
                m_openFunc = (openFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(openFunc));
            } 
            return  m_openFunc(m_ptr, bstrMethod, bstrUrl, varAsync, bstrUser, bstrPassword);
        }
        delegate int openFunc(IntPtr self, IntPtr bstrMethod, IntPtr bstrUrl, VARIANT varAsync, VARIANT bstrUser, VARIANT bstrPassword);
        openFunc m_openFunc;

        public int setRequestHeader(IntPtr bstrHeader, IntPtr bstrValue)
        {
            if(m_setRequestHeaderFunc==null){
                var fp = GetFunctionPointer(8);
                m_setRequestHeaderFunc = (setRequestHeaderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(setRequestHeaderFunc));
            } 
            return  m_setRequestHeaderFunc(m_ptr, bstrHeader, bstrValue);
        }
        delegate int setRequestHeaderFunc(IntPtr self, IntPtr bstrHeader, IntPtr bstrValue);
        setRequestHeaderFunc m_setRequestHeaderFunc;

        public int getResponseHeader(IntPtr bstrHeader, ref IntPtr pbstrValue)
        {
            if(m_getResponseHeaderFunc==null){
                var fp = GetFunctionPointer(9);
                m_getResponseHeaderFunc = (getResponseHeaderFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(getResponseHeaderFunc));
            } 
            return  m_getResponseHeaderFunc(m_ptr, bstrHeader, ref pbstrValue);
        }
        delegate int getResponseHeaderFunc(IntPtr self, IntPtr bstrHeader, ref IntPtr pbstrValue);
        getResponseHeaderFunc m_getResponseHeaderFunc;

        public int getAllResponseHeaders(ref IntPtr pbstrHeaders)
        {
            if(m_getAllResponseHeadersFunc==null){
                var fp = GetFunctionPointer(10);
                m_getAllResponseHeadersFunc = (getAllResponseHeadersFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(getAllResponseHeadersFunc));
            } 
            return  m_getAllResponseHeadersFunc(m_ptr, ref pbstrHeaders);
        }
        delegate int getAllResponseHeadersFunc(IntPtr self, ref IntPtr pbstrHeaders);
        getAllResponseHeadersFunc m_getAllResponseHeadersFunc;

        public int send(VARIANT varBody)
        {
            if(m_sendFunc==null){
                var fp = GetFunctionPointer(11);
                m_sendFunc = (sendFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(sendFunc));
            } 
            return  m_sendFunc(m_ptr, varBody);
        }
        delegate int sendFunc(IntPtr self, VARIANT varBody);
        sendFunc m_sendFunc;

        public int abort()
        {
            if(m_abortFunc==null){
                var fp = GetFunctionPointer(12);
                m_abortFunc = (abortFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(abortFunc));
            } 
            return  m_abortFunc(m_ptr);
        }
        delegate int abortFunc(IntPtr self);
        abortFunc m_abortFunc;

        public int get_status(ref int plStatus)
        {
            if(m_get_statusFunc==null){
                var fp = GetFunctionPointer(13);
                m_get_statusFunc = (get_statusFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(get_statusFunc));
            } 
            return  m_get_statusFunc(m_ptr, ref plStatus);
        }
        delegate int get_statusFunc(IntPtr self, ref int plStatus);
        get_statusFunc m_get_statusFunc;

        public int get_statusText(ref IntPtr pbstrStatus)
        {
            if(m_get_statusTextFunc==null){
                var fp = GetFunctionPointer(14);
                m_get_statusTextFunc = (get_statusTextFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(get_statusTextFunc));
            } 
            return  m_get_statusTextFunc(m_ptr, ref pbstrStatus);
        }
        delegate int get_statusTextFunc(IntPtr self, ref IntPtr pbstrStatus);
        get_statusTextFunc m_get_statusTextFunc;

        public int get_responseXML(ref IntPtr ppBody)
        {
            if(m_get_responseXMLFunc==null){
                var fp = GetFunctionPointer(15);
                m_get_responseXMLFunc = (get_responseXMLFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(get_responseXMLFunc));
            } 
            return  m_get_responseXMLFunc(m_ptr, ref ppBody);
        }
        delegate int get_responseXMLFunc(IntPtr self, ref IntPtr ppBody);
        get_responseXMLFunc m_get_responseXMLFunc;

        public int get_responseText(ref IntPtr pbstrBody)
        {
            if(m_get_responseTextFunc==null){
                var fp = GetFunctionPointer(16);
                m_get_responseTextFunc = (get_responseTextFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(get_responseTextFunc));
            } 
            return  m_get_responseTextFunc(m_ptr, ref pbstrBody);
        }
        delegate int get_responseTextFunc(IntPtr self, ref IntPtr pbstrBody);
        get_responseTextFunc m_get_responseTextFunc;

        public int get_responseBody(ref VARIANT pvarBody)
        {
            if(m_get_responseBodyFunc==null){
                var fp = GetFunctionPointer(17);
                m_get_responseBodyFunc = (get_responseBodyFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(get_responseBodyFunc));
            } 
            return  m_get_responseBodyFunc(m_ptr, ref pvarBody);
        }
        delegate int get_responseBodyFunc(IntPtr self, ref VARIANT pvarBody);
        get_responseBodyFunc m_get_responseBodyFunc;

        public int get_responseStream(ref VARIANT pvarBody)
        {
            if(m_get_responseStreamFunc==null){
                var fp = GetFunctionPointer(18);
                m_get_responseStreamFunc = (get_responseStreamFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(get_responseStreamFunc));
            } 
            return  m_get_responseStreamFunc(m_ptr, ref pvarBody);
        }
        delegate int get_responseStreamFunc(IntPtr self, ref VARIANT pvarBody);
        get_responseStreamFunc m_get_responseStreamFunc;

        public int get_readyState(ref int plState)
        {
            if(m_get_readyStateFunc==null){
                var fp = GetFunctionPointer(19);
                m_get_readyStateFunc = (get_readyStateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(get_readyStateFunc));
            } 
            return  m_get_readyStateFunc(m_ptr, ref plState);
        }
        delegate int get_readyStateFunc(IntPtr self, ref int plState);
        get_readyStateFunc m_get_readyStateFunc;

        public int put_onreadystatechange(IntPtr pReadyStateSink)
        {
            if(m_put_onreadystatechangeFunc==null){
                var fp = GetFunctionPointer(20);
                m_put_onreadystatechangeFunc = (put_onreadystatechangeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(put_onreadystatechangeFunc));
            } 
            return  m_put_onreadystatechangeFunc(m_ptr, pReadyStateSink);
        }
        delegate int put_onreadystatechangeFunc(IntPtr self, IntPtr pReadyStateSink);
        put_onreadystatechangeFunc m_put_onreadystatechangeFunc;

    }
}
