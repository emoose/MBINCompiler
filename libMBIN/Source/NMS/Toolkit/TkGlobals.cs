using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x218, GUID = 0x3BD5B163E6D81E47, NameHash = 0xB62E6456DFE47836)]
    public class TkGlobals : NMSTemplate
    {
        public enum AssertsLevelsEnum { DIsabled, Ignored, Skipped, Enabled }
        /* 0x000 */ public AssertsLevelsEnum AssertsLevels;
        /* 0x004 */ public bool DefaultSelectIgnoreAsserts;
        [Flags]
        public enum EnabledChannelsEnum
        {
            None = 0x00, Default = 0x01, Note = 0x02, Error = 0x04, Warning = 0x08, Info = 0x10,
            Alt = 0x20, AltWarn = 0x40, AltError = 0x80
        }
        /* 0x008 */ public EnabledChannelsEnum EnabledChannels;
        [NMS(Size = 0x100)]
        /* 0x00C */ public string IncludeLogFilter;
        [NMS(Size = 0x100)]
        /* 0x10C */ public string ExcludeLogFilter;
        /* 0x20C */ public int LoadBalanceTimeoutMS;
        /* 0x210 */ public int VRLoadBalanceTimeoutMS;
        /* 0x214 */ public bool LogInputSetup;
        /* 0x215 */ public bool LogInputChanges;
        /* 0x216 */ public bool DisableResScaling;
        [NMS(Size = 0x1, Ignore = true)]
        /* 0x217 */ public byte[] EndPadding;
    }
}
