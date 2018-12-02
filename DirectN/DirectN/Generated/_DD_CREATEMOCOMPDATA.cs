﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawint.h(1825,9)
using System;
using System.Runtime.InteropServices;
using DDPIXELFORMAT = DirectN._DDPIXELFORMAT;
using PDD_DIRECTDRAW_LOCAL = DirectN._DD_DIRECTDRAW_LOCAL;
using PDD_MOTIONCOMP_LOCAL = DirectN._DD_MOTIONCOMP_LOCAL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_CREATEMOCOMPDATA
    {
        public IntPtr lpDD;
        public IntPtr lpMoComp;
        public IntPtr lpGuid;
        public uint dwUncompWidth;
        public uint dwUncompHeight;
        public DDPIXELFORMAT ddUncompPixelFormat;
        public IntPtr lpData;
        public uint dwDataSize;
        public HRESULT ddRVal;
    }
}