using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3F821EFA320B5781, NameHash = 0xADE121F93A7D37D0)]
    public class GcInventoryGenerationBaseStatClassData : NMSTemplate
    {
        /* 0x0 */ public List<GcInventoryGenerationBaseStatDataEntry> BaseStats;
    }
}
