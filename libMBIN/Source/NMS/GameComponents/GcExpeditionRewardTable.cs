using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x505FDF971BB7421A)]
    public class GcExpeditionRewardTable : NMSTemplate
    {
        public List<GcGenericRewardTableEntry> Table;
    }
}
