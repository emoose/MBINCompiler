namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2EFB913295745728, NameHash = 0x3CB3E3C0)]
    public class GcPetBattlerAffinity : NMSTemplate
    {
        // size: 0x9
        public enum PetBattlerAffinityEnum : byte {
            Normal,
            Lush,
            Cold,
            Fire,
            Toxic,
            Barren,
            Radioactive,
            Weird,
            Mech,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public PetBattlerAffinityEnum PetBattlerAffinity;
    }
}
