// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/OCIdl.h:5152
    public class IOleParentUndoUnit : IOleUndoUnit // 3
    {
        static Guid s_uuid = new Guid("a1faf330-ef97-11ce-9bc9-00aa00608e01");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int Open(IntPtr pPUU)
        {
            if(m_OpenFunc==null){
                var fp = GetFunctionPointer(7);
                m_OpenFunc = (OpenFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OpenFunc));
            } 
            return  m_OpenFunc(m_ptr, pPUU);
        }
        delegate int OpenFunc(IntPtr self, IntPtr pPUU);
        OpenFunc m_OpenFunc;

        public int Close(IntPtr pPUU, int fCommit)
        {
            if(m_CloseFunc==null){
                var fp = GetFunctionPointer(8);
                m_CloseFunc = (CloseFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CloseFunc));
            } 
            return  m_CloseFunc(m_ptr, pPUU, fCommit);
        }
        delegate int CloseFunc(IntPtr self, IntPtr pPUU, int fCommit);
        CloseFunc m_CloseFunc;

        public int Add(IntPtr pUU)
        {
            if(m_AddFunc==null){
                var fp = GetFunctionPointer(9);
                m_AddFunc = (AddFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(AddFunc));
            } 
            return  m_AddFunc(m_ptr, pUU);
        }
        delegate int AddFunc(IntPtr self, IntPtr pUU);
        AddFunc m_AddFunc;

        public int FindUnit(IntPtr pUU)
        {
            if(m_FindUnitFunc==null){
                var fp = GetFunctionPointer(10);
                m_FindUnitFunc = (FindUnitFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(FindUnitFunc));
            } 
            return  m_FindUnitFunc(m_ptr, pUU);
        }
        delegate int FindUnitFunc(IntPtr self, IntPtr pUU);
        FindUnitFunc m_FindUnitFunc;

        public int GetParentState(ref uint pdwState)
        {
            if(m_GetParentStateFunc==null){
                var fp = GetFunctionPointer(11);
                m_GetParentStateFunc = (GetParentStateFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetParentStateFunc));
            } 
            return  m_GetParentStateFunc(m_ptr, ref pdwState);
        }
        delegate int GetParentStateFunc(IntPtr self, ref uint pdwState);
        GetParentStateFunc m_GetParentStateFunc;

    }
}
