namespace libMBIN.Models.Structs
{
	[NMS(Alignment = 0x8, GUID = 0x461F8EEB2B217E67)]
    public class GcMissionConditionFreighterBattle : NMSTemplate
    {
		public enum FreighterBattleStatusEnum { None, Active, Joined, Reward }
		public FreighterBattleStatusEnum FreighterBattleStatus;
        public int FreighterBattleDistance;
        public TkEqualityEnum FreighterBattleTest;
    }
}
