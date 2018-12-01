﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(5101,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("b79bb0b0-33c1-11d1-abe1-00a0c905f375"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IFilterMapper2
    {
        [PreserveSig]
        HRESULT CreateCategory(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid clsidCategory, /* [in] */ uint dwCategoryMerit, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string Description);
        
        [PreserveSig]
        HRESULT UnregisterFilter(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid pclsidCategory, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string szInstance, /* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid Filter);
        
        [PreserveSig]
        HRESULT RegisterFilter(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid clsidFilter, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string Name, /* [annotation][out][in] _Inout_opt_ */ ref IMoniker ppMoniker, /* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid pclsidCategory, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string szInstance, /* [in] */ ref REGFILTER2 prf2);
        
        [PreserveSig]
        HRESULT EnumMatchingFilters(/* [annotation][out] _Out_ */ out IntPtr ppEnum, /* [in] */ uint dwFlags, /* [in] */ bool bExactMatch, /* [in] */ uint dwMerit, /* [in] */ bool bInputNeeded, /* [in] */ uint cInputTypes, /* [annotation][size_is] _In_reads_opt_(cInputTypes * 2) */ [MarshalAs(UnmanagedType.LPStruct)] Guid pInputTypes, /* optional(REGPINMEDIUM) */ IntPtr pMedIn, /* [annotation][in] _In_opt_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pPinCategoryIn, /* [in] */ bool bRender, /* [in] */ bool bOutputNeeded, /* [in] */ uint cOutputTypes, /* [annotation][size_is] _In_reads_opt_(cOutputTypes * 2) */ [MarshalAs(UnmanagedType.LPStruct)] Guid pOutputTypes, /* optional(REGPINMEDIUM) */ IntPtr pMedOut, /* [annotation][in] _In_opt_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pPinCategoryOut);
    }
}