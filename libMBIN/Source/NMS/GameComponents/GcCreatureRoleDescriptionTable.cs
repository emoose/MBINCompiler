using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0x82060166C6BEF63B)]
    public class GcCreatureRoleDescriptionTable : NMSTemplate
    {
        public List<GcCreatureRoleDescription> RoleDescription;

        public float MinScaleVariance;
        public float MaxScaleVariance;
        public GcTerrainTileType TileType;

        [NMS(Size = 4, Ignore = true)]
        public byte[] EndPadding;
    }
}
