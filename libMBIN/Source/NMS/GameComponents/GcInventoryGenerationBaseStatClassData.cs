using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9D5CEE6847C31C54, NameHash = 0xADE121F93A7D37D0)]
    public class GcInventoryGenerationBaseStatClassData : NMSTemplate
    {
        /* 0x0 */ public List<GcInventoryGenerationBaseStatDataEntry> BaseStats;
    }
}
