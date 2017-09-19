using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x3C8)]
    public class GcPlanetGenerationIntermediateData : NMSTemplate
    {
        /* 0x000 */ public GcSeed Seed;
        /* 0x010 */ public int TerrainSettingIndex;
        /* 0x014 */ public GcGalaxyStarTypes GalaxyStarType;
        /* 0x018 */ public GcPlanetClass PlanetClass;
        /* 0x01C */ public GcPlanetSize PlanetSize;
        /* 0x020 */ public GcCreatureRoleDataTable CreatureRoleData;
        /* 0x030 */ public GcTerrainControls Terrain;
        /* 0x0A0 */ public GcBiomeType Biome;
        /* 0x0A4 */ public int BiomeFileIndex;

        [NMS(Size = 0x80)]
        /* 0x0A8 */ public string TerrainFile;
        [NMS(Size = 0x80)]
        /* 0x128 */ public string CreatureLandFile;
        [NMS(Size = 0x80)]
        /* 0x1A8 */ public string CreatureCaveFile;
        [NMS(Size = 0x80)]
        /* 0x228 */ public string CreatureWaterFile;
        [NMS(Size = 0x80)]
        /* 0x2A8 */ public string CreatureAirFile;
        [NMS(Size = 0x80)]
        /* 0x328 */ public string CreatureRobotFile;
        /* 0x3A8 */ public List<GcExternalObjectListOptions> ExternalObjectLists;
        /* 0x3B8 */ public List<int> ExternalObjectListIndices;
    }
}
