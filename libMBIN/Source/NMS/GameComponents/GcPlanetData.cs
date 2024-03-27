using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x612ED200C9C258B0, NameHash = 0x25EDFA0EC4C3AF0A)]
    public class GcPlanetData : NMSTemplate
    {
        /* 0x0000 */ public NMSString0x80 Name;
        /* 0x0080 */ public GcPlanetLife Life;
        /* 0x0084 */ public GcPlanetLife CreatureLife;
        /* 0x0088 */ public GcPlanetHazardData Hazard;
        // size: 0x2
        public enum ResourceLevelEnum : uint {
            Low,
            High,
        }
        /* 0x00D8 */ public ResourceLevelEnum ResourceLevel;
        /* 0x00DC */ public GcBuildingDensityLevels BuildingLevel;
        /* 0x00E0 */ public NMSString0x10 CommonSubstanceID;
        /* 0x00F0 */ public NMSString0x10 UncommonSubstanceID;
        /* 0x0100 */ public NMSString0x10 RareSubstanceID;
        /* 0x0110 */ public List<GcPlanetDataResourceHint> ExtraResourceHints;
        /* 0x0120 */ public GcPlanetColourData Colours;
        [NMS(Size = 0x17)]
        /* 0x1CB0 */ public Colour[] TileColours;
        /* 0x1E20 */ public GcPlanetWeatherData Weather;
        /* 0x1F80 */ public GcPlanetCloudProperties Clouds;
        /* 0x1FC0 */ public GcPlanetWaterData Water;
        /* 0x2140 */ public NMSString0x80 TerrainFile;
        /* 0x21C0 */ public TkVoxelGeneratorData Terrain;
        /* 0x3790 */ public int TileTypeSet;
        /* 0x3798 */ public List<int> TileTypeIndices;
        /* 0x37A8 */ public GcEnvironmentSpawnData SpawnData;
        /* 0x3808 */ public GcAlienRace InhabitingRace;
        /* 0x3810 */ public GcPlanetBuildingData BuildingData;
        /* 0x3858 */ public GcPlanetGenerationIntermediateData GenerationData;
        [NMS(Size = 0x4, EnumType = typeof(GcCombatTimerDifficultyOption.CombatTimerDifficultyOptionEnum))]
        /* 0x3CC0 */ public GcPlanetGroundCombatData[] GroundCombatDataPerDifficulty;
        /* 0x3D20 */ public GcPlanetInfo PlanetInfo;
        /* 0x4230 */ public GcPlanetRingData Rings;
        /* 0x4290 */ public bool InEmptySystem;
        /* 0x4291 */ public bool InAbandonedSystem;
        /* 0x4294 */ public float FuelMultiplier;
    }
}
