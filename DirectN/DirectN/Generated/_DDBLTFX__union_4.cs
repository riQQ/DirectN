﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddraw.h(313,5)
using System;
using System.Runtime.InteropServices;
using LPDIRECTDRAWSURFACE = DirectN.IDirectDrawSurface;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDBLTFX__union_4
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] __bits;
        public uint dwFillColor => InteropRuntime.GetUInt32Bits(__bits, 0, 32);
        public uint dwFillDepth => InteropRuntime.GetUInt32Bits(__bits, 0, 32);
        public uint dwFillPixel => InteropRuntime.GetUInt32Bits(__bits, 0, 32);
        public IntPtr lpDDSPattern => InteropRuntime.GetBits<IntPtr>(__bits, 0, 64);
    }
}