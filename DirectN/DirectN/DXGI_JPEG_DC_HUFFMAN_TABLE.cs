﻿using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DXGI_JPEG_DC_HUFFMAN_TABLE
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public byte[] CodeCounts;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public byte[] CodeValues;
    }
}
