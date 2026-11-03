using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4426A16BA4970EB1, NameHash = 0x313C379D)]
    public class GcPetBattlerPayloadAffinity : NMSTemplate
    {
        // size: 0x3
        public enum PetPayloadAffinityEnum : uint {
            UsePetAffinity,
            UseSpecificAffinity,
            UsePetStrongAffinity,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public PetPayloadAffinityEnum PetPayloadAffinity;
        [NMS(Index = 1)]
        /* 0x4 */ public GcPetBattlerAffinity SpecificAffinity;
    }
}
