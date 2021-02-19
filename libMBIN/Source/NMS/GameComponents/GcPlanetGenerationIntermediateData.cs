using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x468, GUID = 0x9798C9A9CE960417, NameHash = 0x166980043AF05C9E)]
    public class GcPlanetGenerationIntermediateData : NMSTemplate
    {
        /* 0x000 */ public GcSeed Seed;
        /* 0x010 */ public int TerrainSettingIndex;
        /* 0x014 */ public GcGalaxyStarTypes StarType;
        /* 0x018 */ public GcPlanetClass Class;
        /* 0x01C */ public GcPlanetSize Size;
        /* 0x020 */ public GcCreatureRoleDataTable CreatureRoles;
        /* 0x040 */ public GcTerrainControls Terrain;
        /* 0x0B8 */ public GcBiomeType Biome;
        /* 0x0BC */ public GcBiomeSubType BiomeSubType;
        [NMS(Size = 0x80)]
        /* 0x0C0 */ public string TerrainFile;
        [NMS(Size = 0x80)]
        /* 0x140 */ public string CreatureLandFile;
        [NMS(Size = 0x80)]
        /* 0x1C0 */ public string CreatureCaveFile;
        [NMS(Size = 0x80)]
        /* 0x240 */ public string CreatureWaterFile;
        [NMS(Size = 0x80)]
        /* 0x2C0 */ public string CreatureExtraWaterFile;
        [NMS(Size = 0x80)]
        /* 0x340 */ public string CreatureAirFile;
        [NMS(Size = 0x80)]
        /* 0x3C0 */ public string CreatureRobotFile;
        /* 0x440 */ public List<GcExternalObjectListOptions> ExternalObjectLists;
        /* 0x450 */ public List<int> ExternalObjectListIndices;
        /* 0x460 */ public bool Prime;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x461 */ public byte[] EndPadding;
    }
}
