using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x3F104057D08F304F, NameHash = 0x174C8C3DB33CE268)]
    public class TkNoiseUberLayerData : NMSTemplate
    {
        /* 0x00 */ public TkNoiseUberData NoiseData;
        /* 0x40 */ public bool Active;
        /* 0x44 */ public int MaximumLOD;
        /* 0x48 */ public bool Subtract;
        /* 0x4C */ public TkNoiseVoxelTypeEnum VoxelType;
        /* 0x50 */ public float Height;
        /* 0x54 */ public float Width;
        /* 0x58 */ public float RegionRatio;
        /* 0x5C */ public float RegionScale;
        /* 0x60 */ public float RegionGain;
        /* 0x64 */ public float SmoothRadius;
        /* 0x68 */ public float HeightOffset;
        /* 0x6C */ public TkNoiseOffsetEnum Offset;
        // size: 0x3
        public enum WaterFadeEnum : uint {
            None,
            Above,
            Below,
        }
        /* 0x70 */ public WaterFadeEnum WaterFade;
        /* 0x74 */ public float PlateauStratas;
        /* 0x78 */ public int PlateauSharpness;
        /* 0x7C */ public float PlateauRegionSize;
        /* 0x80 */ public int SeedOffset;
        /* 0x84 */ public float TileBlendMeters;
    }
}
