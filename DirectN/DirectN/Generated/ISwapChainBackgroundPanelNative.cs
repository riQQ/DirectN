﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\windows.ui.xaml.media.dxinterop.h(503,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("43bebd4e-add5-4035-8f85-5608d08e9dc9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ISwapChainBackgroundPanelNative
    {
        [PreserveSig]
        HRESULT SetSwapChain(/* [annotation][in] _In_ */ IDXGISwapChain swapChain);
    }
}
