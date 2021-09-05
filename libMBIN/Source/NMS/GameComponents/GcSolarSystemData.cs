using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x1F50, GUID = 0xEB09C442DE1A70E7, NameHash = 0x9B09276BB2795541)]
    public class GcSolarSystemData : NMSTemplate
    {
        /* 0x0000 */ public GcSeed Seed;
        /* 0x0010 */ public NMSString0x80 Name;
        /* 0x0090 */ public GcSolarSystemClass Class;
        /* 0x0094 */ public GcGalaxyStarTypes StarType;
        /* 0x0098 */ public int Planets;
        [NMS(Size = 8)]
        /* 0x00A0 */ public Vector3f[] PlanetPositions;
        [NMS(Size = 8)]
        /* 0x0120 */ public GcPlanetGenerationInputData[] PlanetGenerationInputs;
        [NMS(Size = 8)]
        /* 0x03A0 */ public int[] PlanetOrbits;
        /* 0x03C0 */ public int PrimePlanets;
        /* 0x03D0 */ public Vector3f SunPosition;
        /* 0x03E0 */ public NMSString0x10 AsteroidSubstanceID;
        /* 0x03F0 */ public int NumTradeRoutes;
        /* 0x03F4 */ public int NumVisibleTradeRoutes;
        /* 0x03F8 */ public int MaxNumFreighters;
        /* 0x03FC */ public bool StartWithFreighters;
        /* 0x0400 */ public Vector2f FreighterTimer;
        /* 0x0408 */ public Vector2f PirateTimer;
        /* 0x0410 */ public Vector2f FlybyTimer;
        /* 0x0420 */ public GcSpaceStationSpawnData SpaceStationSpawn;
        /* 0x0560 */ public GcSolarSystemTraderSpawnData TraderSpawnOnOutposts;
        /* 0x0574 */ public GcSolarSystemTraderSpawnData TraderSpawnInStations;
        /* 0x0588 */ public List<GcSolarSystemLocator> Locators;
        /* 0x0598 */ public List<NMSTemplate> AsteroidGenerators;
		public enum AsteroidLevelEnum { NoRares, SomeRares, LotsOfRares }
		/* 0x05A8 */ public AsteroidLevelEnum AsteroidLevel;
        /* 0x05B0 */ public GcPlanetColourData Colours;
        /* 0x1DC0 */ public GcLightProperties Light;
        /* 0x1DF0 */ public GcSpaceSkyProperties Sky;
        /* 0x1EA0 */ public GcScreenFilters ScreenFilter;
        /* 0x1EA4 */ public NMSString0x80 HeavyAir;
        /* 0x1F28 */ public List<GcAISpaceshipPreloadCacheData> SystemShips;
        /* 0x1F38 */ public GcAlienRace InhabitingRace;
        /* 0x1F3C */ public GcPlanetTradingData TradingData;
        /* 0x1F44 */ public GcPlayerConflictData ConflictData;
        
    }

}
