using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF35B1B9B783820A2, NameHash = 0xDB27C170)]
    public class GcCostCommunityResearchTier : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public int CompletedTiers;
        [NMS(Index = 1)]
        /* 0x4 */ public int MissionIndex;
        [NMS(Index = 2)]
        /* 0x8 */ public TkEqualityEnum Test;
    }
}
