using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5BDF947DEC2421E7, NameHash = 0x2CFD4438CD6B0BDC)]
    public class GcMissionConditionCommunityResearchTier : NMSTemplate
    {
        /* 0x0 */ public int CompletedTiers;
        /* 0x4 */ public int MissionIndex;
        /* 0x8 */ public TkEqualityEnum Test;
        /* 0xC */ public bool TakeTierFromSeasonData;
    }
}
