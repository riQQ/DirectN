﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d11.h(7383,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_FEATURE_DATA_SHADER_MIN_PRECISION_SUPPORT
    {
        public uint PixelShaderMinPrecision;
        public uint AllOtherShaderStagesMinPrecision;
    }
}
