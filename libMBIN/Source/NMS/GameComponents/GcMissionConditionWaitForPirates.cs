using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x358310F2D3B8F7E8, NameHash = 0x978040CE6A2C247B)]
    public class GcMissionConditionWaitForPirates : NMSTemplate
    {
        /* 0x0 */ public int LivingPirates;
        /* 0x4 */ public bool CountHostileTraders;
        /* 0x5 */ public bool CompleteOnlyInSpace;
        /* 0x6 */ public bool CareAboutAttackingPlayer;
        /* 0x7 */ public bool CheckAllFireteamMembers;
        /* 0x8 */ public TkEqualityEnum Test;
    }
}
