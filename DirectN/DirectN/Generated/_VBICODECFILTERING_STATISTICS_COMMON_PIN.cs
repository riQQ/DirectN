﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\ksmedia.h(4685,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _VBICODECFILTERING_STATISTICS_COMMON_PIN
    {
        public uint SRBsProcessed;
        public uint SRBsIgnored;
        public uint SRBsMissing;
        public uint InternalErrors;
        public uint ExternalErrors;
        public uint Discontinuities;
        public uint LineConfidenceAvg;
        public uint BytesOutput;
    }
}
