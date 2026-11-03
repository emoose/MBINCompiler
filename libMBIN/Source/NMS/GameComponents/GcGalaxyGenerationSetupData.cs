using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEEBE6D9DBC3D02BE, NameHash = 0x6AA13F89)]
    public class GcGalaxyGenerationSetupData : NMSTemplate
    {
        [NMS(Index = 31, Size = 0xA, MxmlName = "Inner Sector Colours")]
        /* 0x000 */ public Colour[] InnerSectorColours;
        [NMS(Index = 20, MxmlName = "Inner Field Scales")]
        /* 0x0A0 */ public Vector4f InnerFieldScales;
        [NMS(Index = 4, MxmlName = "Spiral Pull")]
        /* 0x0B0 */ public Vector3f SpiralPull;
        [NMS(Index = 13, Size = 0x5, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum), MxmlName = "Star Size")]
        /* 0x0C0 */ public Vector2f[] StarSize;
        [NMS(Index = 12, MxmlName = "Base Size")]
        /* 0x0E8 */ public Vector2f BaseSize;
        [NMS(Index = 7, MxmlName = "Connection Attractor Max")]
        /* 0x0F0 */ public Vector2f ConnectionAttractorMax;
        [NMS(Index = 8, MxmlName = "Connection Attractor Min")]
        /* 0x0F8 */ public Vector2f ConnectionAttractorMin;
        [NMS(Index = 9, MxmlName = "Connection Distortion")]
        /* 0x100 */ public Vector2f ConnectionDistortion;
        [NMS(Index = 2, MxmlName = "Spiral Flex")]
        /* 0x108 */ public Vector2f SpiralFlex;
        [NMS(Index = 1, MxmlName = "Spiral Inclusion")]
        /* 0x110 */ public Vector2f SpiralInclusion;
        [NMS(Index = 5, MxmlName = "Spiral Size Scale")]
        /* 0x118 */ public Vector2f SpiralSizeScale;
        [NMS(Index = 28, MxmlName = "Star Highlight Alpha")]
        /* 0x120 */ public Vector2f StarHighlightAlpha;
        [NMS(Index = 29, MxmlName = "Star Highlight Size")]
        /* 0x128 */ public Vector2f StarHighlightSize;
        [NMS(Index = 17, MxmlName = "Base Generation Threshold")]
        /* 0x130 */ public float BaseGenerationThreshold;
        [NMS(Index = 16, MxmlName = "Base Turbulence Gain")]
        /* 0x134 */ public float BaseTurbulenceGain;
        [NMS(Index = 15, MxmlName = "Base Turbulence Lac")]
        /* 0x138 */ public float BaseTurbulenceLac;
        [NMS(Index = 14, MxmlName = "Base Turbulence Scale")]
        /* 0x13C */ public float BaseTurbulenceScale;
        [NMS(Index = 30, MxmlName = "Colour Base Blend On Size")]
        /* 0x140 */ public float ColourBaseBlendOnSize;
        [NMS(Index = 11, MxmlName = "Connection Distance Limit")]
        /* 0x144 */ public float ConnectionDistanceLimit;
        [NMS(Index = 10, MxmlName = "Connection Distortion T Mult")]
        /* 0x148 */ public float ConnectionDistortionTMult;
        [NMS(Index = 18, MxmlName = "Field Generation Threshold")]
        /* 0x14C */ public float FieldGenerationThreshold;
        [NMS(Index = 24, MxmlName = "FieldAlpha Base")]
        /* 0x150 */ public float FieldAlphaBase;
        [NMS(Index = 25, MxmlName = "FieldAlpha Field1 Inf")]
        /* 0x154 */ public float FieldAlphaField1Inf;
        [NMS(Index = 26, MxmlName = "FieldAlpha Field2Sq Inf")]
        /* 0x158 */ public float FieldAlphaField2SqInf;
        [NMS(Index = 6, MxmlName = "Rare Sun Chance")]
        /* 0x15C */ public float RareSunChance;
        [NMS(Index = 23, MxmlName = "Size Field4 Inf")]
        /* 0x160 */ public float SizeField4Inf;
        [NMS(Index = 22, MxmlName = "Size Noise Power")]
        /* 0x164 */ public float SizeNoisePower;
        [NMS(Index = 21, MxmlName = "Size Noise Scale")]
        /* 0x168 */ public float SizeNoiseScale;
        [NMS(Index = 0, MxmlName = "Spiral Form Chance")]
        /* 0x16C */ public float SpiralFormChance;
        [NMS(Index = 3, MxmlName = "Spiral Twist Mult")]
        /* 0x170 */ public float SpiralTwistMult;
        [NMS(Index = 19, MxmlName = "Star Generation Threshold")]
        /* 0x174 */ public float StarGenerationThreshold;
        [NMS(Index = 27, MxmlName = "Star Highlight Chance")]
        /* 0x178 */ public float StarHighlightChance;
    }
}
