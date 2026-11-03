using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEC7BF86DB52CD000, NameHash = 0x3514EB26)]
    public class GcSettlementJudgementOption : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A OptionText;
        [NMS(Index = 5)]
        /* 0x20 */ public List<NMSString0x10> AdditionalRewards;
        [NMS(Index = 1)]
        /* 0x30 */ public List<NMSString0x20A> AltOptionText;
        [NMS(Index = 6)]
        /* 0x40 */ public NMSString0x10 ChainedJudgementID;
        [NMS(Index = 2)]
        /* 0x50 */ public List<GcSettlementJudgementPerkOption> Perks;
        [NMS(Index = 4)]
        /* 0x60 */ public List<GcSettlementStatChange> StatChanges;
        // size: 0x3
        public enum JudgementOptionStandingEnum : uint {
            None,
            Positive,
            Negative,
        }
        [NMS(Index = 11)]
        /* 0x70 */ public JudgementOptionStandingEnum JudgementOptionStanding;
        [NMS(Index = 3)]
        /* 0x74 */ public bool HidePerkInJudgement;
        [NMS(Index = 12)]
        /* 0x75 */ public bool OptionIsPositiveForNPC;
        [NMS(Index = 9)]
        /* 0x76 */ public bool UseGiftReward;
        [NMS(Index = 7)]
        /* 0x77 */ public bool UsePolicyPerk;
        [NMS(Index = 8)]
        /* 0x78 */ public bool UsePolicyStat;
        [NMS(Index = 10)]
        /* 0x79 */ public bool UseTechPerk;
    }
}
