using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAFAC54E3E24D9E8E, NameHash = 0x9B09276BB2795541)]
    public class GcSolarSystemData : NMSTemplate
    {
        /* 0x0000 */ public GcSeed Seed;
        /* 0x0010 */ public NMSString0x80 Name;
        /* 0x0090 */ public GcSolarSystemClass Class;
        /* 0x0094 */ public GcGalaxyStarTypes StarType;
        /* 0x0098 */ public int Planets;
        [NMS(Size = 0x8)]
        /* 0x00A0 */ public Vector3f[] PlanetPositions;
        [NMS(Size = 0x8)]
        /* 0x0120 */ public GcPlanetGenerationInputData[] PlanetGenerationInputs;
        [NMS(Size = 0x8)]
        /* 0x03A0 */ public int[] PlanetOrbits;
        /* 0x03C0 */ public int PrimePlanets;
        /* 0x03D0 */ public Vector3f SunPosition;
        /* 0x03E0 */ public NMSString0x10 AsteroidSubstanceID;
        /* 0x03F0 */ public int NumTradeRoutes;
        /* 0x03F4 */ public int NumVisibleTradeRoutes;
        /* 0x03F8 */ public int MaxNumFreighters;
        /* 0x03FC */ public bool StartWithFreighters;
        /* 0x0400 */ public Vector2f FreighterTimer;
        /* 0x0408 */ public Vector2f SpacePirateTimer;
        /* 0x0410 */ public Vector2f PlanetPirateTimer;
        /* 0x0418 */ public Vector2f FlybyTimer;
        /* 0x0420 */ public Vector2f PoliceTimer;
        /* 0x0430 */ public GcSpaceStationSpawnData SpaceStationSpawn;
        /* 0x0570 */ public GcSolarSystemTraderSpawnData TraderSpawnOnOutposts;
        /* 0x0584 */ public GcSolarSystemTraderSpawnData TraderSpawnInStations;
        /* 0x0598 */ public List<GcSolarSystemLocator> Locators;
        /* 0x05A8 */ public List<NMSTemplate> AsteroidGenerators;
        // size: 0x3
        public enum AsteroidLevelEnum : uint {
            NoRares,
            SomeRares,
            LotsOfRares,
        }
        /* 0x05B8 */ public AsteroidLevelEnum AsteroidLevel;
        /* 0x05C0 */ public GcPlanetColourData Colours;
        /* 0x2150 */ public GcLightProperties Light;
        /* 0x2180 */ public GcSpaceSkyProperties Sky;
        /* 0x2230 */ public GcScreenFilters ScreenFilter;
        /* 0x2234 */ public NMSString0x80 HeavyAir;
        /* 0x22B8 */ public List<GcAISpaceshipPreloadCacheData> SystemShips;
        /* 0x22C8 */ public GcSeed SentinelCrashSiteShipSeed;
        /* 0x22D8 */ public GcAlienRace InhabitingRace;
        /* 0x22DC */ public GcPlanetTradingData TradingData;
        /* 0x22E4 */ public GcPlayerConflictData ConflictData;
    }
}
