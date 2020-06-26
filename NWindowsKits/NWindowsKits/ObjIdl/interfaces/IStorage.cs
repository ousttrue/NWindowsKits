// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/ObjIdl.h:9983
    public class IStorage : IUnknown
    {
        static Guid s_uuid = new Guid("0000000b-0000-0000-c000-000000000046");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int CreateStream(IntPtr pwcsName, uint grfMode, uint reserved1, uint reserved2, ref IntPtr ppstm)
        {
            if(m_CreateStreamFunc==null){
                var fp = GetFunctionPointer(3);
                m_CreateStreamFunc = (CreateStreamFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateStreamFunc));
            } 
            return  m_CreateStreamFunc(m_ptr, pwcsName, grfMode, reserved1, reserved2, ref ppstm);
        }
        delegate int CreateStreamFunc(IntPtr self, IntPtr pwcsName, uint grfMode, uint reserved1, uint reserved2, ref IntPtr ppstm);
        CreateStreamFunc m_CreateStreamFunc;

        public int OpenStream(IntPtr pwcsName, IntPtr reserved1, uint grfMode, uint reserved2, ref IntPtr ppstm)
        {
            if(m_OpenStreamFunc==null){
                var fp = GetFunctionPointer(4);
                m_OpenStreamFunc = (OpenStreamFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OpenStreamFunc));
            } 
            return  m_OpenStreamFunc(m_ptr, pwcsName, reserved1, grfMode, reserved2, ref ppstm);
        }
        delegate int OpenStreamFunc(IntPtr self, IntPtr pwcsName, IntPtr reserved1, uint grfMode, uint reserved2, ref IntPtr ppstm);
        OpenStreamFunc m_OpenStreamFunc;

        public int CreateStorage(IntPtr pwcsName, uint grfMode, uint reserved1, uint reserved2, ref IntPtr ppstg)
        {
            if(m_CreateStorageFunc==null){
                var fp = GetFunctionPointer(5);
                m_CreateStorageFunc = (CreateStorageFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CreateStorageFunc));
            } 
            return  m_CreateStorageFunc(m_ptr, pwcsName, grfMode, reserved1, reserved2, ref ppstg);
        }
        delegate int CreateStorageFunc(IntPtr self, IntPtr pwcsName, uint grfMode, uint reserved1, uint reserved2, ref IntPtr ppstg);
        CreateStorageFunc m_CreateStorageFunc;

        public int OpenStorage(IntPtr pwcsName, IntPtr pstgPriority, uint grfMode, ref IntPtr snbExclude, uint reserved, ref IntPtr ppstg)
        {
            if(m_OpenStorageFunc==null){
                var fp = GetFunctionPointer(6);
                m_OpenStorageFunc = (OpenStorageFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(OpenStorageFunc));
            } 
            return  m_OpenStorageFunc(m_ptr, pwcsName, pstgPriority, grfMode, ref snbExclude, reserved, ref ppstg);
        }
        delegate int OpenStorageFunc(IntPtr self, IntPtr pwcsName, IntPtr pstgPriority, uint grfMode, ref IntPtr snbExclude, uint reserved, ref IntPtr ppstg);
        OpenStorageFunc m_OpenStorageFunc;

        public int CopyTo(uint ciidExclude, ref Guid rgiidExclude, ref IntPtr snbExclude, IntPtr pstgDest)
        {
            if(m_CopyToFunc==null){
                var fp = GetFunctionPointer(7);
                m_CopyToFunc = (CopyToFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CopyToFunc));
            } 
            return  m_CopyToFunc(m_ptr, ciidExclude, ref rgiidExclude, ref snbExclude, pstgDest);
        }
        delegate int CopyToFunc(IntPtr self, uint ciidExclude, ref Guid rgiidExclude, ref IntPtr snbExclude, IntPtr pstgDest);
        CopyToFunc m_CopyToFunc;

        public int MoveElementTo(IntPtr pwcsName, IntPtr pstgDest, IntPtr pwcsNewName, uint grfFlags)
        {
            if(m_MoveElementToFunc==null){
                var fp = GetFunctionPointer(8);
                m_MoveElementToFunc = (MoveElementToFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(MoveElementToFunc));
            } 
            return  m_MoveElementToFunc(m_ptr, pwcsName, pstgDest, pwcsNewName, grfFlags);
        }
        delegate int MoveElementToFunc(IntPtr self, IntPtr pwcsName, IntPtr pstgDest, IntPtr pwcsNewName, uint grfFlags);
        MoveElementToFunc m_MoveElementToFunc;

        public int Commit(uint grfCommitFlags)
        {
            if(m_CommitFunc==null){
                var fp = GetFunctionPointer(9);
                m_CommitFunc = (CommitFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(CommitFunc));
            } 
            return  m_CommitFunc(m_ptr, grfCommitFlags);
        }
        delegate int CommitFunc(IntPtr self, uint grfCommitFlags);
        CommitFunc m_CommitFunc;

        public int Revert()
        {
            if(m_RevertFunc==null){
                var fp = GetFunctionPointer(10);
                m_RevertFunc = (RevertFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RevertFunc));
            } 
            return  m_RevertFunc(m_ptr);
        }
        delegate int RevertFunc(IntPtr self);
        RevertFunc m_RevertFunc;

        public int EnumElements(uint reserved1, IntPtr reserved2, uint reserved3, ref IntPtr ppenum)
        {
            if(m_EnumElementsFunc==null){
                var fp = GetFunctionPointer(11);
                m_EnumElementsFunc = (EnumElementsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(EnumElementsFunc));
            } 
            return  m_EnumElementsFunc(m_ptr, reserved1, reserved2, reserved3, ref ppenum);
        }
        delegate int EnumElementsFunc(IntPtr self, uint reserved1, IntPtr reserved2, uint reserved3, ref IntPtr ppenum);
        EnumElementsFunc m_EnumElementsFunc;

        public int DestroyElement(IntPtr pwcsName)
        {
            if(m_DestroyElementFunc==null){
                var fp = GetFunctionPointer(12);
                m_DestroyElementFunc = (DestroyElementFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DestroyElementFunc));
            } 
            return  m_DestroyElementFunc(m_ptr, pwcsName);
        }
        delegate int DestroyElementFunc(IntPtr self, IntPtr pwcsName);
        DestroyElementFunc m_DestroyElementFunc;

        public int RenameElement(IntPtr pwcsOldName, IntPtr pwcsNewName)
        {
            if(m_RenameElementFunc==null){
                var fp = GetFunctionPointer(13);
                m_RenameElementFunc = (RenameElementFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(RenameElementFunc));
            } 
            return  m_RenameElementFunc(m_ptr, pwcsOldName, pwcsNewName);
        }
        delegate int RenameElementFunc(IntPtr self, IntPtr pwcsOldName, IntPtr pwcsNewName);
        RenameElementFunc m_RenameElementFunc;

        public int SetElementTimes(IntPtr pwcsName, ref FILETIME pctime, ref FILETIME patime, ref FILETIME pmtime)
        {
            if(m_SetElementTimesFunc==null){
                var fp = GetFunctionPointer(14);
                m_SetElementTimesFunc = (SetElementTimesFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetElementTimesFunc));
            } 
            return  m_SetElementTimesFunc(m_ptr, pwcsName, ref pctime, ref patime, ref pmtime);
        }
        delegate int SetElementTimesFunc(IntPtr self, IntPtr pwcsName, ref FILETIME pctime, ref FILETIME patime, ref FILETIME pmtime);
        SetElementTimesFunc m_SetElementTimesFunc;

        public int SetClass(ref Guid clsid)
        {
            if(m_SetClassFunc==null){
                var fp = GetFunctionPointer(15);
                m_SetClassFunc = (SetClassFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetClassFunc));
            } 
            return  m_SetClassFunc(m_ptr, ref clsid);
        }
        delegate int SetClassFunc(IntPtr self, ref Guid clsid);
        SetClassFunc m_SetClassFunc;

        public int SetStateBits(uint grfStateBits, uint grfMask)
        {
            if(m_SetStateBitsFunc==null){
                var fp = GetFunctionPointer(16);
                m_SetStateBitsFunc = (SetStateBitsFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetStateBitsFunc));
            } 
            return  m_SetStateBitsFunc(m_ptr, grfStateBits, grfMask);
        }
        delegate int SetStateBitsFunc(IntPtr self, uint grfStateBits, uint grfMask);
        SetStateBitsFunc m_SetStateBitsFunc;

        public int Stat(ref STATSTG pstatstg, uint grfStatFlag)
        {
            if(m_StatFunc==null){
                var fp = GetFunctionPointer(17);
                m_StatFunc = (StatFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(StatFunc));
            } 
            return  m_StatFunc(m_ptr, ref pstatstg, grfStatFlag);
        }
        delegate int StatFunc(IntPtr self, ref STATSTG pstatstg, uint grfStatFlag);
        StatFunc m_StatFunc;

    }
}
