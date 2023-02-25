using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x11FD8C247496B7E8, NameHash = 0xBC975A8E0D580FFA)]
    public class TkNoiseFeatureData : NMSTemplate
    {
        /* 0x00 */ public bool Active;
        /* 0x04 */ public int MaximumLOD;
        /* 0x08 */ public bool Subtract;
        /* 0x09 */ public bool Trench;
        /* 0x0C */ public TkNoiseVoxelTypeEnum VoxelType;
        // size: 0x2
        public enum FeatureTypeEnum : uint {
            Tube,
            Blob,
        }
        /* 0x10 */ public FeatureTypeEnum FeatureType;
        /* 0x14 */ public float Width;
        /* 0x18 */ public float Height;
        /* 0x1C */ public int Octaves;
        /* 0x20 */ public float RegionSize;
        /* 0x24 */ public float Ratio;
        /* 0x28 */ public float HeightVarianceAmplitude;
        /* 0x2C */ public float HeightVarianceFrequency;
        /* 0x30 */ public float HeightOffset;
        /* 0x34 */ public TkNoiseOffsetEnum Offset;
        /* 0x38 */ public float SmoothRadius;
        /* 0x3C */ public int SeedOffset;
        /* 0x40 */ public float TileBlendMeters;
    }
}
