using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB639C18A3F5F7D80, NameHash = 0x2333DE53)]
    public class GcMissionConditionFreighterBattle : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public int FreighterBattleDistance;
        // size: 0x4
        public enum FreighterBattleStatusEnum : uint {
            None,
            Active,
            Joined,
            Reward,
        }
        [NMS(Index = 0)]
        /* 0x4 */ public FreighterBattleStatusEnum FreighterBattleStatus;
        [NMS(Index = 2)]
        /* 0x8 */ public TkEqualityEnum FreighterBattleTest;
        [NMS(Index = 3, Size = 0x7, EnumType = typeof(GcSpaceBattleType.SpaceBattleTypeEnum))]
        /* 0xC */ public bool[] AllowedSpaceBattleTypes;
    }
}
