namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x3293706C84E09F2F, NameHash = 0xB62E6456DFE47836)]
    public class TkGlobals : NMSTemplate
    {
        // size: 0x4
        public enum AssertsLevelEnum {
            Disabled,
            Ignored,
            Skipped,
            Enabled
        }
        /* 0x000 */ public AssertsLevelEnum AssertsLevel;
        /* 0x004 */ public bool DefaultSelectIgnoreAsserts;
        // size: 0x9
        public enum EnabledChannelsEnum : uint {
            None = 0x0,
            Default = 0x1,
            Note = 0x2,
            Error = 0x4,
            Warning = 0x8,
            Info = 0x10,
            Alt = 0x20,
            AltWarn = 0x40,
            AltError = 0x80
        }
        /* 0x008 */ public EnabledChannelsEnum EnabledChannels;
        /* 0x00C */ public NMSString0x100 IncludeLogFilter;
        /* 0x10C */ public NMSString0x100 ExcludeLogFilter;
        /* 0x20C */ public int LoadBalanceTimeoutMS;
        /* 0x210 */ public int VRLoadBalanceTimeoutMS;
        /* 0x214 */ public bool LogInputSetup;
        /* 0x215 */ public bool LogInputChanges;
        /* 0x216 */ public bool DisableResScaling;
        /* 0x218 */ public float WwiseVibrationMultiplierPrimary;
        /* 0x21C */ public float WwiseVibrationMultiplierSecondary;
        /* 0x220 */ public bool DisableMultiplayer;
    }
}
