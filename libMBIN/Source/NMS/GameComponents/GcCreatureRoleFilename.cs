using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDFFFE698FE3EDA49, NameHash = 0xDCEA4C2E)]
    public class GcCreatureRoleFilename : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public GcFilename File;
        [NMS(Index = 1, Size = 0x4, EnumType = typeof(GcPlanetLife.LifeSettingEnum))]
        /* 0x10 */ public float[] BiomeProbability;
    }
}
