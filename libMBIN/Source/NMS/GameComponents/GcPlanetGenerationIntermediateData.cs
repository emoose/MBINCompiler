using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x29B05B34F3DFDABA, NameHash = 0x166980043AF05C9E)]
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
        /* 0x0C0 */ public NMSString0x80 TerrainFile;
        /* 0x140 */ public NMSString0x80 CreatureLandFile;
        /* 0x1C0 */ public NMSString0x80 CreatureCaveFile;
        /* 0x240 */ public NMSString0x80 CreatureWaterFile;
        /* 0x2C0 */ public NMSString0x80 CreatureExtraWaterFile;
        /* 0x340 */ public NMSString0x80 CreatureAirFile;
        /* 0x3C0 */ public NMSString0x80 CreatureRobotFile;
        /* 0x440 */ public List<GcExternalObjectListOptions> ExternalObjectLists;
        /* 0x450 */ public List<int> ExternalObjectListIndices;
        /* 0x460 */ public bool Prime;
    }
}
