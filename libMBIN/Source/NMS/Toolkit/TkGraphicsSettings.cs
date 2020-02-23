using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x198, GUID = 0x2D17E33EFF5835EF, NameHash = 0x8DDF831D46F0A7E)]
    public class TkGraphicsSettings : NMSTemplate
    {
        /* 0x00 */ public int Version;
		/* 0x04 */ public bool FullScreen;
        /* 0x05 */ public bool Borderless;
        /* 0x08 */ public int Monitor;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0C */ public byte[] PaddingC;
        /* 0x10 */ public List<NMSString0x100> TkMonitorNames;
        /* 0x20 */ public int ResolutionWidth;
        /* 0x24 */ public int ResolutionHeight;
        /* 0x28 */ public float ResolutionScale;
		public enum VsyncExEnum { Off, On, Adaptive, Triple }
        /* 0x2C */ public VsyncExEnum VsyncEx;
        /* 0x30 */ public TkGraphicsDetailPreset GraphicsDetail;
        /* 0x5C */ public float MotionBlurStrength;
        /* 0x60 */ public bool VignetteAndScanlines;
        /* 0x64 */ public float FoVOnFoot;
        /* 0x68 */ public float FoVInShip;
        /* 0x6C */ public int Brightness;
        /* 0x70 */ public int MaxframeRate;
		/* 0x74 */ public int NumHighThreads;
		/* 0x78 */ public int NumLowThreads;
		public enum TextureStreamingVkEnum { Off, On, Auto, NonDynamic }
		/* 0x7C */ public TextureStreamingVkEnum TextureStreamingVk;
		/* 0x80 */ public bool ShowRequirementsWarnings;
		/* 0x81 */ public bool RemoveBaseBuildingRestrictions;
        /* 0x84 */ public float MouseClickSpeedMultiplier;
        /* 0x88 */ public bool UseTerrainTextureCache;
        /* 0x89 */ public bool UseArbSparseTexture;
        public enum HDRModeEnum { Off, HDR400, HDR600, HDR1000 }
        /* 0x8C */ public HDRModeEnum HDRMode;
        [NMS(Size = 0x100)]
        /* 0x90 */ public string AdapterName;
        /* 0x190 */ public int AdapterIndex;
        /* 0x194 */ public int NumGraphicsThreadsBeta;
    }
}
