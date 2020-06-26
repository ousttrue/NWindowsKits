// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/OAIdl.h:4371
    public class IErrorInfo : IUnknown // 1
    {
        static Guid s_uuid = new Guid("1cf2b120-547d-101b-8e65-08002b2bd119");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int GetGUID(ref GUID pGUID)
        {
            if(m_GetGUIDFunc==null){
                var fp = GetFunctionPointer(3);
                m_GetGUIDFunc = (GetGUIDFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetGUIDFunc));
            } 
            return  m_GetGUIDFunc(m_ptr, ref pGUID);
        }
        delegate int GetGUIDFunc(IntPtr self, ref GUID pGUID);
        GetGUIDFunc m_GetGUIDFunc;

        public int GetSource(ref IntPtr pBstrSource)
        {
            if(m_GetSourceFunc==null){
                var fp = GetFunctionPointer(4);
                m_GetSourceFunc = (GetSourceFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetSourceFunc));
            } 
            return  m_GetSourceFunc(m_ptr, ref pBstrSource);
        }
        delegate int GetSourceFunc(IntPtr self, ref IntPtr pBstrSource);
        GetSourceFunc m_GetSourceFunc;

        public int GetDescription(ref IntPtr pBstrDescription)
        {
            if(m_GetDescriptionFunc==null){
                var fp = GetFunctionPointer(5);
                m_GetDescriptionFunc = (GetDescriptionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetDescriptionFunc));
            } 
            return  m_GetDescriptionFunc(m_ptr, ref pBstrDescription);
        }
        delegate int GetDescriptionFunc(IntPtr self, ref IntPtr pBstrDescription);
        GetDescriptionFunc m_GetDescriptionFunc;

        public int GetHelpFile(ref IntPtr pBstrHelpFile)
        {
            if(m_GetHelpFileFunc==null){
                var fp = GetFunctionPointer(6);
                m_GetHelpFileFunc = (GetHelpFileFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetHelpFileFunc));
            } 
            return  m_GetHelpFileFunc(m_ptr, ref pBstrHelpFile);
        }
        delegate int GetHelpFileFunc(IntPtr self, ref IntPtr pBstrHelpFile);
        GetHelpFileFunc m_GetHelpFileFunc;

        public int GetHelpContext(ref uint pdwHelpContext)
        {
            if(m_GetHelpContextFunc==null){
                var fp = GetFunctionPointer(7);
                m_GetHelpContextFunc = (GetHelpContextFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetHelpContextFunc));
            } 
            return  m_GetHelpContextFunc(m_ptr, ref pdwHelpContext);
        }
        delegate int GetHelpContextFunc(IntPtr self, ref uint pdwHelpContext);
        GetHelpContextFunc m_GetHelpContextFunc;

    }
}
