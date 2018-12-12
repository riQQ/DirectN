﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddraw.h(1703,1)
using System;
using System.Runtime.InteropServices;
using LPDDSURFACEDESC = DirectN._DDSURFACEDESC;
using LPDIRECTDRAW = DirectN.IDirectDraw;
using LPDIRECTDRAWCLIPPER = DirectN.IDirectDrawClipper;
using LPDIRECTDRAWPALETTE = DirectN.IDirectDrawPalette;
using LPDIRECTDRAWSURFACE3 = DirectN.IDirectDrawSurface3;

namespace DirectN
{
    [Guid("da044e00-69b2-11d0-a1d5-00aa00b8dfbb"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectDrawSurface3
    {
        [PreserveSig]
        HRESULT AddAttachedSurface(LPDIRECTDRAWSURFACE3 __unnamed_0);
        
        [PreserveSig]
        HRESULT AddOverlayDirtyRect(ref tagRECT __unnamed_0);
        
        [PreserveSig]
        HRESULT Blt(ref tagRECT __unnamed_0, LPDIRECTDRAWSURFACE3 __unnamed_1, ref tagRECT __unnamed_2, uint __unnamed_3, ref _DDBLTFX __unnamed_4);
        
        [PreserveSig]
        HRESULT BltBatch(ref _DDBLTBATCH __unnamed_0, uint __unnamed_1, uint __unnamed_2);
        
        [PreserveSig]
        HRESULT BltFast(uint __unnamed_0, uint __unnamed_1, LPDIRECTDRAWSURFACE3 __unnamed_2, ref tagRECT __unnamed_3, uint __unnamed_4);
        
        [PreserveSig]
        HRESULT DeleteAttachedSurface(uint __unnamed_0, LPDIRECTDRAWSURFACE3 __unnamed_1);
        
        [PreserveSig]
        HRESULT EnumAttachedSurfaces(IntPtr __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT EnumOverlayZOrders(uint __unnamed_0, IntPtr __unnamed_1, IntPtr __unnamed_2);
        
        [PreserveSig]
        HRESULT Flip(LPDIRECTDRAWSURFACE3 __unnamed_0, uint __unnamed_1);
        
        [PreserveSig]
        HRESULT GetAttachedSurface(ref _DDSCAPS __unnamed_0, out LPDIRECTDRAWSURFACE3 __unnamed_1);
        
        [PreserveSig]
        HRESULT GetBltStatus(uint __unnamed_0);
        
        [PreserveSig]
        HRESULT GetCaps(ref _DDSCAPS __unnamed_0);
        
        [PreserveSig]
        HRESULT GetClipper(out LPDIRECTDRAWCLIPPER __unnamed_0);
        
        [PreserveSig]
        HRESULT GetColorKey(uint __unnamed_0, ref _DDCOLORKEY __unnamed_1);
        
        [PreserveSig]
        HRESULT GetDC(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT GetFlipStatus(uint __unnamed_0);
        
        [PreserveSig]
        HRESULT GetOverlayPosition(ref int __unnamed_0, ref int __unnamed_1);
        
        [PreserveSig]
        HRESULT GetPalette(out LPDIRECTDRAWPALETTE __unnamed_0);
        
        [PreserveSig]
        HRESULT GetPixelFormat(ref _DDPIXELFORMAT __unnamed_0);
        
        [PreserveSig]
        HRESULT GetSurfaceDesc(ref LPDDSURFACEDESC __unnamed_0);
        
        [PreserveSig]
        HRESULT Initialize(LPDIRECTDRAW __unnamed_0, ref LPDDSURFACEDESC __unnamed_1);
        
        [PreserveSig]
        HRESULT IsLost();
        
        [PreserveSig]
        HRESULT Lock(ref tagRECT __unnamed_0, ref LPDDSURFACEDESC __unnamed_1, uint __unnamed_2, IntPtr __unnamed_3);
        
        [PreserveSig]
        HRESULT ReleaseDC(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT Restore();
        
        [PreserveSig]
        HRESULT SetClipper(LPDIRECTDRAWCLIPPER __unnamed_0);
        
        [PreserveSig]
        HRESULT SetColorKey(uint __unnamed_0, ref _DDCOLORKEY __unnamed_1);
        
        [PreserveSig]
        HRESULT SetOverlayPosition(int __unnamed_0, int __unnamed_1);
        
        [PreserveSig]
        HRESULT SetPalette(LPDIRECTDRAWPALETTE __unnamed_0);
        
        [PreserveSig]
        HRESULT Unlock(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT UpdateOverlay(ref tagRECT __unnamed_0, LPDIRECTDRAWSURFACE3 __unnamed_1, ref tagRECT __unnamed_2, uint __unnamed_3, ref _DDOVERLAYFX __unnamed_4);
        
        [PreserveSig]
        HRESULT UpdateOverlayDisplay(uint __unnamed_0);
        
        [PreserveSig]
        HRESULT UpdateOverlayZOrder(uint __unnamed_0, LPDIRECTDRAWSURFACE3 __unnamed_1);
        
        [PreserveSig]
        HRESULT GetDDInterface([MarshalAs(UnmanagedType.IUnknown)] object __unnamed_0);
        
        [PreserveSig]
        HRESULT PageLock(uint __unnamed_0);
        
        [PreserveSig]
        HRESULT PageUnlock(uint __unnamed_0);
        
        [PreserveSig]
        HRESULT SetSurfaceDesc(ref LPDDSURFACEDESC __unnamed_0, uint __unnamed_1);
    }
}
