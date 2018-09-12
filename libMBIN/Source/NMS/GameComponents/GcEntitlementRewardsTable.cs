using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0DA2E856096A99DAE)]
    public class GcEntitlementRewardsTable : NMSTemplate
    {
        public List<GcEntitlementRewardData> Table;
    }
}
