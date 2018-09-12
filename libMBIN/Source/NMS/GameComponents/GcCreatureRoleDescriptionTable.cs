using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0D2C6B913CD1676C7)]
    public class GcCreatureRoleDescriptionTable : NMSTemplate
    {
        public List<GcCreatureRoleDescription> RoleDescription;

        public float MinScaleVariance;
        public float MaxScaleVariance;
        public GcTerrainTileType TileType;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding1C;
    }
}
