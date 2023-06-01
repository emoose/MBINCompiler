using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB8BAF404996F6201, NameHash = 0xF97DB1C704357E47)]
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
        /* 0x0 */ public RewardChoiceEnum RewardChoice;
        /* 0x4 */ public bool OverrideZeroSeed;
        /* 0x5 */ public bool UseInventoryChoiceOverride;
        /* 0x8 */ public List<GcRewardTableItem> List;
    }
}
