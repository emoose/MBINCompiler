namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x120EF5D64A95970E, NameHash = 0xA3FCF80E6002BE62)]
    public class GcCreaturePetTraits : NMSTemplate
    {
        // size: 0x3
        public enum PetTraitEnum {
            Helpfulness,
            Aggression,
            Independence
        }
        /* 0x0 */ public PetTraitEnum PetTrait;
    }
}
