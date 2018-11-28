﻿using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    // dxgi1_2.h
    [Guid("00cddea8-939b-4b83-a340-a685226666cc"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIOutput1 : IDXGIOutput
    {
        // IDXGIObject
        [PreserveSig]
        new HRESULT SetPrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid Name, int DataSize, IntPtr pData);

        [PreserveSig]
        new HRESULT SetPrivateDataInterface([MarshalAs(UnmanagedType.LPStruct)] Guid Name, [MarshalAs(UnmanagedType.IUnknown)] object pUnknown);

        [PreserveSig]
        new HRESULT GetPrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid Name, out int pDataSize, IntPtr pData);

        [PreserveSig]
        new HRESULT GetParent([MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppParent);

        // IDXGIOutput
        [PreserveSig]
        new HRESULT GetDesc(out DXGI_OUTPUT_DESC pDesc);

        [PreserveSig]
        new HRESULT GetDisplayModeList(
            DXGI_FORMAT EnumFormat,
            DXGI_ENUM_MODES Flags,
            ref int pNumModes,
            [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)]
            DXGI_MODE_DESC[] pDesc);

        [PreserveSig]
        new HRESULT FindClosestMatchingMode(ref DXGI_MODE_DESC pModeToMatch, out DXGI_MODE_DESC pClosestMatch, [MarshalAs(UnmanagedType.IUnknown)] object pConcernedDevice);

        [PreserveSig]
        new HRESULT WaitForVBlank();

        [PreserveSig]
        new HRESULT TakeOwnership([MarshalAs(UnmanagedType.IUnknown)] object pDevice, bool Exclusive);

        [PreserveSig]
        new void ReleaseOwnership();

        [PreserveSig]
        new HRESULT GetGammaControlCapabilities(out DXGI_GAMMA_CONTROL_CAPABILITIES pGammaCaps);

        [PreserveSig]
        new HRESULT SetGammaControl(ref DXGI_GAMMA_CONTROL pArray);

        [PreserveSig]
        new HRESULT GetGammaControl(out DXGI_GAMMA_CONTROL pArray);

        [PreserveSig]
        new HRESULT SetDisplaySurface(IDXGISurface pScanoutSurface);

        [PreserveSig]
        new HRESULT GetDisplaySurfaceData(IDXGISurface pDestination);

        [PreserveSig]
        new HRESULT GetFrameStatistics(out DXGI_FRAME_STATISTICS pStats);

        // IDXGIOutput1
        [PreserveSig]
        HRESULT GetDisplayModeList1(
            DXGI_FORMAT EnumFormat,
            DXGI_ENUM_MODES Flags,
            ref int pNumModes,
            [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)]
            DXGI_MODE_DESC1[] pDesc);

        [PreserveSig]
        HRESULT FindClosestMatchingMode1(ref DXGI_MODE_DESC1 pModeToMatch, out DXGI_MODE_DESC1 pClosestMatch, [MarshalAs(UnmanagedType.IUnknown)] object pConcernedDevice);

        [PreserveSig]
        HRESULT GetDisplaySurfaceData1(IDXGIResource pDestination);

        [PreserveSig]
        HRESULT DuplicateOutput([MarshalAs(UnmanagedType.IUnknown)] object pDevice, out IDXGIOutputDuplication ppOutputDuplication);
    }
}