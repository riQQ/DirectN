﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxcapi.h(207,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("a005a9d9-b8bb-4594-b5c9-0e633bec4d37"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDxcCompiler2 : IDxcCompiler
    {
        // IDxcCompiler
        [PreserveSig]
        new HRESULT Compile(/* _In_ */ IDxcBlob pSource, /* // Source text to compile _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string pSourceName, /* // Optional file name for pSource. Used in errors and include handlers. _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pEntryPoint, /* // entry point name _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pTargetProfile, /* // shader profile to compile _In_count_(argCount) */ IntPtr pArguments, /* // Array of pointers to arguments _In_ */ uint argCount, /* // Number of arguments _In_count_(defineCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 7)] DxcDefine[] pDefines, /* // Array of defines _In_ */ uint defineCount, /* // Number of defines _In_opt_ */ IDxcIncludeHandler pIncludeHandler, /* // user-provided interface to handle #include directives (optional) _COM_Outptr_ */ out IDxcOperationResult ppResult);
        
        [PreserveSig]
        new HRESULT Preprocess(/* _In_ */ IDxcBlob pSource, /* // Source text to preprocess _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string pSourceName, /* // Optional file name for pSource. Used in errors and include handlers. _In_count_(argCount) */ IntPtr pArguments, /* // Array of pointers to arguments _In_ */ uint argCount, /* // Number of arguments _In_count_(defineCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] DxcDefine[] pDefines, /* // Array of defines _In_ */ uint defineCount, /* // Number of defines _In_opt_ */ IDxcIncludeHandler pIncludeHandler, /* // user-provided interface to handle #include directives (optional) _COM_Outptr_ */ out IDxcOperationResult ppResult);
        
        [PreserveSig]
        new HRESULT Disassemble(/* _In_ */ IDxcBlob pSource, /* // Program to disassemble. _COM_Outptr_ */ out IDxcBlobEncoding ppDisassembly);
        
        // IDxcCompiler2
        [PreserveSig]
        HRESULT CompileWithDebug(/* _In_ */ IDxcBlob pSource, /* // Source text to compile _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string pSourceName, /* // Optional file name for pSource. Used in errors and include handlers. _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pEntryPoint, /* // Entry point name _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pTargetProfile, /* // Shader profile to compile _In_count_(argCount) */ IntPtr pArguments, /* // Array of pointers to arguments _In_ */ uint argCount, /* // Number of arguments _In_count_(defineCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 7)] DxcDefine[] pDefines, /* // Array of defines _In_ */ uint defineCount, /* // Number of defines _In_opt_ */ IDxcIncludeHandler pIncludeHandler, /* // user-provided interface to handle #include directives (optional) _COM_Outptr_ */ out IDxcOperationResult ppResult, /* optional(LPWSTR) */ out IntPtr ppDebugBlobName, /* // Suggested file name for debug blob. _COM_Outptr_opt_ */ out IDxcBlob ppDebugBlob);
    }
}