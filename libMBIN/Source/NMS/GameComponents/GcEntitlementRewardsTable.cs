using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDA2E856096A99DAE, NameHash = 0x1B43FEE74DE674AE)]
    public class GcEntitlementRewardsTable : NMSTemplate
    {
        /* 0x0 */ public List<GcEntitlementRewardData> Table;
    }
}
