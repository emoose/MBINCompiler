using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCB7F989D6DA449DA, NameHash = 0xF8A296780D76172F)]
    public class GcMissionConditionFreighterBattle : NMSTemplate
    {
        // size: 0x4
        public enum FreighterBattleStatusEnum : uint {
            None,
            Active,
            Joined,
            Reward,
        }
        /* 0x0 */ public FreighterBattleStatusEnum FreighterBattleStatus;
        /* 0x4 */ public int FreighterBattleDistance;
        /* 0x8 */ public TkEqualityEnum FreighterBattleTest;
    }
}
