﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dcomp.h(1873,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("a08debda-3258-4fa4-9f16-9174d3fe93b1"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDCompositionSaturationEffect : IDCompositionFilterEffect
    {
        // IDCompositionEffect
        
        // IDCompositionFilterEffect
        [PreserveSig]
        new HRESULT SetInput(/* THIS_ _In_ */ uint index, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object input, /* _In_ */ uint flags);
        
        // IDCompositionSaturationEffect
        [PreserveSig]
        HRESULT SetSaturation(/* THIS_ _In_ */ float ratio);
        
        [PreserveSig]
        HRESULT SetSaturation(/* THIS_ _In_ */ IDCompositionAnimation animation);
    }
}
