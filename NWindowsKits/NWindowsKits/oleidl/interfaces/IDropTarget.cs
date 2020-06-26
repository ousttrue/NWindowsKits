// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/oleidl.h:3507
    public class IDropTarget : IUnknown
    {
        static Guid s_uuid = new Guid("00000122-0000-0000-c000-000000000046");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int DragEnter(IntPtr pDataObj, uint grfKeyState, POINTL pt, ref uint pdwEffect)
        {
            if(m_DragEnterFunc==null){
                var fp = GetFunctionPointer(3);
                m_DragEnterFunc = (DragEnterFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DragEnterFunc));
            } 
            return  m_DragEnterFunc(m_ptr, pDataObj, grfKeyState, pt, ref pdwEffect);
        }
        delegate int DragEnterFunc(IntPtr self, IntPtr pDataObj, uint grfKeyState, POINTL pt, ref uint pdwEffect);
        DragEnterFunc m_DragEnterFunc;

        public int DragOver(uint grfKeyState, POINTL pt, ref uint pdwEffect)
        {
            if(m_DragOverFunc==null){
                var fp = GetFunctionPointer(4);
                m_DragOverFunc = (DragOverFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DragOverFunc));
            } 
            return  m_DragOverFunc(m_ptr, grfKeyState, pt, ref pdwEffect);
        }
        delegate int DragOverFunc(IntPtr self, uint grfKeyState, POINTL pt, ref uint pdwEffect);
        DragOverFunc m_DragOverFunc;

        public int DragLeave()
        {
            if(m_DragLeaveFunc==null){
                var fp = GetFunctionPointer(5);
                m_DragLeaveFunc = (DragLeaveFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DragLeaveFunc));
            } 
            return  m_DragLeaveFunc(m_ptr);
        }
        delegate int DragLeaveFunc(IntPtr self);
        DragLeaveFunc m_DragLeaveFunc;

        public int Drop(IntPtr pDataObj, uint grfKeyState, POINTL pt, ref uint pdwEffect)
        {
            if(m_DropFunc==null){
                var fp = GetFunctionPointer(6);
                m_DropFunc = (DropFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DropFunc));
            } 
            return  m_DropFunc(m_ptr, pDataObj, grfKeyState, pt, ref pdwEffect);
        }
        delegate int DropFunc(IntPtr self, IntPtr pDataObj, uint grfKeyState, POINTL pt, ref uint pdwEffect);
        DropFunc m_DropFunc;

    }
}
