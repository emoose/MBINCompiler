using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDDDFB55CAB08B05, NameHash = 0xF128895FDB533FA8)]
    public class GcUnlockableTwitchRewards : NMSTemplate
    {
        /* 0x0 */ public List<GcUnlockableTwitchReward> Table;
    }
}
