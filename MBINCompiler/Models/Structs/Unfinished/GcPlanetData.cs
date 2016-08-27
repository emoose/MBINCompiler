using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcPlanetLife : NMSTemplate
    {
        public int LifeSetting;
        public string[] LifeSettingValues()
        {
            return new[] { "Dead", "Low", "Mid", "Full" };
        }
    }

    public class GcPlanetHazardData : NMSTemplate
    {
        [NMS(Size = 5)]
        public float[] Temperature;

        [NMS(Size = 5)]
        public float[] Toxicity;

        [NMS(Size = 5)]
        public float[] Radiation;

        [NMS(Size = 5)]
        public float[] OutputTemperature;

        [NMS(Size = 5)]
        public float[] OutputToxicity;

        [NMS(Size = 5)]
        public float[] OutputRadiation;
    }

    public class GcBuildingDensityLevels : NMSTemplate
    {
        public int BuildingDensity;
        public string[] BuildingDensityValues()
        {
            return new[] { "Dead", "Low", "Mid", "Full", "RelicOnly", "IndustrialOnly" };
        }
    }

    public class GcColourPaletteData : NMSTemplate
    {
        [NMS(Size = 5)]
        public Colour[] Colours;
    }

    public class GcPlanetColourData : NMSTemplate
    {
        [NMS(Size = 0x26)]
        public GcColourPaletteData[] Palettes;
    }

    public class GcWeatherOptions : NMSTemplate
    {
        public int Weather;
        public string[] WeatherValues()
        {
            return new[] { "Clear", "Dust", "Humid", "Snow", "Toxic", "Scorched", "Radioactive" };
        }
    }

    public class GcPlanetWeatherData : NMSTemplate
    {
        public GcWeatherOptions WeatherOptions;
        public GcPlanetWeatherColourData NightColours;
        public GcPlanetHeavyAirData HeavyAir;
        public float NightDensity;
        public int WeatherIntensity;
        public string[] WeatherIntensityValues()
        {
            return new[] { "Default", "Extreme" };
        }
        public int StormFrequency;
        public string[] StormFrequencyValues()
        {
            return new[] { "None", "Low", "High" };
        }
        public int AtmosphereType;
        public string[] AtmosphereTypeValues()
        {
            return new[] { "None", "Normal" };
        }
        public int DayColourIndex;
        public int DuskColourIndex;
        public int NightColourIndex;
    }

    public class GcSelectableObjectSpawnData : NMSTemplate
    {
        public GcResourceElement Resource;
    }

    public class GcSelectableObjectSpawnList : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Name;
        public List<GcSelectableObjectSpawnData> Objects;
    }

    public class GcCreatureSpawnData : NMSTemplate // 0x598 bytes
    {
        /* 0x000 */ public GcResourceElement Resource;
        /* 0x2A8 */ public GcResourceElement FemaleResource;

        /* 0x550 */ public GcTerrainTileType PlacementTileType;

        /* 0x554 */ public bool SwapPrimaryForSecondaryColour;
        /* 0x555 */ public bool SwapPrimaryForRandomColour;

        /* 0x558 */ public float PositioningMinScale;
        /* 0x55C */ public float PositioningMaxScale;

        /* 0x560 */ public string CreatureID;
        /* 0x570 */ public GcCreatureTypes CreatureType;
        /* 0x574 */ public GcCreatureRoles CreatureRole;
        /* 0x578 */ public int CreatureMinGroupSize;
        /* 0x57C */ public int CreatureMaxGroupSize;
        /* 0x580 */ public float CreatureGroupsPerSquareKm;
        /* 0x584 */ public float CreatureSpawnDistance;
        /* 0x588 */ public float CreatureDespawnDistance;
        /* 0x58C */ public float CreatureActiveInDayChance;
        /* 0x590 */ public float CreatureActiveInNightChance;
        /* 0x594 */ public int RoleDataIndex;
    }

    public class GcObjectSpawnData : NMSTemplate // 0x378 bytes
    {
        public int Type;
        public string[] TypeValues()
        {
            return new[] { "Instanced", "Single" };
        }
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding4;

        /* 0x008 */ public GcResourceElement Resource;
        /* 0x2B0 */ public List<GcResourceElement> AltResources;

        /* 0x2C0 */ public GcTerrainTileType PlacementTileType;
        [NMS(Size = 0x10)]
        /* 0x2C8 */ public string Placement;
        /* 0x2D8 */ public GcSeed PlacementSeed;
        /* 0x2E8 */ public int PlacementPriority;
        public string[] PlacementPriorityValues()
        {
            return new[] { "Low", "Normal", "High" };
        }

        /* 0x2EC */ public float PlacementCoverage;
        /* 0x2F0 */ public float PlacementFlatDensity;
        /* 0x2F4 */ public float PlacementSlopeDensity;
        /* 0x2F8 */ public float PlacementSlopeMultiplier;

        /* 0x2FC */ public int RestrictionsLargeObjectCoverage;
        public string[] RestrictionsLargeObjectCoverageValues()
        {
            return new[] { "DoNotPlace", "DoNotPlaceClose", "OnlyPlaceAround", "AlwaysPlace" };
        }
        /* 0x300 */ public int RestrictionsOverlapStyle;
        public string[] RestrictionsOverlapStyleValues()
        {
            return new[] { "None", "SameSeed", "All" };
        }
        /* 0x304 */ public float RestrictionsMinHeight;
        /* 0x308 */ public float RestrictionsMaxHeight;
        /* 0x30C */ public bool RestrictionsRelativeToSeaLevel;
        /* 0x310 */ public float RestrictionsMinAngle;
        /* 0x314 */ public float RestrictionsMaxAngle;

        /* 0x318 */ public int FadeMinRegionRadius; // might be float
        /* 0x31C */ public int FadeMaxRegionRadius; // might be float
        /* 0x320 */ public int FadeMaxImposterRadius; // might be float

        /* 0x324 */ public float FadeInStartDistance;
        /* 0x328 */ public float FadeInEndDistance;
        /* 0x32C */ public float FadeInOffsetDistance;
        /* 0x330 */ public float FadeOutStartDistance;
        /* 0x334 */ public float FadeOutEndDistance;
        /* 0x338 */ public float FadeOutOffsetDistance;

        /* 0x33C */ public bool MatchGroundColour;
        /* 0x340 */ public int GroundColourIndex;
        public string[] GroundColourIndexValues()
        {
            return new[] { "Auto", "Main", "Patch" };
        }

        /* 0x344 */ public bool SwapPrimaryForSecondaryColour;
        /* 0x345 */ public bool SwapPrimaryForRandomColour;

        /* 0x346 */ public bool PositioningAlignToNormal;
        /* 0x348 */ public float PositioningMinScale;
        /* 0x34C */ public float PositioningMaxScale;
        /* 0x350 */ public float PositioningMinYScale;
        /* 0x354 */ public float PositioningMaxYScale;
        /* 0x358 */ public float PositioningSlopeScaling;
        /* 0x35C */ public float PositioningPatchEdgeScaling;
        /* 0x360 */ public float PositioningMaxXZRotation;

        /* 0x364 */ public bool ObjectAutoCollision;
        /* 0x365 */ public bool ObjectCollideWithPlayer;
        /* 0x366 */ public bool ObjectCreaturesCanEat;
        /* 0x368 */ public float ObjectShearWindStrength;

        /* 0x36C */ public int RuntimeCacheCachedCollisionNodeCount; // might be float
        /* 0x370 */ public bool RuntimeCacheAllowLimiting;
        [NMS(Size = 0x7)]
        /* 0x371 */ public byte[] Padding371;
    }

    public class GcEnvironmentSpawnData : NMSTemplate
    {
        public List<GcCreatureSpawnData> Creatures;
        public List<GcObjectSpawnData> Landmarks;
        public List<GcObjectSpawnData> Objects;
        public List<GcObjectSpawnData> DetailObjects;
        public List<GcSelectableObjectSpawnList> SelectableObjects;
    }

    public class GcBuildingClassification : NMSTemplate
    {
        public int BuildingClass;
        public string[] BuildingClassValues()
        {
            return new[]
            {
                "None", "TerrainResource", "Shelter", "Abandoned", "Terminal", "Shop", "Outpost", "Waypoint",
                "Beacon", "RadioTower", "Observatory", "Depot", "Factory", "Harvester", "Plaque", "Monolith",
                "Portal", "Ruin", "Debris", "DamagedMachine", "DistressSignal", "LandingPad"
            };
        }
    }

    public class GcBuildingSpawnData : NMSTemplate // 0x5D0 bytes
    {
        /* 0x000 */ public float Density;
        [NMS(Size = 4, Ignore = true)]
        /* 0x004 */ public byte[] Padding4;

        /* 0x008 */ public GcResourceElement Resource;
        /* 0x2B0 */ public GcResourceElement UnderwaterResource;
        /* 0x558 */ public int LSystemID;
        /* 0x55C */ public int UnderwaterLSystemID;
        /* 0x560 */ public bool AutoCollision;
        [NMS(Size = 7, Ignore = true)]
        /* 0x561 */ public byte[] Padding561;

        /* 0x568 */ public GcSeed Seed;
        /* 0x578 */ public GcBuildingClassification BuildingClass;
        /* 0x57C */ public GcBuildingClusterPlacement BuildingClusterPlacement;
        /* 0x580 */ public bool AddWaypoint;
        /* 0x581 */ public bool AddShelter;
        /* 0x582 */ public bool AddLandingPad;
        /* 0x583 */ public bool GivesShelter;

        /* 0x584 */ public bool PositioningAlignToNormal;
        /* 0x585 */ public bool PositioningLowerIntoGround;
        /* 0x588 */ public float PositioningScale;
        /* 0x58C */ public float PositioningMaxXZRotation;
        /* 0x590 */ public float PositioningRadius;

        /* 0x594 */ public int InstanceID;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x598 */ public byte[] Padding598;

        /* 0x5A0 */ public Vector4f AABBMin;
        /* 0x5B0 */ public Vector4f AABBMax;
        /* 0x5C0 */ public bool BuildingSizeCalculated;
        [NMS(Size = 0xF, Ignore = true)]
        /* 0x5C1 */ public byte[] Padding5C1;
    }

    public class GcPlanetBuildingData : NMSTemplate
    {
        public List<GcBuildingSpawnData> Buildings;
        public float Spacing;
    }

    public class GcGalaxyStarTypes : NMSTemplate
    {
        public int GalaxyStarType;
        public string[] GalaxyStarTypeValues()
        {
            return new[] { "Yellow", "Green", "Blue", "Red" };
        }
    }

    public class GcPlanetClass : NMSTemplate
    {
        public int PlanetClass;
        public string[] PlanetClassValues()
        {
            return new[] { "Default", "Initial", "InInitialSystem" };
        }
    }

    public class GcPlanetSize : NMSTemplate
    {
        public int PlanetSize;
        public string[] PlanetSizeValues()
        {
            return new[] { "Large", "Medium", "Small", "Moon" };
        }
    }

    public class GcCreatureInfo : NMSTemplate
    {
        public int Age;
        public string[] AgeValues()
        {
            return new[] { "Regular", "Weird" };
        }

        [NMS(Size = 0x80)]
        public string Gender1;
        [NMS(Size = 0x80)]
        public string Gender2;
        [NMS(Size = 0x80)]
        public string Temperament;
        [NMS(Size = 0x80)]
        public string Diet;
        [NMS(Size = 0x80)]
        public string Weight1;
        [NMS(Size = 0x80)]
        public string Height1;
        [NMS(Size = 0x80)]
        public string Weight2;
        [NMS(Size = 0x80)]
        public string Height2;

        public float Weight1Float;
        public float Height1Float;
        public float Weight2Float;
        public float Height2Float;

        public GcRarity Rarity;

    }

    public class GcCreatureRoleData : NMSTemplate
    {
        public GcSeed Seed;
        public GcCreatureTypes CreatureType;
        [NMS(Size = 0x10)]
        public string CreatureId;
        public GcCreatureRoleDescription Description;
        public GcCreatureInfo Info;
        public GcTerrainTileType TileType;
        public int Diet;
        public string[] DietValues()
        {
            return new[] { "Carnivore", "Omnivore", "Herbivore" };
        }
        public float BaseScale;
    }

    public class GcCreatureRoleDataTable : NMSTemplate
    {
        public List<GcCreatureRoleData> AvailableRoles;
    }

    public class GcBiomeType : NMSTemplate
    {
        public int Biome;
        public string[] BiomeValues()
        {
            return new[] { "Lush", "Toxic", "Scorched", "Radioactive", "Frozen", "Barren", "Dead", "Test", "All" };
        }
    }

    public class GcPlanetGenerationIntermediateData : NMSTemplate
    {
        public GcSeed Seed;
        public int TerrainSettingIndex;
        public GcGalaxyStarTypes GalaxyStarType;
        public GcPlanetClass PlanetClass;
        public GcPlanetSize PlanetSize;
        public GcCreatureRoleDataTable CreatureRoleData;
        public GcTerrainControls Terrain;
        public GcBiomeType Biome;

        public string TerrainFile;
        public string CreatureLandFile;
        public string CreatureCaveFile;
        public string CreatureWaterFile;
        public string CreatureAirFile;
        public string CreatureRobotFile;
        public List<GcExternalObjectListOptions> ExternalObjectLists;
        public List<int> ExternalObjectListIndices;
    }

    public class GcPlanetSentinelData : NMSTemplate
    {
        public int SentinelLevel;
        public string[] SentinelLevelValues()
        {
            return new[] { "Default", "Aggressive" };
        }

        public int MaxActiveDrones;
    }

    public class GcPlanetData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Name;
        public GcPlanetLife LifeSetting1;
        public GcPlanetLife LifeSetting2;
        public GcPlanetHazardData Hazard;
        public int ResourceLevel;
        public string[] ResourceLevelValues()
        {
            return new[] { "Low", "High" };
        }

        public GcBuildingDensityLevels BuildingDensityLevels;
        [NMS(Size = 0x10)]
        public string CommonSubstanceID;
        [NMS(Size = 0x10)]
        public string UncommonSubstanceID;
        [NMS(Size = 0x10)]
        public string RareSubstanceID;

        public GcPlanetColourData PlanetColourData;

        [NMS(Size = 0xD)]
        public Colour[] TileColours;
        public GcPlanetWeatherData Weather;
        public GcPlanetWaterData Water;
        [NMS(Size = 0x80)]
        public string TerrainFile;
        public TkVoxelGeneratorData Terrain;
        [NMS(Size = 0xA)]
        public TkPaletteTexture[] TileTypes;
        [NMS(Size = 0x80)]
        public string DiffuseTexture;
        [NMS(Size = 0x80)]
        public string NormalMap;
        public GcEnvironmentSpawnData SpawnData;
        public GcAlienRace AlienRace;
        public GcPlanetBuildingData BuildingData;
        public GcPlanetGenerationIntermediateData GenerationData;
        public Vector2f SentinelTimer;
        public Vector2f FlybyTimer;
        public GcPlanetSentinelData SentinelData;
    }
}
