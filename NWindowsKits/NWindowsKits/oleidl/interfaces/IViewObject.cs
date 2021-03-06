// This source code was generated by ClangCaster
using System;
using System.Runtime.InteropServices;

namespace NWindowsKits
{
    // C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/oleidl.h:2911
    public class IViewObject : IUnknown
    {
        static Guid s_uuid = new Guid("0000010d-0000-0000-c000-000000000046");
        public static new ref Guid IID => ref s_uuid;
        public override ref Guid GetIID() { return ref s_uuid; }

        public int Draw(uint dwDrawAspect, int lindex, IntPtr pvAspect, ref DVTARGETDEVICE ptd, HDC hdcTargetDev, HDC hdcDraw, ref RECTL lprcBounds, ref RECTL lprcWBounds, IntPtr pfnContinue, ulong dwContinue)
        {
            if(m_DrawFunc==null){
                var fp = GetFunctionPointer(3);
                m_DrawFunc = (DrawFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(DrawFunc));
            } 
            return  m_DrawFunc(m_ptr, dwDrawAspect, lindex, pvAspect, ref ptd, hdcTargetDev, hdcDraw, ref lprcBounds, ref lprcWBounds, pfnContinue, dwContinue);
        }
        delegate int DrawFunc(IntPtr self, uint dwDrawAspect, int lindex, IntPtr pvAspect, ref DVTARGETDEVICE ptd, HDC hdcTargetDev, HDC hdcDraw, ref RECTL lprcBounds, ref RECTL lprcWBounds, IntPtr pfnContinue, ulong dwContinue);
        DrawFunc m_DrawFunc;

        public int GetColorSet(uint dwDrawAspect, int lindex, IntPtr pvAspect, ref DVTARGETDEVICE ptd, HDC hicTargetDev, ref IntPtr ppColorSet)
        {
            if(m_GetColorSetFunc==null){
                var fp = GetFunctionPointer(4);
                m_GetColorSetFunc = (GetColorSetFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetColorSetFunc));
            } 
            return  m_GetColorSetFunc(m_ptr, dwDrawAspect, lindex, pvAspect, ref ptd, hicTargetDev, ref ppColorSet);
        }
        delegate int GetColorSetFunc(IntPtr self, uint dwDrawAspect, int lindex, IntPtr pvAspect, ref DVTARGETDEVICE ptd, HDC hicTargetDev, ref IntPtr ppColorSet);
        GetColorSetFunc m_GetColorSetFunc;

        public int Freeze(uint dwDrawAspect, int lindex, IntPtr pvAspect, ref uint pdwFreeze)
        {
            if(m_FreezeFunc==null){
                var fp = GetFunctionPointer(5);
                m_FreezeFunc = (FreezeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(FreezeFunc));
            } 
            return  m_FreezeFunc(m_ptr, dwDrawAspect, lindex, pvAspect, ref pdwFreeze);
        }
        delegate int FreezeFunc(IntPtr self, uint dwDrawAspect, int lindex, IntPtr pvAspect, ref uint pdwFreeze);
        FreezeFunc m_FreezeFunc;

        public int Unfreeze(uint dwFreeze)
        {
            if(m_UnfreezeFunc==null){
                var fp = GetFunctionPointer(6);
                m_UnfreezeFunc = (UnfreezeFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(UnfreezeFunc));
            } 
            return  m_UnfreezeFunc(m_ptr, dwFreeze);
        }
        delegate int UnfreezeFunc(IntPtr self, uint dwFreeze);
        UnfreezeFunc m_UnfreezeFunc;

        public int SetAdvise(uint aspects, uint advf, IntPtr pAdvSink)
        {
            if(m_SetAdviseFunc==null){
                var fp = GetFunctionPointer(7);
                m_SetAdviseFunc = (SetAdviseFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(SetAdviseFunc));
            } 
            return  m_SetAdviseFunc(m_ptr, aspects, advf, pAdvSink);
        }
        delegate int SetAdviseFunc(IntPtr self, uint aspects, uint advf, IntPtr pAdvSink);
        SetAdviseFunc m_SetAdviseFunc;

        public int GetAdvise(ref uint pAspects, ref uint pAdvf, ref IntPtr ppAdvSink)
        {
            if(m_GetAdviseFunc==null){
                var fp = GetFunctionPointer(8);
                m_GetAdviseFunc = (GetAdviseFunc)Marshal.GetDelegateForFunctionPointer(fp, typeof(GetAdviseFunc));
            } 
            return  m_GetAdviseFunc(m_ptr, ref pAspects, ref pAdvf, ref ppAdvSink);
        }
        delegate int GetAdviseFunc(IntPtr self, ref uint pAspects, ref uint pAdvf, ref IntPtr ppAdvSink);
        GetAdviseFunc m_GetAdviseFunc;

    }
}
