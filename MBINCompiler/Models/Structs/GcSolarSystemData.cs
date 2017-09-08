using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    [NMS(Size = 0x18C0)]
    public class GcSolarSystemData : NMSTemplate
    {
        /* 0x0000 */ public GcSeed Seed;
        [NMS(Size = 0x80)]
        /* 0x0010 */ public string Name;
        /* 0x0090 */ public GcSolarSystemClass Class;
        /* 0x0094 */ public GcGalaxyStarTypes StarType;
        /* 0x0098 */ public int Planets;
        [NMS(Size = 4, Ignore = true)]
        /* 0x009C */ public byte[] Padding9C;

        [NMS(Size = 8)]
        /* 0x00A0 */ public Vector4f[] PlanetPositions;
        [NMS(Size = 8)]
        /* 0x0120 */ public GcPlanetGenerationInputData[] PlanetGenerationInputs;
        [NMS(Size = 8)]
        /* 0x0360 */ public int[] PlanetOrbits;
        /* 0x0380 */ public Vector4f SunPosition;
        [NMS(Size = 0x10)]
        /* 0x0390 */ public string AsteroidSubstanceID;
        /* 0x03A0 */ public int NumTradeRoutes;
        /* 0x03A4 */ public int NumVisibleTradeRoutes;
        /* 0x03A8 */ public int MaxNumFreighters;
        /* 0x03AC */ public bool StartWithFreighters;
        [NMS(Size = 3, Ignore = true)]
        /* 0x03AD */ public byte[] Padding36D;

        /* 0x03B0 */ public Vector2f FreighterTimer;
        /* 0x03B8 */ public Vector2f PirateTimer;
        /* 0x03C0 */ public Vector2f FlybyTimer;
        [NMS(Size = 8, Ignore = true)]
        /* 0x03C8 */ public byte[] Padding3C8;
        /* 0x0390 */ public GcSpaceStationSpawnData SpaceStationSpawn;
        /* 0x0510 */ public GcSolarSystemTraderSpawnData TraderSpawnOnOutposts;
        /* 0x0524 */ public GcSolarSystemTraderSpawnData TraderSpawnInStations;
        /* 0x0538 */ public List<GcSolarSystemLocator> Locators;
        /* 0x0548 */ public List<NMSTemplate> AsteroidGenerators;
        /* 0x0558 */ public int AsteroidLevel;
        public string[] AsteroidLevelValues()
        {
            return new[] { "NoRares", "SomeRares", "LotsOfRares" };
        }

        [NMS(Size = 4, Ignore = true)]
        /* 0x055C */ public byte[] Padding51C;
        /* 0x0560 */ public GcPlanetColourData Colours;
        /* 0x1750 */ public GcLightProperties Light;
        /* 0x1780 */ public GcSpaceSkyProperties Sky;
        [NMS(Size = 0x80)]
        /* 0x1820 */ public string HeavyAir;
        /* 0x18A0 */ public List<GcAISpaceshipPreloadCacheDataTable> SystemShips;
        /* 0x18B0 */ public GcAlienRace InhabitingRace;
        /* 0x18B4 */ public GcPlanetTradingData TradingData;
        /* 0x18BC */ public GcPlayerConflictData ConflistData;
    }
}
