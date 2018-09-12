using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0D99DA1D84588E2FB)]
    public class GcMissionSchedulesTable : NMSTemplate
    {
        public List<GcMissionSchedulingData> Schedules;
    }
}
