namespace MBINCompiler.Models.Structs
{
    public class GcMissionConditionFreighterBattle : NMSTemplate
    {
        public int FreighterBattleStatus;
        public string[] FreighterBattleStatusValues()
        {
            return new[] { "None", "Active", "Joined", "Reward"};
        }
    }
}
