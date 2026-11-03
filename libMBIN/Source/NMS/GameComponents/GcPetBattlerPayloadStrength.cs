namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x242599D8727D33A9, NameHash = 0xC35B3BF5)]
    public class GcPetBattlerPayloadStrength : NMSTemplate
    {
        // size: 0x5
        public enum PetPayloadStrengthEnum : uint {
            VeryLight,
            Light,
            Medium,
            Heavy,
            VeryHeavy,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public PetPayloadStrengthEnum PetPayloadStrength;
    }
}
