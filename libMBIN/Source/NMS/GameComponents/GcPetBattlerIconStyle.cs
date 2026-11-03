namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x92A8F05ADE19BC76, NameHash = 0x4D9D4188)]
    public class GcPetBattlerIconStyle : NMSTemplate
    {
        // size: 0x8
        public enum PetBattlerIconEnum : uint {
            Speed,
            Power,
            Heal,
            Accuracy,
            Stealth,
            Shield,
            Attack,
            Cooldown,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public PetBattlerIconEnum PetBattlerIcon;
    }
}
