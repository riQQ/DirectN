﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dumddi.h(4141,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDICB_SUBMITSIGNALSYNCOBJECTSTOHWQUEUE
    {
        public _D3DDDICB_SIGNALFLAGS Flags;
        public uint BroadcastHwQueueCount;
        public IntPtr BroadcastHwQueueArray;
        public uint ObjectCount;
        public IntPtr ObjectHandleArray;
        public IntPtr FenceValueArray;
    }
}
