using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x1F30, Alignment = 0x10, GUID = 0xEC4550E82DBC25BA, NameHash = 0x9B09276BB2795541)]
    public class GcSolarSystemData : NMSTemplate
    {
        /* 0x0000 */ public GcSeed Seed;
        [NMS(Size = 0x80)]
        /* 0x0010 */ public string Name;
        /* 0x0090 */ public GcSolarSystemClass Class;
        /* 0x0094 */ public GcGalaxyStarTypes StarType;
        /* 0x0098 */ public int Planets;
        [NMS(Size = 8)]
        /* 0x00A0 */ public Vector4f[] PlanetPositions;
        [NMS(Size = 8)]
        /* 0x0120 */ public GcPlanetGenerationInputData[] PlanetGenerationInputs;
        [NMS(Size = 8)]
        /* 0x03A0 */ public int[] PlanetOrbits;
        /* 0x03C0 */ public Vector3f SunPosition;
        [NMS(Size = 0x10)]
        /* 0x03D0 */ public string AsteroidSubstanceID;
        /* 0x03E0 */ public int NumTradeRoutes;
        /* 0x03E4 */ public int NumVisibleTradeRoutes;
        /* 0x03E8 */ public int MaxNumFreighters;
        /* 0x03EC */ public bool StartWithFreighters;
        /* 0x03F0 */ public Vector2f FreighterTimer;
        /* 0x03F8 */ public Vector2f PirateTimer;
        /* 0x0400 */ public Vector2f FlybyTimer;
        /* 0x0410 */ public GcSpaceStationSpawnData SpaceStationSpawn;
        /* 0x0550 */ public GcSolarSystemTraderSpawnData TraderSpawnOnOutposts;
        /* 0x0564 */ public GcSolarSystemTraderSpawnData TraderSpawnInStations;
        /* 0x0578 */ public List<GcSolarSystemLocator> Locators;
        /* 0x0588 */ public List<NMSTemplate> AsteroidGenerators;
		public enum AsteroidLevelEnum { NoRares, SomeRares, LotsOfRares }
		/* 0x0598 */ public AsteroidLevelEnum AsteroidLevel;
        /* 0x05A0 */ public GcPlanetColourData Colours;
        /* 0x1DB0 */ public GcLightProperties Light;
        /* 0x1DE0 */ public GcSpaceSkyProperties Sky;
        /* 0x1E80 */ public GcScreenFilters ScreenFilter;
        [NMS(Size = 0x80)] 
        /* 0x1E84 */ public string HeavyAir;
        /* 0x1F08 */ public List<GcAISpaceshipPreloadCacheData> SystemShips;
        /* 0x1F18 */ public GcAlienRace InhabitingRace;
        /* 0x1F1C */ public GcPlanetTradingData TradingData;
        /* 0x1F24 */ public GcPlayerConflictData ConflictData;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x1F28 */ public byte[] EndPadding;
        
    }

}
