using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0x45465ADD88BB6EC3, NameHash = 0xBCFEFAC14ECD961B)]
    public class GcCreatureRoleDescriptionTable : NMSTemplate
    {
        public List<GcCreatureRoleDescription> RoleDescription;
        public float MinScaleVariance;
        public float MaxScaleVariance;
        public GcTerrainTileType TileType;
        public GcPlanetLife LifeLevel;
    }
}
