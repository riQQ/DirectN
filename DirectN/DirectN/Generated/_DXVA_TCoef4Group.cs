﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dxva.h(454,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_TCoef4Group
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public byte[] TCoefIDX;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public short[] TCoefValue;
    }
}
