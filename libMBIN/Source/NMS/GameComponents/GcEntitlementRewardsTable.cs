using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCA484CAA23442294, NameHash = 0xA18C28E)]
    public class GcEntitlementRewardsTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcEntitlementRewardData> Table;
    }
}
