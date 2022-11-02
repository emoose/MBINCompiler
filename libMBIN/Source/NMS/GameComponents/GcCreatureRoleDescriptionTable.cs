using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA9AC01707FCBC9B3, NameHash = 0xBCFEFAC14ECD961B)]
    public class GcCreatureRoleDescriptionTable : NMSTemplate
    {
        /* 0x00 */ public List<GcCreatureRoleDescription> RoleDescription;
        /* 0x10 */ public float MinScaleVariance;
        /* 0x14 */ public float MaxScaleVariance;
        /* 0x18 */ public GcTerrainTileType TileType;
        /* 0x1C */ public GcPlanetLife LifeLevel;
    }
}
