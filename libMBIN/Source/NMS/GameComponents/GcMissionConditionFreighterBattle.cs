using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x10B77F9EF998131A, NameHash = 0xF8A296780D76172F)]
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
        /* 0x8 */ public bool HostileFreighter;
        /* 0xC */ public TkEqualityEnum FreighterBattleTest;
    }
}
