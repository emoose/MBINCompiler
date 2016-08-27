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

    public class GcEnvironmentSpawnData : NMSTemplate
    {
        [NMS(Size = 0x40)]
        public byte[] UnmappedLists;
       /* public List<GcCreatureSpawnData> Creatures;
        public List<GcObjectSpawnData> Landmarks;
        public List<GcObjectSpawnData> Objects;
        public List<GcObjectSpawnData> DetailObjects; */
        public List<GcSelectableObjectSpawnList> SelectableObjects;
    }

    public class GcPlanetBuildingData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public byte[] UnmappedList;
        //public List<GcBuildingSpawnData> Buildings;
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
