﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva2swdev.h(60,9)
using System;
using System.Runtime.InteropServices;
using RECT = DirectN.tagRECT;
using SIZE = DirectN.tagSIZE;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA2_VIDEOPROCESSBLT
    {
        public int TargetFrame;
        public RECT TargetRect;
        public SIZE ConstrictionSize;
        public uint StreamingFlags;
        public int BackgroundColor;
        public int DestFormat;
        public uint DestFlags;
        public int ProcAmpValues;
        public int Alpha;
        public int NoiseFilterLuma;
        public int NoiseFilterChroma;
        public int DetailFilterLuma;
        public int DetailFilterChroma;
        public IntPtr pSrcSurfaces;
        public uint NumSrcSurfaces;
    }
}