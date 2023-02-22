namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x738498F21709B77B, NameHash = 0x2B740202A0E2CC57)]
    public class GcCreatureHostilityDifficultyOption : NMSTemplate
    {
        // size: 0x3
        public enum CreatureHostilityDifficultyEnum {
            NeverAttack,
            AttackIfProvoked,
            FullEcosystem,
        }
        /* 0x0 */ public CreatureHostilityDifficultyEnum CreatureHostilityDifficulty;
    }
}
