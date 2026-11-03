namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF442A38B9731B693, NameHash = 0xCE60080B)]
    public class GcPetBattlerStat : NMSTemplate
    {
        // size: 0xF
        public enum PetBattlerStatEnum : uint {
            Health,
            MaxHealth,
            Speed,
            Dodge,
            CritChance,
            HitChance,
            DamageApplied,
            DamageReduction,
            DamageReflection,
            DamageAbsorption,
            CompleteDamageReduction,
            CompleteDamageReflection,
            CompleteDamageAbsorption,
            BonusMoveChance,
            RampDamageCharges,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public PetBattlerStatEnum PetBattlerStat;
    }
}
