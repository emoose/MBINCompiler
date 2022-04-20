using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x10, GUID = 0x7AF10BD561DC941B, NameHash = 0xF99FFC7B95E84D7D)]
    public class GcTileTypeSets : NMSTemplate
    {
        /* 0x0 */ public List<GcTileTypeSet> TileTypeSets;
    }
}
