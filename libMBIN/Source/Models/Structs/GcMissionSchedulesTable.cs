using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0D99DA1D84588E2FB)]
    public class GcMissionSchedulesTable : NMSTemplate
    {
        public List<GcMissionSchedulingData> Schedules;
    }
}
