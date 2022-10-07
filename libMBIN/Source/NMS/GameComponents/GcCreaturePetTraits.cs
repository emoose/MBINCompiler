namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3DFE945C46B0DBFD, NameHash = 0xA3FCF80E6002BE62)]
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
