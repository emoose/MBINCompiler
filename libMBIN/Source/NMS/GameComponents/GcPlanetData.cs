using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x3DC0, GUID = 0x9E825F897FC3FF70, NameHash = 0x25EDFA0EC4C3AF0A)]
    public class GcPlanetData : NMSTemplate
    {
        /* 0x0000 */ public NMSString0x80 Name;
        /* 0x0080 */ public GcPlanetLife Life;
        /* 0x0084 */ public GcPlanetLife CreatureLife;
        /* 0x0088 */ public GcPlanetHazardData Hazard;
        // size: 0x2
        public enum ResourceLevelEnum { Low, High }
        /* 0x00D8 */ public ResourceLevelEnum ResourceLevel;
        /* 0x00DC */ public GcBuildingDensityLevels BuildingLevel;
        /* 0x00E0 */ public NMSString0x10 CommonSubstanceID;
        /* 0x00F0 */ public NMSString0x10 UncommonSubstanceID;
        /* 0x0100 */ public NMSString0x10 RareSubstanceID;
        /* 0x0110 */ public List<GcPlanetDataResourceHint> ExtraResourceHints;
        /* 0x0120 */ public GcPlanetColourData Colours;
        [NMS(Size = 0x17)]
        /* 0x19A0 */ public Colour[] TileColours;
        /* 0x1B10 */ public GcPlanetWeatherData Weather;
        /* 0x1C70 */ public GcPlanetCloudProperties Clouds;
        /* 0x1CB0 */ public GcPlanetWaterData Water;
        /* 0x1E30 */ public NMSString0x80 TerrainFile;
        /* 0x1EB0 */ public TkVoxelGeneratorData Terrain;
        /* 0x3480 */ public int TileTypeSet;
        /* 0x3488 */ public List<int> TileTypeIndices;
        /* 0x3498 */ public GcEnvironmentSpawnData SpawnData;
        /* 0x34F8 */ public GcAlienRace InhabitingRace;
        /* 0x3500 */ public GcPlanetBuildingData BuildingData;
        /* 0x3548 */ public GcPlanetGenerationIntermediateData GenerationData;
        /* 0x39B0 */ public Vector2f SentinelTimer;
        /* 0x39B8 */ public Vector2f FlybyTimer;
        /* 0x39C0 */ public GcPlanetInfo PlanetInfo;
        /* 0x3D44 */ public GcPlanetSentinelData SentinelData;
        /* 0x3D50 */ public GcPlanetRingData Rings;
        /* 0x3DB0 */ public bool InEmptySystem;
        /* 0x3DB1 */ public bool InAbandonedSystem;
        /* 0x3DB4 */ public float FuelMultiplier;
    }
}
