using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x1A8, GUID = 0xD791CA7676523D22, NameHash = 0x08DDF831D46F0A7E)]
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
        public enum VsyncExEnum { Off, On, Adaptive, Triple }
        /* 0x02C */ public VsyncExEnum VsyncEx;
        /* 0x030 */ public TkGraphicsDetailPreset GraphicsDetail;
        /* 0x06C */ public float MotionBlurStrength;
        /* 0x070 */ public bool VignetteAndScanlines;
        /* 0x074 */ public float FoVOnFoot;
        /* 0x078 */ public float FoVInShip;
        /* 0x07C */ public int Brightness;
        /* 0x080 */ public int MaxframeRate;
        /* 0x084 */ public int NumHighThreads;
        /* 0x088 */ public int NumLowThreads;
        // size: 0x4
        public enum TextureStreamingVkEnum { Off, On, Auto, NonDynamic }
        /* 0x08C */ public TextureStreamingVkEnum TextureStreamingVk;
        /* 0x090 */ public bool ShowRequirementsWarnings;
        /* 0x091 */ public bool RemoveBaseBuildingRestrictions;
        /* 0x094 */ public float MouseClickSpeedMultiplier;
        /* 0x098 */ public bool UseTerrainTextureCache;
        /* 0x099 */ public bool UseArbSparseTexture;
        // size: 0x4
        public enum HDRModeEnum { Off, HDR400, HDR600, HDR1000 }
        /* 0x09C */ public HDRModeEnum HDRMode;
        /* 0x0A0 */ public NMSString0x100 AdapterName;
        /* 0x1A0 */ public int AdapterIndex;
        /* 0x1A4 */ public int NumGraphicsThreadsBeta;
    }
}
