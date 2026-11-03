namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA5AE30108703BA10, NameHash = 0xDBC579DA)]
    public class GcGalaxyRenderSetupData : NMSTemplate
    {
        [NMS(Index = 34, Size = 0xA, MxmlName = "Map Large Area Primary Default Colours")]
        /* 0x000 */ public Colour[] MapLargeAreaPrimaryDefaultColours;
        [NMS(Index = 35, Size = 0xA, MxmlName = "Map Large Area Primary High Contrast Colours")]
        /* 0x0A0 */ public Colour[] MapLargeAreaPrimaryHighContrastColours;
        [NMS(Index = 36, Size = 0xA, MxmlName = "Map Large Area Secondary Default Colours")]
        /* 0x140 */ public Colour[] MapLargeAreaSecondaryDefaultColours;
        [NMS(Index = 37, Size = 0xA, MxmlName = "Map Large Area Secondary High Contrast Colours")]
        /* 0x1E0 */ public Colour[] MapLargeAreaSecondaryHighContrastColours;
        [NMS(Index = 24, MxmlName = "Composition Control B_S_C_G")]
        /* 0x280 */ public Vector4f CompositionControlB_S_C_G;
        [NMS(Index = 16, MxmlName = "Lens Flare Colour")]
        /* 0x290 */ public Colour LensFlareColour;
        [NMS(Index = 17, MxmlName = "Lens Flare Spread")]
        /* 0x2A0 */ public Vector4f LensFlareSpread;
        [NMS(Index = 0, MxmlName = "Sun Core Colour")]
        /* 0x2B0 */ public Colour SunCoreColour;
        [NMS(Index = 33, MxmlName = "Lens Flare Expand Towards")]
        /* 0x2C0 */ public Vector2f LensFlareExpandTowards;
        [NMS(Index = 23, MxmlName = "Nebulae Trace Step Range")]
        /* 0x2C8 */ public Vector2f NebulaeTraceStepRange;
        [NMS(Index = 7, MxmlName = "BG Cell Horizon Influence")]
        /* 0x2D0 */ public float BGCellHorizonInfluence;
        [NMS(Index = 6, MxmlName = "BG Cell Move Scale")]
        /* 0x2D4 */ public float BGCellMoveScale;
        [NMS(Index = 5, MxmlName = "BG Cell Trace Scale")]
        /* 0x2D8 */ public float BGCellTraceScale;
        [NMS(Index = 12, MxmlName = "BG Colour Cell Blend")]
        /* 0x2DC */ public float BGColourCellBlend;
        [NMS(Index = 13, MxmlName = "BG Colour Pow")]
        /* 0x2E0 */ public float BGColourPow;
        [NMS(Index = 8, MxmlName = "BG Colour Stage 1")]
        /* 0x2E4 */ public float BGColourStage1;
        [NMS(Index = 9, MxmlName = "BG Colour Stage 2")]
        /* 0x2E8 */ public float BGColourStage2;
        [NMS(Index = 10, MxmlName = "BG Colour Stage 3")]
        /* 0x2EC */ public float BGColourStage3;
        [NMS(Index = 11, MxmlName = "BG Colour Stage 4")]
        /* 0x2F0 */ public float BGColourStage4;
        [NMS(Index = 25, MxmlName = "Composition Saturation Increase Error")]
        /* 0x2F4 */ public float CompositionSaturationIncreaseError;
        [NMS(Index = 26, MxmlName = "Composition Saturation Increase Filter")]
        /* 0x2F8 */ public float CompositionSaturationIncreaseFilter;
        [NMS(Index = 27, MxmlName = "Composition Saturation Increase Selected")]
        /* 0x2FC */ public float CompositionSaturationIncreaseSelected;
        [NMS(Index = 15, MxmlName = "Lens Flare Base")]
        /* 0x300 */ public float LensFlareBase;
        [NMS(Index = 18, MxmlName = "Nebulae Alpha Pow")]
        /* 0x304 */ public float NebulaeAlphaPow;
        [NMS(Index = 21, MxmlName = "Nebulae Trace Density")]
        /* 0x308 */ public float NebulaeTraceDensity;
        [NMS(Index = 22, MxmlName = "Nebulae Trace Density Cutoff")]
        /* 0x30C */ public float NebulaeTraceDensityCutoff;
        [NMS(Index = 20, MxmlName = "Nebulae Trace Scale")]
        /* 0x310 */ public float NebulaeTraceScale;
        [NMS(Index = 19, MxmlName = "Nebulae Trace Value Mult")]
        /* 0x314 */ public float NebulaeTraceValueMult;
        [NMS(Index = 14, MxmlName = "Star Field Blend Amount")]
        /* 0x318 */ public float StarFieldBlendAmount;
        [NMS(Index = 3, MxmlName = "Sun Core BG Contrib")]
        /* 0x31C */ public float SunCoreBGContrib;
        [NMS(Index = 4, MxmlName = "Sun Core FG Contrib")]
        /* 0x320 */ public float SunCoreFGContrib;
        [NMS(Index = 2, MxmlName = "Sun Core Larger")]
        /* 0x324 */ public float SunCoreLarger;
        [NMS(Index = 1, MxmlName = "Sun Core Smaller")]
        /* 0x328 */ public float SunCoreSmaller;
        [NMS(Index = 29, MxmlName = "Vignette Base")]
        /* 0x32C */ public float VignetteBase;
        [NMS(Index = 28, MxmlName = "Vignette Size")]
        /* 0x330 */ public float VignetteSize;
        [NMS(Index = 30, MxmlName = "Vignette Size Increase Error")]
        /* 0x334 */ public float VignetteSizeIncreaseError;
        [NMS(Index = 31, MxmlName = "Vignette Size Increase Filter")]
        /* 0x338 */ public float VignetteSizeIncreaseFilter;
        [NMS(Index = 32, MxmlName = "Vignette Size Increase Selected")]
        /* 0x33C */ public float VignetteSizeIncreaseSelected;
    }
}
