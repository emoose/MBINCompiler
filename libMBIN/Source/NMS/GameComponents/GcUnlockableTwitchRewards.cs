using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDAE66604A5D6F5D4, NameHash = 0x3911154D)]
    public class GcUnlockableTwitchRewards : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcUnlockableTwitchReward> Table;
    }
}
