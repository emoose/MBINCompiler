namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF172C1FA6F2F4771, NameHash = 0x6474461C1BF89153)]
    public class GcCreatureRoleFilename : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 File;
        // size: 0x4
        public enum BiomeProbabilityEnum {
            Dead,
            Low,
            Mid,
            Full
        }
        [NMS(Size = 0x4, EnumType = typeof(BiomeProbabilityEnum))]
        /* 0x80 */ public float[] BiomeProbability;
    }
}
