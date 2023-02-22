using System;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x91DC0B006B334CE8, NameHash = 0xB62E6456DFE47836)]
    public class TkGlobals : NMSTemplate
    {
        // size: 0x4
        public enum AssertsLevelEnum {
            Disabled,
            Ignored,
            Skipped,
            Enabled,
        }
        /* 0x000 */ public AssertsLevelEnum AssertsLevel;
        /* 0x004 */ public bool DefaultSelectIgnoreAsserts;
        // size: 0x9
        [Flags]
        public enum EnabledChannelsEnum : uint {
            None = 0x0,
            Default = 0x1,
            Note = 0x2,
            Error = 0x4,
            Warning = 0x8,
            Info = 0x10,
            Alt = 0x20,
            AltWarn = 0x40,
            AltError = 0x80,
        }
        /* 0x008 */ public EnabledChannelsEnum EnabledChannels;
        /* 0x00C */ public NMSString0x100 IncludeLogFilter;
        /* 0x10C */ public NMSString0x100 ExcludeLogFilter;
        /* 0x20C */ public int LoadBalanceTimeoutMS;
        /* 0x210 */ public int VRLoadBalanceTimeoutMS;
        /* 0x214 */ public int PSVR2LoadBalanceTimeoutMS;
        /* 0x218 */ public bool LogInputSetup;
        /* 0x219 */ public bool LogInputChanges;
        /* 0x21A */ public bool DisableResScaling;
        /* 0x21C */ public int LODOverride;
        /* 0x220 */ public bool ColourLODs;
        /* 0x224 */ public float WwiseVibrationMultiplierPrimary;
        /* 0x228 */ public float WwiseVibrationMultiplierSecondary;
        /* 0x22C */ public bool UseHeavyAir;
        /* 0x22D */ public bool SimulateDisabledParticleRefractions;
        /* 0x22E */ public bool DisableMultiplayer;
    }
}
