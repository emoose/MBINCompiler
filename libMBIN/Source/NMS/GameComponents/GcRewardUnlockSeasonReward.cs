using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x18, GUID = 0x251398AB03485AB, NameHash = 0x7AB9EBA17278DE9B)]
    public class GcRewardUnlockSeasonReward : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string ProductID;
        /* 0x10 */ public bool Silent;
        /* 0x11 */ public bool UseSpecialFormatting;
        /* 0x12 */ public bool MarkAsClaimedInShop;
        [NMS(Size = 0x5, Ignore = true)]
        /* 0x13 */ public byte[] EndPadding;
    }
}
