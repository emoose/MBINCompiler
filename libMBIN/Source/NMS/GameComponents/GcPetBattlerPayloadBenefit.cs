namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF3CA8FA98B4B60B9, NameHash = 0xA04FB523)]
    public class GcPetBattlerPayloadBenefit : NMSTemplate
    {
        // size: 0x2
        public enum PetBattlerPayloadBenefitEnum : uint {
            Positive,
            Negative,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public PetBattlerPayloadBenefitEnum PetBattlerPayloadBenefit;
    }
}
