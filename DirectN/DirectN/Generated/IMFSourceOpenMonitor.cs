﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\mfidl.h(11968,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("059054b3-027c-494c-a27d-9113291cf87f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSourceOpenMonitor
    {
        [PreserveSig]
        HRESULT OnSourceEvent(/* [in] __RPC__in_opt */ IMFMediaEvent pEvent);
    }
}
