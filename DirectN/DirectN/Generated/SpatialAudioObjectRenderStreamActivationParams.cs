﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\spatialaudioclient.h(137,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct SpatialAudioObjectRenderStreamActivationParams
    {
        public IntPtr ObjectFormat;
        public AudioObjectType StaticObjectTypeMask;
        public uint MinDynamicObjectCount;
        public uint MaxDynamicObjectCount;
        public _AUDIO_STREAM_CATEGORY Category;
        public IntPtr EventHandle;
        public IntPtr NotifyObject;
    }
}
