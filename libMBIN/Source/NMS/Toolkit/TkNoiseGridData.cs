using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x4C8832CFE3785F00, NameHash = 0xA45052EB66E281C7)]
    public class TkNoiseGridData : NMSTemplate
    {
        /* 0x000 */ public bool Active;
        /* 0x004 */ public int MaximumLOD;
        /* 0x008 */ public bool Subtract;
        /* 0x009 */ public bool SwapZY;
        /* 0x00A */ public bool Hemisphere;
        /* 0x00C */ public TkNoiseVoxelTypeEnum VoxelType;
        // size: 0x16
        public enum NoiseGridTypeEnum : uint {
            Cube,
            Cone,
            Torus,
            Sphere,
            Cylinder,
            Capsule,
            Corridor,
            Pipe,
            Puck,
            SuperPrimitiveRandom,
            SuperFormula_01,
            SuperFormula_02,
            SuperFormula_03,
            SuperFormula_04,
            SuperFormula_05,
            SuperFormula_06,
            SuperFormula_07,
            SuperFormula_08,
            SuperFormulaRandom,
            SuperFormula,
            SuperPrimitive,
            File,
        }
        /* 0x010 */ public NoiseGridTypeEnum NoiseGridType;
        /* 0x014 */ public NMSString0x80 Filename;
        /* 0x094 */ public float MinWidth;
        /* 0x098 */ public float MaxWidth;
        /* 0x09C */ public float MinHeight;
        /* 0x0A0 */ public float MaxHeight;
        /* 0x0A4 */ public float MinHeightOffset;
        /* 0x0A8 */ public float MaxHeightOffset;
        /* 0x0AC */ public float HeightOffset;
        /* 0x0B0 */ public TkNoiseOffsetEnum Offset;
        /* 0x0B4 */ public float RegionRatio;
        /* 0x0B8 */ public float RegionScale;
        /* 0x0BC */ public TkNoiseUberLayerData TurbulenceNoiseLayer;
        /* 0x144 */ public float Yaw;
        /* 0x148 */ public float Pitch;
        /* 0x14C */ public float Roll;
        /* 0x150 */ public float VaryYaw;
        /* 0x154 */ public float VaryPitch;
        /* 0x158 */ public float VaryRoll;
        /* 0x15C */ public float SmoothRadius;
        /* 0x160 */ public int SeedOffset;
        /* 0x164 */ public float RandomPrimitive;
        /* 0x168 */ public TkNoiseSuperFormulaData SuperFormula1;
        /* 0x178 */ public TkNoiseSuperFormulaData SuperFormula2;
        /* 0x188 */ public TkNoiseSuperPrimitiveData SuperPrimitive;
        /* 0x1A4 */ public float TileBlendMeters;
    }
}
