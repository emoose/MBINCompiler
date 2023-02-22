using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x94651A96EAD980EB, NameHash = 0xF8A296780D76172F)]
    public class GcMissionConditionFreighterBattle : NMSTemplate
    {
        // size: 0x4
        public enum FreighterBattleStatusEnum {
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
