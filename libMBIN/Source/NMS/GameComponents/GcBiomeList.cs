namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB7C46DCB90948783, NameHash = 0xEAB35A5B84B3A47C)]
    public class GcBiomeList : NMSTemplate
    {
        // size: 0x10
        public enum BiomeProbabilityEnum {
            Lush,
            Toxic,
            Scorched,
            Radioactive,
            Frozen,
            Barren,
            Dead,
            Weird,
            Red,
            Green,
            Blue,
            Test,
            Swamp,
            Lava,
            Waterworld,
            All
        }
        [NMS(Size = 0x10, EnumType = typeof(BiomeProbabilityEnum))]
        /* 0x00 */ public float[] BiomeProbability;
        // size: 0x10
        public enum PrimeBiomeProbabilityEnum {
            Lush,
            Toxic,
            Scorched,
            Radioactive,
            Frozen,
            Barren,
            Dead,
            Weird,
            Red,
            Green,
            Blue,
            Test,
            Swamp,
            Lava,
            Waterworld,
            All
        }
        [NMS(Size = 0x10, EnumType = typeof(PrimeBiomeProbabilityEnum))]
        /* 0x40 */ public float[] PrimeBiomeProbability;
    }
}
