using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x758, GUID = 0x1B69111BCBFD9AF7, NameHash = 0x4EDC167332F6B824)]
    public class GcSeasonalMilestone : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string Mission;
        [NMS(Size = 0x20)]
        /* 0x010 */ public string Title;
        [NMS(Size = 0x20)]
        /* 0x030 */ public string TitleUpper;
        [NMS(Size = 0x20)]
        /* 0x050 */ public string Description;
        [NMS(Size = 0x20)]
        /* 0x070 */ public string DescriptionDone;
        [NMS(Size = 0x10)]
        /* 0x090 */ public string Id;
        /* 0x0A0 */ public float Amount;
        /* 0x0A4 */ public int StageIndex;
        /* 0x0A8 */ public int MilestoneIndex;
        /* 0x0AC */ public TkTextureResource Icon;
        /* 0x130 */ public TkTextureResource IconGrey;
        /* 0x1B4 */ public TkTextureResource MissionIcon;
        /* 0x238 */ public TkTextureResource MissionIconSelected;
        /* 0x2BC */ public TkTextureResource MissionIconNotSelected;
        [NMS(Size = 0x10)]
        /* 0x340 */ public string Reward;
        /* 0x350 */ public bool IsRendezvous;
        /* 0x351 */ public bool IsStageControl;
        [NMS(Size = 0x200)]
        /* 0x352 */ public string RewardDescription;
        [NMS(Size = 0x200)]
        /* 0x552 */ public string CantClaimRewardDescription;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x752 */ public byte[] EndPadding;
    }
}
