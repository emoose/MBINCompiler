using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD615CADDBF90C264, NameHash = 0x3706E1A1)]
    public class GcSeasonalMilestoneTeamOverrides : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public TkTextureResource Icon;
        [NMS(Index = 2)]
        /* 0x18 */ public TkTextureResource MissionIcon;
        [NMS(Index = 4)]
        /* 0x30 */ public TkTextureResource MissionIconNotSelected;
        [NMS(Index = 3)]
        /* 0x48 */ public TkTextureResource MissionIconSelected;
        [NMS(Index = 5)]
        /* 0x60 */ public NMSString0x10 Reward;
        [NMS(Index = 0)]
        /* 0x70 */ public GcCommunityTeam TeamID;
    }
}
