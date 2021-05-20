using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x10, GUID = 0xE5F4D8D17FB06A9F, NameHash = 0x3EB0EF943FFD976E)]
    public class GcUnlockableSeasonRewards : NMSTemplate
    {
        public List<GcUnlockableSeasonReward> Table;
    }
}
