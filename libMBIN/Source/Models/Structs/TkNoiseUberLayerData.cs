namespace libMBIN.Models.Structs
{
    public class TkNoiseUberLayerData : NMSTemplate // 0x68 bytes
    {
        /* 0x00 */ public TkNoiseUberData NoiseData;
        /* 0x28 */ public bool Active;
        /* 0x2C */ public int MaximumLOD;
        /* 0x30 */ public bool Subtract;
        /* 0x34 */ public TkNoiseVoxelTypeEnum NoiseVoxelType;
        /* 0x38 */ public float Height;
        /* 0x3C */ public float Width;
        /* 0x40 */ public float RegionRatio;
        /* 0x44 */ public float RegionScale;
        /* 0x48 */ public float SmoothRadius;
        /* 0x4C */ public float HeightOffset;
        /* 0x50 */ public TkNoiseOffsetEnum OffsetType;
        /* 0x54 */ public int WaterFade;
        public string[] WaterFadeValues()
        {
            return new[] { "None", "Above", "Below" };
        }
        /* 0x58 */ public float PlateauStratas;
        /* 0x5C */ public int PlateauSharpness;
        /* 0x60 */ public float PlateauRegionSize;
        /* 0x64 */ public int SeedOffset;
    }
}
