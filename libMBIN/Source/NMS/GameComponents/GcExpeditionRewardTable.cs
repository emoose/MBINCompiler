using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x505FDF971BB7421A)]
    public class GcExpeditionRewardTable : NMSTemplate
    {
        public List<GcGenericRewardTableEntry> Table;
    }
}
