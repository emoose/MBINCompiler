namespace MBINCompiler.Models.Structs
{
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
