using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x60, GUID = 0x4E00CA8D83E07DB7, NameHash = 0x64786DD8F4475C9B)]
    public class GcSettlementJudgementOption : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A OptionText;
        /* 0x20 */ public List<GcSettlementJudgementPerkOption> Perks;
        /* 0x30 */ public bool HidePerkInJudgement;
        /* 0x38 */ public List<GcSettlementStatChange> StateChanges;
        /* 0x48 */ public List<NMSString0x10> AdditionalRewards;
        /* 0x58 */ public bool UsePolicyPerk;
        /* 0x59 */ public bool UsePolicyStat;
        /* 0x5A */ public bool UseGiftReward;
        /* 0x5B */ public bool UseTechPerk;
    }
}
