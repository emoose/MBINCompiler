namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x21F6CDF71F1F53, NameHash = 0xB6C93D)]
    public class GcPetBattlerTarget : NMSTemplate
    {
        // size: 0x9
        public enum PetBattlerTargetEnum : byte {
            Self,
            TeamBenchMember,
            RandomTeamBenchMember,
            SplitAcrossTeamBench,
            SplitAcrossAllTeam,
            ActiveEnemy,
            RandomEnemyBenchMember,
            SplitAcrossEnemyBench,
            SplitAcrossAllEnemies,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public PetBattlerTargetEnum PetBattlerTarget;
    }
}
