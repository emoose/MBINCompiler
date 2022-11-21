using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD5C95E7AD8C6F727, NameHash = 0x4EDC167332F6B824)]
    public class GcSeasonalMilestone : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 Mission;
        /* 0x010 */ public NMSString0x20A Title;
        /* 0x030 */ public NMSString0x20A TitleUpper;
        /* 0x050 */ public NMSString0x20A Description;
        /* 0x070 */ public NMSString0x20A DescriptionDone;
        /* 0x090 */ public NMSString0x20A CantRewardMessage;
        /* 0x0B0 */ public NMSString0x10 IdToUseInMissionData;
        /* 0x0C0 */ public float Amount;
        /* 0x0C4 */ public int StageIndex;
        /* 0x0C8 */ public int MilestoneIndex;
        /* 0x0CC */ public int RendezvousIndex;
        /* 0x0D0 */ public TkTextureResource Icon;
        /* 0x154 */ public TkTextureResource IconGrey;
        /* 0x1D8 */ public TkTextureResource MissionIcon;
        /* 0x25C */ public TkTextureResource MissionIconSelected;
        /* 0x2E0 */ public TkTextureResource MissionIconNotSelected;
        /* 0x368 */ public NMSString0x10 Reward;
        /* 0x378 */ public NMSString0x10 RewardSwitchAlt;
        /* 0x388 */ public NMSString0x200 RewardDescription;
        /* 0x588 */ public NMSString0x200 CantClaimRewardDescription;
        /* 0x788 */ public bool IsOptional;
        /* 0x789 */ public bool IsRendezvous;
        /* 0x78A */ public bool IsStageControl;
        /* 0x790 */ public GcSeasonalMilestoneEncryption Encryption;
    }
}
