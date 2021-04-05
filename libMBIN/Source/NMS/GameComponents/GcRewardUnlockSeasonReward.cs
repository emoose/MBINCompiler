using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x18, GUID = 0x0000000000000000, NameHash = 0x7AB9EBA17278DE9B)]
    public class GcRewardUnlockSeasonReward : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string ProductID;
        public bool Silent;
        public bool UseSpecialFormatting;
        [NMS(Size = 0x6, Ignore = true)]
        public byte[] EndPadding;
    }
}
