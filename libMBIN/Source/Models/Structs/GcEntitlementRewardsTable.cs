using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0DA2E856096A99DAE)]
    public class GcEntitlementRewardsTable : NMSTemplate
    {
        public List<GcEntitlementRewardData> Table;
    }
}
