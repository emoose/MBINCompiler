namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9AB3E61069401AEC, NameHash = 0xC18D395B)]
    public class GcPetBattlerCoreStat : NMSTemplate
    {
        // size: 0x3
        public enum PetBattlerCoreStatEnum : uint {
            MaxHealth,
            Speed,
            CombatPotential,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public PetBattlerCoreStatEnum PetBattlerCoreStat;
    }
}
