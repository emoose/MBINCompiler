namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC05E3E5570BE569E, NameHash = 0x326A8803E3B79519)]
    public class GcMissionConditionInCombat : NMSTemplate
    {
        // size: 0x7
        public enum CombatTypeEnum {
            GroundCombat,
            SpaceCombat,
            FiendCombat,
            BigFishFiendCombat,
            CorruptedSentinelCombat,
            GroundWormCombat,
            RewardEncounter,
        }
        /* 0x00 */ public CombatTypeEnum CombatType;
        /* 0x08 */ public NMSString0x20A OverrideOSDMessage;
        /* 0x28 */ public bool CheckAllFireteamMembers;
        /* 0x29 */ public bool EncouragesFightingSentinels;
    }
}
