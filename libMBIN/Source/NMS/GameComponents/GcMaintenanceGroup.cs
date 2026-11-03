using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD2EC6F6D275BB698, NameHash = 0xB07A9A6B)]
    public class GcMaintenanceGroup : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcMaintenanceGroupEntry> Table;
    }
}
