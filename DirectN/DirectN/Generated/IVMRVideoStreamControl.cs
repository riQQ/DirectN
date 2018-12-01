﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(20321,5)
using System;
using System.Runtime.InteropServices;
using LPDDCOLORKEY = DirectN._DDCOLORKEY;

namespace DirectN
{
    [Guid("058d1f11-2a54-4bef-bd54-df706626b727"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IVMRVideoStreamControl
    {
        [PreserveSig]
        HRESULT SetColorKey(/* [in] */ ref LPDDCOLORKEY lpClrKey);
        
        [PreserveSig]
        HRESULT GetColorKey(/* [out] */ out LPDDCOLORKEY lpClrKey);
        
        [PreserveSig]
        HRESULT SetStreamActiveState(/* [in] */ bool fActive);
        
        [PreserveSig]
        HRESULT GetStreamActiveState(/* [out] */ out bool lpfActive);
    }
}