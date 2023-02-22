using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD09BAA9EB7148E58, NameHash = 0x2CFD4438CD6B0BDC)]
    public class GcMissionConditionCommunityResearchTier : NMSTemplate
    {
        /* 0x0 */ public float CompletedTiers;
        /* 0x4 */ public float MissionIndex;
        /* 0x8 */ public TkEqualityEnum Test;
        /* 0xC */ public bool TakeTierFromSeasonData;
    }
}
