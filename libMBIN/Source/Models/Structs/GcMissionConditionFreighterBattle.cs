namespace libMBIN.Models.Structs
{
    [NMS(Alignment = 0x8)]
    public class GcMissionConditionFreighterBattle : NMSTemplate
    {
        public int FreighterBattleStatus;
        public string[] FreighterBattleStatusValues()
        {
            return new[] { "None", "Active", "Joined", "Reward"};
        }
    }
}
