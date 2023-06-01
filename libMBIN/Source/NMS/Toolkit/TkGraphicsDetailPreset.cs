using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xDA0787E111B732ED, NameHash = 0x56E0EB96EB3713F0)]
    public class TkGraphicsDetailPreset : NMSTemplate
    {
        /* 0x00 */ public TkGraphicsDetailTypes TextureQuality;
        /* 0x04 */ public TkGraphicsDetailTypes AnimationQuality;
        /* 0x08 */ public TkGraphicsDetailTypes ShadowQuality;
        /* 0x0C */ public TkGraphicsDetailTypes PostProcessingEffects;
        /* 0x10 */ public TkGraphicsDetailTypes ReflectionsQuality;
        /* 0x14 */ public TkGraphicsDetailTypes VolumetricsQuality;
        /* 0x18 */ public TkGraphicsDetailTypes TerrainTessellation;
        /* 0x1C */ public TkGraphicsDetailTypes PlanetQuality;
        /* 0x20 */ public TkGraphicsDetailTypes BaseQuality;
        // size: 0x2
        public enum UIQualityEnum : uint {
            Normal,
            _4K,
        }
        /* 0x24 */ public UIQualityEnum UIQuality;
        // size: 0x5
        public enum DLSSQualityEnum : uint {
            MaxPerformance,
            Balanced,
            MaxQuality,
            UltraPerformance,
            UltraQuality,
        }
        /* 0x28 */ public DLSSQualityEnum DLSSQuality;
        // size: 0x5
        public enum FFXSRQualityEnum : uint {
            Off,
            UltraQuality,
            Quality,
            Balanced,
            Performance,
        }
        /* 0x2C */ public FFXSRQualityEnum FFXSRQuality;
        // size: 0x4
        public enum FFXSR2QualityEnum : uint {
            UltraPerformance,
            Performance,
            Balanced,
            Quality,
        }
        /* 0x30 */ public FFXSR2QualityEnum FFXSR2Quality;
        // size: 0x5
        public enum XESSQualityEnum : uint {
            UltraPerformance,
            Performance,
            Balanced,
            MaxQuality,
            UltraQuality,
        }
        /* 0x34 */ public XESSQualityEnum XESSQuality;
        // size: 0x3
        public enum MetalFXModeEnum : uint {
            Off,
            Spatial,
            Temporal,
        }
        /* 0x38 */ public MetalFXModeEnum MetalFXMode;
        // size: 0x4
        public enum MetalFXQualityEnum : uint {
            UltraQuality,
            Quality,
            Balanced,
            Performance,
        }
        /* 0x3C */ public MetalFXQualityEnum MetalFXQuality;
        // size: 0x7
        public enum AmbientOcclusionEnum : uint {
            Off,
            GTAO_Low,
            GTAO_Medium,
            GTAO_High,
            GTAO_Ultra,
            HBAO_Low,
            HBAO_High,
        }
        /* 0x40 */ public AmbientOcclusionEnum AmbientOcclusion;
        // size: 0x5
        public enum AnisotropyLevelEnum : uint {
            _1,
            _2,
            _4,
            _8,
            _16,
        }
        /* 0x44 */ public AnisotropyLevelEnum AnisotropyLevel;
        // size: 0xC
        public enum AntiAliasingEnum : uint {
            None,
            MSAA_2,
            MSAA_4,
            TAA_LOW,
            TAA,
            FXAA,
            FFXSR2,
            DLSS,
            DLAA,
            XESS,
            MetalFXSpatial,
            MetalFXTemporal,
        }
        /* 0x48 */ public AntiAliasingEnum AntiAliasing;
        /* 0x4C */ public TkDynamicResScalingSettings DynamicResScalingSettings;
    }
}
