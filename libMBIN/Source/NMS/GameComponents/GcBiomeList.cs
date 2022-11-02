namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xADC48418775478FA, NameHash = 0xEAB35A5B84B3A47C)]
    public class GcBiomeList : NMSTemplate
    {
        [NMS(Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x00 */ public float[] BiomeProbability;
        [NMS(Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x40 */ public float[] PrimeBiomeProbability;
    }
}
