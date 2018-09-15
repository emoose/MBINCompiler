using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0xE635E41ED9249C06)]
    public class GcTileTypeSets : NMSTemplate
    {
        public List<GcTileTypeSet> TileTypeSets;
    }
}
