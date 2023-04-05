using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2C3008282613D2B, NameHash = 0x25EDFA0EC4C3AF0A)]
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
        /* 0x1A80 */ public Colour[] TileColours;
        /* 0x1BF0 */ public GcPlanetWeatherData Weather;
        /* 0x1D50 */ public GcPlanetCloudProperties Clouds;
        /* 0x1D90 */ public GcPlanetWaterData Water;
        /* 0x1F10 */ public NMSString0x80 TerrainFile;
        /* 0x1F90 */ public TkVoxelGeneratorData Terrain;
        /* 0x3560 */ public int TileTypeSet;
        /* 0x3568 */ public List<int> TileTypeIndices;
        /* 0x3578 */ public GcEnvironmentSpawnData SpawnData;
        /* 0x35D8 */ public GcAlienRace InhabitingRace;
        /* 0x35E0 */ public GcPlanetBuildingData BuildingData;
        /* 0x3628 */ public GcPlanetGenerationIntermediateData GenerationData;
        [NMS(Size = 0x4, EnumType = typeof(GcCombatTimerDifficultyOption.CombatTimerDifficultyOptionEnum))]
        /* 0x3A90 */ public GcPlanetGroundCombatData[] GroundCombatDataPerDifficulty;
        /* 0x3AF0 */ public GcPlanetInfo PlanetInfo;
        /* 0x4000 */ public GcPlanetRingData Rings;
        /* 0x4060 */ public bool InEmptySystem;
        /* 0x4061 */ public bool InAbandonedSystem;
        /* 0x4064 */ public float FuelMultiplier;
    }
}
