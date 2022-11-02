using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCC85B34A4DF42A35, NameHash = 0x973B907FEECDAE57)]
    public class GcUnlockablePlatformRewards : NMSTemplate
    {
        /* 0x0 */ public List<GcUnlockablePlatformReward> Table;
    }
}
