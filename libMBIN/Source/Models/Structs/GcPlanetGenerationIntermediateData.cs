using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x3C8)]
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

        [NMS(Size = 0x80)]
        public string TerrainFile;
        [NMS(Size = 0x80)]
        public string CreatureLandFile;
        [NMS(Size = 0x80)]
        public string CreatureCaveFile;
        [NMS(Size = 0x80)]
        public string CreatureWaterFile;
        [NMS(Size = 0x80)]
        public string CreatureAirFile;
        [NMS(Size = 0x80)]
        public string CreatureRobotFile;
        public List<GcExternalObjectListOptions> ExternalObjectLists;
        public List<int> ExternalObjectListIndices;
    }
}
