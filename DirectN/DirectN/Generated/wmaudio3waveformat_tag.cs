﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\mmreg.h(3278,9)
using System;
using System.Runtime.InteropServices;
using WAVEFORMATEX = DirectN.tWAVEFORMATEX;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct wmaudio3waveformat_tag
    {
        public WAVEFORMATEX wfx;
        public ushort wValidBitsPerSample;
        public uint dwChannelMask;
        public uint dwReserved1;
        public uint dwReserved2;
        public ushort wEncodeOptions;
        public ushort wReserved3;
    }
}