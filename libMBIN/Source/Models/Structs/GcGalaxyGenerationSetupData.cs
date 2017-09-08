namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x170)]
    public class GcGalaxyGenerationSetupData : NMSTemplate
    {
        /* 0x00 */ public float SpiralFormChance;
        /* 0x04 */ public Vector2f SpiralInclusion;
        /* 0x0C */ public Vector2f SpiralFlex;
        /* 0x14 */ public float SpiralTwistMult;

        [NMS(Size = 0x8, Ignore = true)]
        /* 0x18 */ public byte[] Padding18;

        /* 0x20 */ public Vector4f SpiralPull;
        /* 0x30 */ public Vector2f SpiralSizeScale;
        /* 0x38 */ public float RareSunChance;
        /* 0x3C */ public Vector2f ConnectionAttractorMax;
        /* 0x44 */ public Vector2f ConnectionAttractorMin;
        /* 0x4C */ public Vector2f ConnectionDistortion;
        /* 0x54 */ public float ConnectionDistortionTMult;
        /* 0x58 */ public float ConnectionDistanceLimit;
        /* 0x5C */ public Vector2f BaseSize;
        /* 0x64 */ public Vector2f StarSize;
        /* 0x6C */ public float BaseTurbulenceScale;
        /* 0x70 */ public float BaseTurbulenceLac;
        /* 0x74 */ public float BaseTurbulenceGain;
        /* 0x78 */ public float BaseGenerationThreshold;
        /* 0x7C */ public float FieldGenerationThreshold;
        /* 0x80 */ public float StarGenerationThreshold;

        [NMS(Size = 0xC, Ignore = true)]
        /* 0x84 */ public byte[] Padding84;

        /* 0x90 */ public Vector4f InnerFieldScales;
        /* 0xA0 */ public float SizeNoiseScale;
        /* 0xA4 */ public float SizeNoisePower;
        /* 0xA8 */ public float SizeField4Inf;
        /* 0xAC */ public float FieldAlphaBase;
        /* 0xB0 */ public float FieldAlphaField1Inf;
        /* 0xB4 */ public float FieldAlphaField2SqInf;
        /* 0xB8 */ public float StarHighlightChance;
        /* 0xBC */ public Vector2f StarHighlightAlpha;
        /* 0xC4 */ public Vector2f StarHighlightSize;
        /* 0xCC */ public float ColourBaseBlendOnSize;

        [NMS(Size = 0xA)]
        /* 0xD0 */ public Colour[] InnerSectorColours;
    }
}
