using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA9EED7C55B0F050F, NameHash = 0xF97DB1C704357E47)]
    public class GcRewardTableItemList : NMSTemplate
    {
        // size: 0xA
        public enum RewardChoiceEnum : uint {
            GiveAll,
            Select,
            SelectAlways,
            TryEach,
            SelectSilent,
            GiveAllSilent,
            TryFirst_ThenSelectAlways,
            SelectFromSuccess,
            SelectAlwaysSilent,
            SelectFromSuccessSilent,
        }
        /* 0x00 */ public RewardChoiceEnum RewardChoice;
        /* 0x04 */ public bool OverrideZeroSeed;
        /* 0x05 */ public bool UseInventoryChoiceOverride;
        /* 0x08 */ public NMSString0x10 IncrementStat;
        /* 0x18 */ public List<GcRewardTableItem> List;
    }
}
