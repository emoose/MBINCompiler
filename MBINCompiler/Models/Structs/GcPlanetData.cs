using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    [NMS(Size = 0x34F0)]
    public class GcPlanetData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x0000 */ public string Name;
        /* 0x0080 */ public GcPlanetLife Life;
        /* 0x0084 */ public GcPlanetLife CreatureLife;
        /* 0x0088 */ public GcPlanetHazardData Hazard;

        public int ResourceLevel;
        /* 0x0100 */ public string[] ResourceLevelValues()
        {
            return new[] { "Low", "High" };
        }

        /* 0x0104 */ public GcBuildingDensityLevels BuildingDensityLevels;
        [NMS(Size = 0x10)]
        /* 0x0108 */ public string CommonSubstanceID;
        [NMS(Size = 0x10)]
        /* 0x0118 */ public string UncommonSubstanceID;
        [NMS(Size = 0x10)]
        /* 0x0128 */ public string RareSubstanceID;

        /*0x0138 */ public List<NMSString0x10> ExtraResourceHints;

        [NMS(Size = 8, Ignore = true)]
        /* 0x0148 */ public byte[] Padding148;

        /* 0x0150 */ public GcPlanetColourData Colours;

        [NMS(Size = 0x17)]
        /* 0x1340 */ public Colour[] TileColours;
        /* 0x14B0 */ public GcPlanetWeatherData Weather;
        /* 0x1600 */ public GcPlanetWaterData Water;
        [NMS(Size = 0x80)]
        /* 0x17B0 */ public string TerrainFile;
        /* 0x1830 */ public TkVoxelGeneratorData Terrain;
        /* 0x2B28 */ public int TileTypeSet;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x2B2C */ public byte[] Padding2B2C;
        /* 0x2B30 */ public List<int> TileTypeIndices;
        [NMS(Size = 0x80)]
        /* 0x2B40 */ public string DiffuseTexture;
        [NMS(Size = 0x80)]
        /* 0x2BC0 */ public string NormalMap;
        [NMS(Size = 0x80)]
        /* 0x2C40 */ public string OverlayTexture;
        /* 0x2CC0 */ public GcEnvironmentSpawnData SpawnData;
        /* 0x2D10 */ public GcAlienRace InhabitingRace;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x2D14 */ public byte[] Padding2D14;
        /* 0x2D18 */ public GcPlanetBuildingData BuildingData;
        /* 0x2D78 */ public GcPlanetGenerationIntermediateData GenerationData;
        /* 0x3140 */ public Vector2f SentinelTimer;
        /* 0x3148 */ public Vector2f FlybyTimer;
        /* 0x3150 */ public GcPlanetInfo PlanetInfo;
        [NMS(Size = 2, Ignore = true)]
        public byte[] Padding34D2;

        /* 0x34D4 */ public GcPlanetSentinelData SentinelData;
        /* 0x34DC */ public GcPlanetTradingData TradingData;
        /* 0x34E4 */ public GcPlayerConflictData ConflictData;
        [NMS(Size = 0x8, Ignore = true)]
        public byte[] EndPadding;
    }
}
