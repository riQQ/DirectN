﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmdt.h(2167,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXGK_FAULT_ERROR_CODE__union_0__struct_1
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint IsDeviceSpecificCodeReservedBit { get => InteropRuntime.GetUInt32(__bits, 0, 1); set => InteropRuntime.SetUInt32(value, __bits, 0, 1); }
        public uint DeviceSpecificCode { get => InteropRuntime.GetUInt32(__bits, 1, 31); set => InteropRuntime.SetUInt32(value, __bits, 1, 31); }
    }
}