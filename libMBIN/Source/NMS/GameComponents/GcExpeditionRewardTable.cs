using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xDDF0C2AFB733D9EE)]
    public class GcExpeditionRewardTable : NMSTemplate
    {
        public List<GcGenericRewardTableEntry> Table;
    }
}
