using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0xA66AAC7948F38D4B, NameHash = 0xEAA492CB3579B238)]
    public class GcMissionSchedulesTable : NMSTemplate
    {
        public List<GcMissionSchedulingData> Schedules;
    }
}