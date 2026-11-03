using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB3F3500E34C884D1, NameHash = 0x3CC4F74)]
    public class GcMissionConditionFlagshipBattleState : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x0 */ public int AlliesBelowHealthPercentage;
        // size: 0x2
        public enum BattleStateEnum : uint {
            AlliesDead,
            AlliesBelowHealthPercentage,
        }
        [NMS(Index = 0)]
        /* 0x4 */ public BattleStateEnum BattleState;
        [NMS(Index = 1)]
        /* 0x8 */ public GcSpaceBattleType RequireSpecificSpaceBattleType;
    }
}
