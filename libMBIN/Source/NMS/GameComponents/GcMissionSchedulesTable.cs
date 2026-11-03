using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x922FC39B58279A77, NameHash = 0x8F50F897)]
    public class GcMissionSchedulesTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcMissionSchedulingData> Schedules;
    }
}
