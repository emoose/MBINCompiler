using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC4EC0F43200D5194, NameHash = 0xEAB35A5B84B3A47C)]
    public class GcBiomeList : NMSTemplate
    {
        [NMS(Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x00 */ public float[] BiomeProbability;
        [NMS(Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x40 */ public float[] PrimeBiomeProbability;
    }
}
