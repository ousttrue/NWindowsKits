// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/oleidl.h:3375
    public class IDropSource : IUnknown // 1
    {
        static Guid s_uuid = new Guid("00000121-0000-0000-c000-000000000046");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int QueryContinueDrag(int fEscapePressed, uint grfKeyState)
        {
            if(m_QueryContinueDragFunc==null){
                var fp = GetFunctionPointer(3);
                m_QueryContinueDragFunc = (QueryContinueDragFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(QueryContinueDragFunc));
            } 
            
            return  m_QueryContinueDragFunc(m_ptr, fEscapePressed, grfKeyState);
        }
        delegate int QueryContinueDragFunc(IntPtr self, int fEscapePressed, uint grfKeyState);
        QueryContinueDragFunc m_QueryContinueDragFunc;

        public int GiveFeedback(uint dwEffect)
        {
            if(m_GiveFeedbackFunc==null){
                var fp = GetFunctionPointer(4);
                m_GiveFeedbackFunc = (GiveFeedbackFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GiveFeedbackFunc));
            } 
            
            return  m_GiveFeedbackFunc(m_ptr, dwEffect);
        }
        delegate int GiveFeedbackFunc(IntPtr self, uint dwEffect);
        GiveFeedbackFunc m_GiveFeedbackFunc;

    }
}