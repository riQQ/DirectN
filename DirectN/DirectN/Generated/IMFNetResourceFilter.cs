﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\mfidl.h(11856,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("091878a3-bf11-4a5c-bc9f-33995b06ef2d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFNetResourceFilter
    {
        [PreserveSig]
        HRESULT OnRedirect(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pszUrl, /* [annotation][out] _Out_ */ out bool pvbCancel);
        
        [PreserveSig]
        HRESULT OnSendingRequest(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pszUrl);
    }
}
