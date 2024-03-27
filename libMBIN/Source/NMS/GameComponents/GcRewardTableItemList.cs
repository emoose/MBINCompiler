using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2B21604483DD7434, NameHash = 0xF97DB1C704357E47)]
    public class GcRewardTableItemList : NMSTemplate
    {
        // size: 0xB
        public enum RewardChoiceEnum : uint {
            GiveAll,
            Select,
            SelectAlways,
            TryEach,
            SelectSilent,
            GiveAllSilent,
            TryFirst_ThenSelectAlways,
            GiveFirst_ThenAlsoSelectAlwaysFromRest,
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
