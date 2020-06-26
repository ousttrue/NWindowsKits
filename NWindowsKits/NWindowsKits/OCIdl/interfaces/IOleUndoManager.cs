// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/OCIdl.h:5434
    public class IOleUndoManager : IUnknown
    {
        static Guid s_uuid = new Guid("d001f200-ef97-11ce-9bc9-00aa00608e01");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int Open(IntPtr pPUU)
        {
            if(m_OpenFunc==null){
                var fp = GetFunctionPointer(3);
                m_OpenFunc = (OpenFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OpenFunc));
            } 
            return  m_OpenFunc(m_ptr, pPUU);
        }
        delegate int OpenFunc(IntPtr self, IntPtr pPUU);
        OpenFunc m_OpenFunc;

        public int Close(IntPtr pPUU, int fCommit)
        {
            if(m_CloseFunc==null){
                var fp = GetFunctionPointer(4);
                m_CloseFunc = (CloseFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CloseFunc));
            } 
            return  m_CloseFunc(m_ptr, pPUU, fCommit);
        }
        delegate int CloseFunc(IntPtr self, IntPtr pPUU, int fCommit);
        CloseFunc m_CloseFunc;

        public int Add(IntPtr pUU)
        {
            if(m_AddFunc==null){
                var fp = GetFunctionPointer(5);
                m_AddFunc = (AddFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AddFunc));
            } 
            return  m_AddFunc(m_ptr, pUU);
        }
        delegate int AddFunc(IntPtr self, IntPtr pUU);
        AddFunc m_AddFunc;

        public int GetOpenParentState(ref uint pdwState)
        {
            if(m_GetOpenParentStateFunc==null){
                var fp = GetFunctionPointer(6);
                m_GetOpenParentStateFunc = (GetOpenParentStateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetOpenParentStateFunc));
            } 
            return  m_GetOpenParentStateFunc(m_ptr, ref pdwState);
        }
        delegate int GetOpenParentStateFunc(IntPtr self, ref uint pdwState);
        GetOpenParentStateFunc m_GetOpenParentStateFunc;

        public int DiscardFrom(IntPtr pUU)
        {
            if(m_DiscardFromFunc==null){
                var fp = GetFunctionPointer(7);
                m_DiscardFromFunc = (DiscardFromFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DiscardFromFunc));
            } 
            return  m_DiscardFromFunc(m_ptr, pUU);
        }
        delegate int DiscardFromFunc(IntPtr self, IntPtr pUU);
        DiscardFromFunc m_DiscardFromFunc;

        public int UndoTo(IntPtr pUU)
        {
            if(m_UndoToFunc==null){
                var fp = GetFunctionPointer(8);
                m_UndoToFunc = (UndoToFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(UndoToFunc));
            } 
            return  m_UndoToFunc(m_ptr, pUU);
        }
        delegate int UndoToFunc(IntPtr self, IntPtr pUU);
        UndoToFunc m_UndoToFunc;

        public int RedoTo(IntPtr pUU)
        {
            if(m_RedoToFunc==null){
                var fp = GetFunctionPointer(9);
                m_RedoToFunc = (RedoToFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RedoToFunc));
            } 
            return  m_RedoToFunc(m_ptr, pUU);
        }
        delegate int RedoToFunc(IntPtr self, IntPtr pUU);
        RedoToFunc m_RedoToFunc;

        public int EnumUndoable(ref IntPtr ppEnum)
        {
            if(m_EnumUndoableFunc==null){
                var fp = GetFunctionPointer(10);
                m_EnumUndoableFunc = (EnumUndoableFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(EnumUndoableFunc));
            } 
            return  m_EnumUndoableFunc(m_ptr, ref ppEnum);
        }
        delegate int EnumUndoableFunc(IntPtr self, ref IntPtr ppEnum);
        EnumUndoableFunc m_EnumUndoableFunc;

        public int EnumRedoable(ref IntPtr ppEnum)
        {
            if(m_EnumRedoableFunc==null){
                var fp = GetFunctionPointer(11);
                m_EnumRedoableFunc = (EnumRedoableFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(EnumRedoableFunc));
            } 
            return  m_EnumRedoableFunc(m_ptr, ref ppEnum);
        }
        delegate int EnumRedoableFunc(IntPtr self, ref IntPtr ppEnum);
        EnumRedoableFunc m_EnumRedoableFunc;

        public int GetLastUndoDescription(ref IntPtr pBstr)
        {
            if(m_GetLastUndoDescriptionFunc==null){
                var fp = GetFunctionPointer(12);
                m_GetLastUndoDescriptionFunc = (GetLastUndoDescriptionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetLastUndoDescriptionFunc));
            } 
            return  m_GetLastUndoDescriptionFunc(m_ptr, ref pBstr);
        }
        delegate int GetLastUndoDescriptionFunc(IntPtr self, ref IntPtr pBstr);
        GetLastUndoDescriptionFunc m_GetLastUndoDescriptionFunc;

        public int GetLastRedoDescription(ref IntPtr pBstr)
        {
            if(m_GetLastRedoDescriptionFunc==null){
                var fp = GetFunctionPointer(13);
                m_GetLastRedoDescriptionFunc = (GetLastRedoDescriptionFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetLastRedoDescriptionFunc));
            } 
            return  m_GetLastRedoDescriptionFunc(m_ptr, ref pBstr);
        }
        delegate int GetLastRedoDescriptionFunc(IntPtr self, ref IntPtr pBstr);
        GetLastRedoDescriptionFunc m_GetLastRedoDescriptionFunc;

        public int Enable(int fEnable)
        {
            if(m_EnableFunc==null){
                var fp = GetFunctionPointer(14);
                m_EnableFunc = (EnableFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(EnableFunc));
            } 
            return  m_EnableFunc(m_ptr, fEnable);
        }
        delegate int EnableFunc(IntPtr self, int fEnable);
        EnableFunc m_EnableFunc;

    }
}
