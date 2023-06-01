using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x4DA3AF739FE447F4, NameHash = 0x8DDF831D46F0A7E)]
    public class TkGraphicsSettings : NMSTemplate
    {
        /* 0x000 */ public int Version;
        /* 0x004 */ public bool FullScreen;
        /* 0x005 */ public bool Borderless;
        /* 0x008 */ public int Monitor;
        /* 0x010 */ public List<NMSString0x100> MonitorNames;
        /* 0x020 */ public int ResolutionWidth;
        /* 0x024 */ public int ResolutionHeight;
        /* 0x028 */ public float ResolutionScale;
        // size: 0x4
        public enum VsyncExEnum : uint {
            Off,
            On,
            Adaptive,
            Triple,
        }
        /* 0x02C */ public VsyncExEnum VsyncEx;
        /* 0x030 */ public TkGraphicsDetailPreset GraphicsDetail;
        /* 0x084 */ public float MotionBlurStrength;
        /* 0x088 */ public bool VignetteAndScanlines;
        /* 0x08C */ public float FoVOnFoot;
        /* 0x090 */ public float FoVInShip;
        /* 0x094 */ public int Brightness;
        /* 0x098 */ public int MaxframeRate;
        /* 0x09C */ public int NumHighThreads;
        /* 0x0A0 */ public int NumLowThreads;
        // size: 0x4
        public enum TextureStreamingVkEnum : uint {
            Off,
            On,
            Auto,
            NonDynamic,
        }
        /* 0x0A4 */ public TextureStreamingVkEnum TextureStreamingVk;
        /* 0x0A8 */ public bool ShowRequirementsWarnings;
        /* 0x0A9 */ public bool RemoveBaseBuildingRestrictions;
        /* 0x0AC */ public float MouseClickSpeedMultiplier;
        /* 0x0B0 */ public bool UseTerrainTextureCache;
        /* 0x0B1 */ public bool UseArbSparseTexture;
        // size: 0x4
        public enum HDRModeEnum : uint {
            Off,
            HDR400,
            HDR600,
            HDR1000,
        }
        /* 0x0B4 */ public HDRModeEnum HDRMode;
        /* 0x0B8 */ public NMSString0x100 AdapterName;
        /* 0x1B8 */ public int AdapterIndex;
        /* 0x1BC */ public int NumGraphicsThreadsBeta;
    }
}
