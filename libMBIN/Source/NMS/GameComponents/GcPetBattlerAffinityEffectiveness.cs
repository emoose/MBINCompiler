namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBDAD6DCC78D1E65A, NameHash = 0xCD327093)]
    public class GcPetBattlerAffinityEffectiveness : NMSTemplate
    {
        // size: 0x3
        public enum PetBattlerAffinityEffectivenessEnum : uint {
            Ineffective,
            Normal,
            Effective,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public PetBattlerAffinityEffectivenessEnum PetBattlerAffinityEffectiveness;
    }
}
