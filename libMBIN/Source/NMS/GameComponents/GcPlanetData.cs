using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x3D50, GUID = 0x61F4781A63B7AC9C, NameHash = 0x25EDFA0EC4C3AF0A)]
    public class GcPlanetData : NMSTemplate
    {
        /* 0x0000 */ public NMSString0x80 Name;
        /* 0x0080 */ public GcPlanetLife Life;
        /* 0x0084 */ public GcPlanetLife CreatureLife;
        /* 0x0088 */ public GcPlanetHazardData Hazard;
        public enum ResourceLevelEnum { Low, High }
        /* 0x00D8 */ public ResourceLevelEnum ResourceLevel;
        /* 0x00DC */ public GcBuildingDensityLevels BuildingLevel;
        /* 0x00E0 */ public NMSString0x10 CommonSubstanceID;
        /* 0x00F0 */ public NMSString0x10 UncommonSubstanceID;
        /* 0x0100 */ public NMSString0x10 RareSubstanceID;
        /* 0x0110 */ public List<GcPlanetDataResourceHint> ExtraResourceHints;
        /* 0x0120 */ public GcPlanetColourData Colours;
        [NMS(Size = 0x17)]
        /* 0x1930 */ public Colour[] TileColours;
        /* 0x1AA0 */ public GcPlanetWeatherData Weather;
        /* 0x1C00 */ public GcPlanetCloudProperties Clouds;
        /* 0x1C40 */ public GcPlanetWaterData Water;
        /* 0x1DC0 */ public NMSString0x80 TerrainFile;
        /* 0x1E40 */ public TkVoxelGeneratorData Terrain;
        /* 0x3410 */ public int TileTypeSet;
        /* 0x3418 */ public List<int> TileTypeIndices;
        /* 0x3428 */ public GcEnvironmentSpawnData SpawnData;
        /* 0x3488 */ public GcAlienRace InhabitingRace;
        /* 0x3490 */ public GcPlanetBuildingData BuildingData;
        /* 0x34D8 */ public GcPlanetGenerationIntermediateData GenerationData;
        /* 0x3940 */ public Vector2f SentinelTimer;
        /* 0x3948 */ public Vector2f FlybyTimer;
        /* 0x3950 */ public GcPlanetInfo PlanetInfo;
        /* 0x3CD4 */ public GcPlanetSentinelData SentinelData;
        /* 0x3CE0 */ public GcPlanetRingData Rings;
        /* 0x3D40 */ public bool InEmptySystem;
        /* 0x3D41 */ public bool InAbandonedSystem;
        /* 0x3D44 */ public float FuelMultiplier;
    }
}

