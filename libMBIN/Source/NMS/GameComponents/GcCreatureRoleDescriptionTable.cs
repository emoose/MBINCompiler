using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0x43D3A1033FAB5F68, NameHash = 0xBCFEFAC14ECD961B)]
    public class GcCreatureRoleDescriptionTable : NMSTemplate
    {
        /* 0x00 */ public List<GcCreatureRoleDescription> RoleDescription;
        /* 0x10 */ public float MinScaleVariance;
        /* 0x14 */ public float MaxScaleVariance;
        /* 0x18 */ public GcTerrainTileType TileType;
        /* 0x1C */ public GcPlanetLife LifeLevel;
    }
}
