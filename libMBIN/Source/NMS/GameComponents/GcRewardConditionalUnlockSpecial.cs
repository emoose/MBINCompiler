namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x79BDA36B25B49650, NameHash = 0xF71AF52C)]
    public class GcRewardConditionalUnlockSpecial : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A Message;
        [NMS(Index = 5)]
        /* 0x20 */ public NMSString0x20A MilestoneRewardOverrideText;
        [NMS(Index = 1)]
        /* 0x40 */ public NMSString0x10 ID;
        // size: 0x1
        public enum UnlockSpecialConditionEnum : uint {
            CommunityTeamWinner,
        }
        [NMS(Index = 0)]
        /* 0x50 */ public UnlockSpecialConditionEnum UnlockSpecialCondition;
        [NMS(Index = 8)]
        /* 0x54 */ public bool FailIfAlreadyKnown;
        [NMS(Index = 6)]
        /* 0x55 */ public bool HideInSeasonRewards;
        [NMS(Index = 3)]
        /* 0x56 */ public bool ShowSpecialProductPopup;
        [NMS(Index = 7)]
        /* 0x57 */ public bool UnlockSeasonReward;
        [NMS(Index = 4)]
        /* 0x58 */ public bool UseSpecialFormatting;
    }
}
