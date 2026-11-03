namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x71C6DA907D5C058D, NameHash = 0x8F97919)]
    public class GcPetBattlerHitQuality : NMSTemplate
    {
        // size: 0x3
        public enum PetBattlerHitQualityEnum : uint {
            Miss,
            Dodge,
            Hit,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public PetBattlerHitQualityEnum PetBattlerHitQuality;
    }
}
