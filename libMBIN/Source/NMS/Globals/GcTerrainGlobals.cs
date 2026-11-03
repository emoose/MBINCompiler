using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x2E73287A71577F68, NameHash = 0xFB4BF08D)]
    public class GcTerrainGlobals : NMSTemplate
    {
        [NMS(Index = 9)]
        /* 0x000 */ public Colour TerrainBeamLightColour;
        [NMS(Index = 40, Size = 0x11, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x010 */ public NMSString0x10[] MiningSubstanceBiome;
        [NMS(Index = 43)]
        /* 0x120 */ public List<NMSString0x10> MiningSubstanceRare;
        [NMS(Index = 41)]
        /* 0x130 */ public List<NMSString0x10> MiningSubstanceStar;
        [NMS(Index = 42)]
        /* 0x140 */ public List<NMSString0x10> MiningSubstanceStarExtreme;
        [NMS(Index = 59)]
        /* 0x150 */ public GcFilename RegionHotspotsTable;
        [NMS(Index = 51)]
        /* 0x160 */ public GcTerrainEditing TerrainEditing;
        [NMS(Index = 48)]
        /* 0x1F8 */ public GcTerrainOverlayColours HueOverlay;
        [NMS(Index = 49)]
        /* 0x210 */ public GcTerrainOverlayColours SaturationOverlay;
        [NMS(Index = 50)]
        /* 0x228 */ public GcTerrainOverlayColours ValueOverlay;
        [NMS(Index = 15)]
        /* 0x240 */ public float HeightBlend;
        [NMS(Index = 34)]
        /* 0x244 */ public float MaxHighWaterLevel;
        [NMS(Index = 37)]
        /* 0x248 */ public float MaxHighWaterRatio;
        [NMS(Index = 39)]
        /* 0x24C */ public float MaxWaterRatio;
        [NMS(Index = 33)]
        /* 0x250 */ public float MinHighWaterLevel;
        [NMS(Index = 36)]
        /* 0x254 */ public float MinHighWaterRatio;
        [NMS(Index = 35)]
        /* 0x258 */ public float MinHighWaterRegionRatio;
        [NMS(Index = 38)]
        /* 0x25C */ public float MinWaterRatio;
        [NMS(Index = 3)]
        /* 0x260 */ public float MouseWheelRotatePlaneSensitivity;
        [NMS(Index = 30)]
        /* 0x264 */ public int NumGeneratorCalls;
        [NMS(Index = 31)]
        /* 0x268 */ public int NumPolygoniseCalls;
        [NMS(Index = 32)]
        /* 0x26C */ public int NumPostPolygoniseCalls;
        [NMS(Index = 23)]
        /* 0x270 */ public float PurpleSystemMaxHighWaterChance;
        [NMS(Index = 0)]
        /* 0x274 */ public float RegisterTerrainMinDistance;
        [NMS(Index = 24)]
        /* 0x278 */ public float SeaLevelGasGiant;
        [NMS(Index = 27)]
        /* 0x27C */ public float SeaLevelHigh;
        [NMS(Index = 25)]
        /* 0x280 */ public float SeaLevelMoon;
        [NMS(Index = 26)]
        /* 0x284 */ public float SeaLevelStandard;
        [NMS(Index = 28)]
        /* 0x288 */ public float SeaLevelWaterWorld;
        [NMS(Index = 17)]
        /* 0x28C */ public float SmoothStepAbove;
        [NMS(Index = 16)]
        /* 0x290 */ public float SmoothStepBelow;
        [NMS(Index = 18)]
        /* 0x294 */ public float SmoothStepStrength;
        [NMS(Index = 6)]
        /* 0x298 */ public float SubtractEditFrequency;
        [NMS(Index = 5)]
        /* 0x29C */ public float SubtractEditLength;
        [NMS(Index = 4)]
        /* 0x2A0 */ public float SubtractEditOffset;
        [NMS(Index = 7)]
        /* 0x2A4 */ public float TerrainBeamDefaultRadius;
        [NMS(Index = 2)]
        /* 0x2A8 */ public float TerrainBeamHologramTimeout;
        [NMS(Index = 8)]
        /* 0x2AC */ public float TerrainBeamLightIntensity;
        [NMS(Index = 1)]
        /* 0x2B0 */ public float TerrainBeamUndoRangeFromLastAdd;
        [NMS(Index = 60)]
        /* 0x2B4 */ public int TerrainPrimeIndexStart;
        [NMS(Index = 61)]
        /* 0x2B8 */ public int TerrainPurpleSystemIndexStart;
        [NMS(Index = 53)]
        /* 0x2BC */ public float TerrainUndoCubesAlpha;
        [NMS(Index = 55)]
        /* 0x2C0 */ public float TerrainUndoCubesNoiseFactor;
        [NMS(Index = 54)]
        /* 0x2C4 */ public float TerrainUndoCubesNoiseThreshold;
        [NMS(Index = 52)]
        /* 0x2C8 */ public float TerrainUndoCubesRange;
        [NMS(Index = 56)]
        /* 0x2CC */ public float TerrainUndoFadeDepthConstant;
        [NMS(Index = 57)]
        /* 0x2D0 */ public float TerrainUndoFadeDepthScalar;
        [NMS(Index = 47)]
        /* 0x2D4 */ public float TextureBlendOffset;
        [NMS(Index = 44)]
        /* 0x2D8 */ public float TextureBlendScale0;
        [NMS(Index = 45)]
        /* 0x2DC */ public float TextureBlendScale1;
        [NMS(Index = 46)]
        /* 0x2E0 */ public float TextureBlendScale2;
        [NMS(Index = 11)]
        /* 0x2E4 */ public float TextureFadeDistance;
        [NMS(Index = 12)]
        /* 0x2E8 */ public float TextureFadePower;
        [NMS(Index = 13)]
        /* 0x2EC */ public float TextureScaleMultiplier;
        [NMS(Index = 14)]
        /* 0x2F0 */ public float TextureScalePower;
        [NMS(Index = 19)]
        /* 0x2F4 */ public float TileBlendMultiplier;
        [NMS(Index = 10)]
        /* 0x2F8 */ public float UseMax;
        [NMS(Index = 20)]
        /* 0x2FC */ public bool DebugFlattenAllTerrain;
        [NMS(Index = 29)]
        /* 0x2FD */ public bool DebugLockTerrainSettingsIndex;
        [NMS(Index = 21)]
        /* 0x2FE */ public bool DebugNoFlattenForBuildings;
        [NMS(Index = 58)]
        /* 0x2FF */ public bool DebugRegionHotspots;
        [NMS(Index = 22)]
        /* 0x300 */ public bool ForcePurpleSystemHighWater;
    }
}
