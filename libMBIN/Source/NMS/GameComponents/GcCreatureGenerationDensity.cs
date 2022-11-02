namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD8CF3D8506B2B241, NameHash = 0x2CD4E62B393F6930)]
    public class GcCreatureGenerationDensity : NMSTemplate
    {
        // size: 0x4
        public enum DensityEnum {
            Sparse,
            Normal,
            Dense,
            VeryDense
        }
        /* 0x0 */ public DensityEnum Density;
    }
}
