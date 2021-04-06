using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x10, GUID = 0xBAD34AF4FE7A0E56, NameHash = 0x3EB0EF943FFD976E)]
    public class GcUnlockableSeasonRewards : NMSTemplate
    {
        public List<GcUnlockableSeasonReward> Table;
    }
}
