using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x674315100967283F, NameHash = 0x3EB0EF943FFD976E)]
    public class GcUnlockableSeasonRewards : NMSTemplate
    {
        /* 0x0 */ public List<GcUnlockableSeasonReward> Table;
    }
}
