using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAC7D4BC44729D2D2, NameHash = 0xEAA492CB3579B238)]
    public class GcMissionSchedulesTable : NMSTemplate
    {
        /* 0x0 */ public List<GcMissionSchedulingData> Schedules;
    }
}
