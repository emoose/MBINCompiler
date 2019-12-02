using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x470, GUID = 0x6D38AC966F0E1E43)]
    public class GcTerrainGlobals : NMSTemplate
    {
        /* 0x000 */ public float RegisterTerrainMinDistance;
        /* 0x004 */ public float TerrainBeamUndoRangeFromLastAdd;
        /* 0x008 */ public float TerrainBeamHologramTimeout;
        /* 0x00C */ public float MouseWheelRotatePlaneSensitivity;
        /* 0x010 */ public float SubtractEditOffset;
        /* 0x014 */ public float SubtractEditLength;
        /* 0x018 */ public float SubtractEditFrequency;
        /* 0x01C */ public float TerrainBeamDefaultRadius;
        /* 0x020 */ public float TerrainBeamLightIntensity;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x024 */ public byte[] Padding24;
        /* 0x030 */ public Colour TerrainBeamLightColour;
        /* 0x040 */ public float UseMax;
        /* 0x044 */ public float TextureFadeDistance;
        /* 0x048 */ public float TextureFadePower;
        /* 0x04C */ public float TextureScaleMultiplier;
        /* 0x050 */ public float TextureScalePower;
        [NMS(Size = 0x8)]
        /* 0x054 */ public float[] TextureScales;
        [NMS(Size = 0x8)]
        /* 0x074 */ public float[] TextureDistances;
        /* 0x094 */ public float HeightBlend;
        /* 0x098 */ public float SmoothStepBelow;
        /* 0x09C */ public float SmoothStepAbove;
        /* 0x0A0 */ public float SmoothStepStrength;
        /* 0x0A4 */ public float TileBlendMultiplier;
        /* 0x0A8 */ public bool DebugFlattenAllTerrain;
        /* 0x0A9 */ public bool DebugNoFlattenForBuildings;
        /* 0x0AA */ public bool DebugLockTerrainSettingsIndex;
        /* 0x0AC */ public int NumGeneratorCalls;
        /* 0x0B0 */ public int NumPolygoniseCalls;
        /* 0x0B4 */ public int NumPostPolygoniseCalls;
        /* 0x0B8 */ public float MinHighWaterLevel;
        /* 0x0BC */ public float MaxHighWaterLevel;
        /* 0x0C0 */ public float MinHighWaterRegionRatio;
        /* 0x0C4 */ public float MinHighWaterRatio;
        /* 0x0C8 */ public float MaxHighWaterRatio;
        /* 0x0CC */ public float MinWaterRatio;
        /* 0x0D0 */ public float MaxWaterRatio;

        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0D4 */ public byte[] PaddingD4;

        [NMS(Size = 0xD, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x0D8 */ public NMSString0x10[] MiningSubstanceBiome;

        [NMS(Size = 0x4, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x1A8 */ public NMSString0x10[] MiningSubstanceStar;

        [NMS(Size = 0x4, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x1E8 */ public NMSString0x10[] MiningSubstanceStarExtreme;

        [NMS(Size = 0x5)]
        /* 0x228 */ public NMSString0x10[] MiningSubstanceRare;
        /* 0x278 */ public float TextureBlendScale0;
        /* 0x27C */ public float TextureBlendScale1;
        /* 0x280 */ public float TextureBlendScale2;
        /* 0x284 */ public float TextureBlendOffset;
        /* 0x288 */ public float BaseSlopePower;
        /* 0x28C */ public float MountainSlopePower;
        /* 0x290 */ public GcTerrainOverlayColours HueOverlay;
        /* 0x2A8 */ public GcTerrainOverlayColours SaturationOverlay;
        /* 0x2C0 */ public GcTerrainOverlayColours ValueOverlay;

        /* 0x2D8 */ public GcTerrainEditing TerrainEditing;
        /* 0x370 */ public float TerrainUndoCubesRange;
        /* 0x374 */ public float TerrainUndoCubesAlpha;
        /* 0x378 */ public float TerrainUndoCubesNoiseThreshold;
        /* 0x37C */ public float TerrainUndoCubesNoiseFactor;
        /* 0x380 */ public float TerrainUndoFadeDepthConstant;
        /* 0x384 */ public float TerrainUndoFadeDepthScalar;
        /* 0x388 */ public bool TerrainEditUndosEnabled;
        [NMS(Size = 0x80)]
        /* 0x389 */ public string RegionHotspotTable;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x469 */ public byte[] EndPadding;
    }
}
