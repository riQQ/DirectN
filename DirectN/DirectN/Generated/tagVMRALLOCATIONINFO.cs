﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\strmif.h(18649,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagVMRALLOCATIONINFO
    {
        public uint dwFlags;
        public IntPtr lpHdr;
        public IntPtr lpPixFmt;
        public tagSIZE szAspectRatio;
        public uint dwMinBuffers;
        public uint dwMaxBuffers;
        public uint dwInterlaceFlags;
        public tagSIZE szNativeSize;
    }
}
