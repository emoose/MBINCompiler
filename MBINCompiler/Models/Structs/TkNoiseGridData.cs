namespace MBINCompiler.Models.Structs
{
    public class TkNoiseGridData : NMSTemplate // 0x184 bytes       // possibly in a global??
    {
        /* 0x000 */ public bool Active;
        /* 0x004 */ public int MaximumLOD;
        /* 0x008 */ public bool Subtract;
        /* 0x009 */ public bool SwapZY;
        /* 0x00A */ public bool Hemisphere;
        [NMS(Size = 0x1, Ignore = true)]
        /* 0x00B */ public byte[] PaddingB;
        /* 0x00C */ public TkNoiseVoxelTypeEnum NoiseVoxelType;
        /* 0x010 */ public int NoiseGridType;
        public string[] NoiseGridTypeValues()
        {
            return new[]
            {
                "Cube", "Cone", "Torus", "Sphere", "Cylinder", "Capsule", "Corridor", "Pipe",
                "Puck", "SuperPrimitiveRandom", "SuperFormula_01", "SuperFormula_02", "SuperFormula_03", "SuperFormula_04", "SuperFormula_05", "SuperFormula_06",
                "SuperFormula_07", "SuperFormula_08", "SuperFormulaRandom", "SuperFormula", "SuperPrimitive", "File"
            };
        }

        [NMS(Size = 0x80)]
        /* 0x014 */ public string Filename;
        /* 0x094 */ public float MinWidth;
        /* 0x098 */ public float MaxWidth;
        /* 0x09C */ public float MinHeight;
        /* 0x0A0 */ public float MaxHeight;
        /* 0x0A4 */ public float MinHeightOffset;
        /* 0x0A8 */ public float MaxHeightOffset;
        /* 0x0AC */ public float HeightOffset;

        /* 0x0B0 */ public TkNoiseOffsetEnum OffsetType;
        /* 0x0B4 */ public float RegionRatio;
        /* 0x0B8 */ public float RegionScale;
        /* 0x0BC */ public TkNoiseUberLayerData TurbulenceNoiseLayer;
        /* 0x124 */ public float Yaw;
        /* 0x128 */ public float Pitch;
        /* 0x12C */ public float Roll;
        /* 0x130 */ public float VaryYaw;
        /* 0x134 */ public float VaryPitch;
        /* 0x138 */ public float VaryRoll;
        /* 0x13C */ public float SmoothRadius;
        /* 0x140 */ public int SeedOffset;
        /* 0x144 */ public float RandomPrimitive;
        /* 0x148 */ public TkNoiseSuperFormulaData SuperFormula1;
        /* 0x158 */ public TkNoiseSuperFormulaData SuperFormula2;
        /* 0x168 */ public TkNoiseSuperPrimitiveData SuperPrimitive;
    }
}
