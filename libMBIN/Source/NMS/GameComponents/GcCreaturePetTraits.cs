namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x158E51018B850276, NameHash = 0xA3FCF80E6002BE62)]
    public class GcCreaturePetTraits : NMSTemplate
    {
        // size: 0x3
        public enum PetTraitEnum : uint {
            Helpfulness,
            Aggression,
            Independence,
        }
        /* 0x0 */ public PetTraitEnum PetTrait;
    }
}
