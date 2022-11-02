namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE7F7716BC88E8273, NameHash = 0x6474461C1BF89153)]
    public class GcCreatureRoleFilename : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 File;
        [NMS(Size = 0x4, EnumType = typeof(GcPlanetLife.LifeSettingEnum))]
        /* 0x80 */ public float[] BiomeProbability;
    }
}
