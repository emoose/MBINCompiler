using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x10, GUID = 0x0E635E41ED9249C06)]
    public class GcTileTypeSets : NMSTemplate
    {
        public List<GcTileTypeSet> TileTypeSets;
    }
}
