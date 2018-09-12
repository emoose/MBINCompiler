using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(Alignment = 0x8, GUID = 0x9A6FDE70E9836E1)]
    public class GcMissionConditionGroup : NMSTemplate
    {
        public GcMissionConditionTest ConditionTest;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding4;

        public List<NMSTemplate> Conditions;
    }
}
