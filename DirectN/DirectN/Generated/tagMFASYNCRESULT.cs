﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfapi.h(386,9)
using System;
using System.Runtime.InteropServices;
using OVERLAPPED = DirectN._OVERLAPPED;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagMFASYNCRESULT
    {
        public OVERLAPPED overlapped;
        public IntPtr pCallback;
        public HRESULT hrStatusResult;
        public uint dwBytesTransferred;
        public IntPtr hEvent;
    }
}