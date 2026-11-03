using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD7459328AFB8095F, NameHash = 0x574CBA5D)]
    public class GcStatRewardsTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcStatRewardGroup> StatRewardGroups;
    }
}
