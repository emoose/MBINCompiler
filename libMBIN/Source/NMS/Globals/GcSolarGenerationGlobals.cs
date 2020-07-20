using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x3D0, GUID = 0x7ED61A640709B8D8)]
    public class GcSolarGenerationGlobals : NMSTemplate
    {
        /* 0x0 */ public bool MassiveSolarSystems;
        /* 0x10 */ public Vector3f SolarSystemSize;
        /* 0x20 */ public float SolarSystemMaximumRadius;
        /* 0x24 */ public float SolarSystemMaximumRadiusMassive;
        /* 0x28 */ public bool GenerateMaximumSolarSystem;
        /* 0x2C */ public int GenerateForcedNumberPlanets;
        /* 0x30 */ public bool UseSingleRacePerSystem;
        /* 0x34 */ public Vector2f PerPlanetGenerationAngleChangeDegreesRange;
        /* 0x3C */ public Vector2f PerPlanetGenerationElevationChangeDegreesRange;
        /* 0x44 */ public Vector2f SpawnPointStationToPlanetInterpRange;
        [NMS(Size = 0x4, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x4C */ public float[] ExtremePlanetChance;
        /* 0x5C */ public float StationSpawnAvoidRadius;
        /* 0x60 */ public int LocatorScatterMinCount;
        /* 0x64 */ public int LocatorScatterMaxCount;
        /* 0x68 */ public float LocatorScatterMaxDistanceFromPlanet;
        /* 0x6C */ public int LocatorScatterChanceOfCapitalShips;
        /* 0x70 */ public int LocatorScatterChanceOfPirates;
        /* 0x74 */ public float DirectorLocatorBusyDistance;
        /* 0x78 */ public float DirectorLocatorBusyAngle;
        /* 0x7C */ public float PlanetInvalidAsteroidZone;
        /* 0x80 */ public bool AsteroidsEnabled;
        /* 0x81 */ public bool AsteroidsCheckNoise;
        /* 0x84 */ public float AsteroidNoiseScale;
        /* 0x88 */ public float AsteroidDetailNoiseScale;
        /* 0x8C */ public int AsteroidNoiseOctaves;
        /* 0x90 */ public float AsteroidNoiseMinCutoff;
        /* 0x94 */ public float AsteroidNoiseMaxCutoff;
        /* 0x98 */ public float AsteroidRotateMin;
        /* 0x9C */ public float AsteroidRotateMax;
        /* 0xA0 */ public Vector2f AsteroidScaleVariance;
        /* 0xA8 */ public float AsteroidFadeTime;
        /* 0xAC */ public Vector2f AsteroidNoiseRange;
        /* 0xB4 */ public Vector2f LargeAsteroidNoiseRange;
        /* 0xBC */ public Vector2f RareAsteroidNoiseRangeFewRares;
        /* 0xC4 */ public Vector2f RareAsteroidNoiseRangeSomeRares;
        /* 0xCC */ public Vector2f RareAsteroidNoiseRangeLotsOfRares;
        /* 0xD4 */ public float AsteroiSomeRaresOdds;
        /* 0xD8 */ public float AsteroidLotsOfRaresOdds;
        /* 0xDC */ public float AsteroidFadeRangeMin;
        /* 0xE0 */ public float AsteroidFadeRangeMax;
        /* 0xE4 */ public float AsteroidSpacing;
        /* 0xE8 */ public float RareAsteroidScale;
        /* 0xEC */ public int RareAsteroidMinResources;
        /* 0xF0 */ public int RareAsteroidMaxResources;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0xF4 */ public byte[] PaddingF4;
        [NMS(Size = 0x10)]
        /* 0xF8 */ public string RareAsteroidResource;
        /* 0x108 */ public int RareAsteroidHealth;
        /* 0x10C */ public float CommonAsteroidScale;
        /* 0x110 */ public int CommonAsteroidMinResources;
        /* 0x114 */ public int CommonAsteroidMaxResources;
        /* 0x118 */ public int CommonAsteroidResourceFuelMultiplier;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x11C */ public byte[] Padding11C;
        [NMS(Size = 0x10)]
        /* 0x120 */ public string CommonAsteroidResourceFuel;
        [NMS(Size = 0x10)]
        /* 0x130 */ public string RareAsteroidResourceFuel;     // GEODE_SPACE
        [NMS(Size = 0x10)]
        /* 0x140 */ public string CommonAsteroidResourceProduct;     // GEODE_ASTEROID
        [NMS(Size = 0x10)]
        /* 0x150 */ public string CommonAsteroidResourceMain;
        [NMS(Size = 0x10)]
        /* 0x160 */ public string CommonAsteroidResourceSecondary;
        [NMS(Size = 0x10)]
        /* 0x170 */ public string RareAsteroidDataProduct;
        /* 0x180 */ public float CommonAsteroidResourceFuelOdds;
        /* 0x184 */ public float RareAsteroidResourceFuelOdds;
        /* 0x188 */ public float CommonAsteroidResourceProductOdds;
        /* 0x18C */ public float RareAsteroidDataProductOdds;
        /* 0x190 */ public float CommonAsteroidResourceSecondaryOdds;
        /* 0x194 */ public int CommonAsteroidHealth;
        /* 0x198 */ public float LargeAsteroidSpacing;
        /* 0x19C */ public float LargeAsteroidFadeTime;
        /* 0x1A0 */ public float LargeAsteroidFadeRangeMin;
        /* 0x1A4 */ public float LargeAsteroidFadeRangeMax;
        /* 0x1A8 */ public float LargeAsteroidMoveFadeTime;
        /* 0x1AC */ public float RingAsteroidScale;
        /* 0x1B0 */ public float RingAsteroidSpacing;
        /* 0x1B4 */ public float RingAsteroidFadeRangeMin;
        /* 0x1B8 */ public float RingAsteroidFadeRangeMax;
        /* 0x1BC */ public int AsteroidMaxNumGenerates;
        /* 0x1C0 */ public int AsteroidMaxNumGeneratesPulseJump;
        /* 0x1C4 */ public float AsteroidSpaceStationAvoidRadius;
        /* 0x1C8 */ public float AsteroidAnomalyAvoidRadius;
        /* 0x1CC */ public float AsteroidWarpInAreaAvoidRadius;
        [NMS(Size = 0x4, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x1D0 */ public float[] AbandonedSystemProbability;
        [NMS(Size = 0x4, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x1E0 */ public float[] EmptySystemProbability;
        /* 0x1F0 */ public int CivilianTraderSpaceshipsCacheCount;
        [NMS(Size = 0x3)]
        /* 0x1F4 */ public float[] SpaceshipSpawnFreqMultipliers;
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]     // I think this is the enum type...
        /* 0x200 */ public GcAISpaceshipWeightingData[] SpaceshipWeightings;
        /* 0x300 */ public float PlanetRingProbability;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x304 */ public byte[] Padding304;
        /* 0x310 */ public GcPlanetRingData PlanetRingsMin;
        /* 0x370 */ public GcPlanetRingData PlanetRingsMax;
    }
}
