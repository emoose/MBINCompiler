using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0xCD0F12F746CB16B3, NameHash = 0xF99FFC7B95E84D7D)]
    public class GcTileTypeSets : NMSTemplate
    {
        public List<GcTileTypeSet> TileTypeSets;
    }
}
