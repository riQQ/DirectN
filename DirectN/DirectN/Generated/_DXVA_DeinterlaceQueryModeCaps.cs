﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva9typ.h(626,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA_DeinterlaceQueryModeCaps
    {
        public uint Size;
        public Guid Guid;
        public _DXVA_VideoDesc VideoDesc;
    }
}