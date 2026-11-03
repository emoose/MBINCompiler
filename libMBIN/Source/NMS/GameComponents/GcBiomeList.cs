using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE8A0E35491A04717, NameHash = 0xF365586B)]
    public class GcBiomeList : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x11, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x00 */ public float[] BiomeProbability;
        [NMS(Index = 1, Size = 0x11, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x44 */ public float[] PrimeBiomeProbability;
    }
}
