using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6B58302530AA605E, NameHash = 0x25EDFA0EC4C3AF0A)]
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
        /* 0x1B60 */ public Colour[] TileColours;
        /* 0x1CD0 */ public GcPlanetWeatherData Weather;
        /* 0x1E30 */ public GcPlanetCloudProperties Clouds;
        /* 0x1E70 */ public GcPlanetWaterData Water;
        /* 0x1FF0 */ public NMSString0x80 TerrainFile;
        /* 0x2070 */ public TkVoxelGeneratorData Terrain;
        /* 0x3640 */ public int TileTypeSet;
        /* 0x3648 */ public List<int> TileTypeIndices;
        /* 0x3658 */ public GcEnvironmentSpawnData SpawnData;
        /* 0x36B8 */ public GcAlienRace InhabitingRace;
        /* 0x36C0 */ public GcPlanetBuildingData BuildingData;
        /* 0x3708 */ public GcPlanetGenerationIntermediateData GenerationData;
        [NMS(Size = 0x4, EnumType = typeof(GcCombatTimerDifficultyOption.CombatTimerDifficultyOptionEnum))]
        /* 0x3B70 */ public GcPlanetGroundCombatData[] GroundCombatDataPerDifficulty;
        /* 0x3BD0 */ public GcPlanetInfo PlanetInfo;
        /* 0x40E0 */ public GcPlanetRingData Rings;
        /* 0x4140 */ public bool InEmptySystem;
        /* 0x4141 */ public bool InAbandonedSystem;
        /* 0x4144 */ public float FuelMultiplier;
    }
}
