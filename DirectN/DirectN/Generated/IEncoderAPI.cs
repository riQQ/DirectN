﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(16993,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("70423839-6acc-4b23-b079-21dbf08156a5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IEncoderAPI
    {
        [PreserveSig]
        HRESULT IsSupported(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid Api);
        
        [PreserveSig]
        HRESULT IsAvailable(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid Api);
        
        [PreserveSig]
        HRESULT GetParameterRange(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid Api, /* [annotation][out] _Out_ */ out object ValueMin, /* [annotation][out] _Out_ */ out object ValueMax, /* [annotation][out] _Out_ */ out object SteppingDelta);
        
        [PreserveSig]
        HRESULT GetParameterValues(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid Api, /* [annotation][size_is][size_is][out] _Outptr_result_buffer_all_(*ValuesCount) */ [MarshalAs(UnmanagedType.IUnknown)] out object Values, /* [annotation][out] _Out_ */ out uint ValuesCount);
        
        [PreserveSig]
        HRESULT GetDefaultValue(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid Api, /* [annotation][out] _Out_ */ out object Value);
        
        [PreserveSig]
        HRESULT GetValue(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid Api, /* [annotation][out] _Out_ */ out object Value);
        
        [PreserveSig]
        HRESULT SetValue(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid Api, /* [annotation][in] _In_ */ object Value);
    }
}