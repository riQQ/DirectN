﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dxgiddi.h(491,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGI_DDI_ARG_CHECKPRESENTDURATIONSUPPORT
    {
        public ulong hDevice;
        public uint VidPnSourceId;
        public uint DesiredPresentDuration;
        public uint ClosestSmallerDuration;
        public uint ClosestLargerDuration;
    }
}
