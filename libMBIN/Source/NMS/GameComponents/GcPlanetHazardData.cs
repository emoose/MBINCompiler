using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD6B06D98F66CE66, NameHash = 0x3DB976BCF84F474B)]
    public class GcPlanetHazardData : NMSTemplate
    {
        [NMS(Size = 0x5, EnumType = typeof(GcHazardValueTypes.HazardValueEnum))]
        /* 0x00 */ public float[] Temperature;
        [NMS(Size = 0x5, EnumType = typeof(GcHazardValueTypes.HazardValueEnum))]
        /* 0x14 */ public float[] Toxicity;
        [NMS(Size = 0x5, EnumType = typeof(GcHazardValueTypes.HazardValueEnum))]
        /* 0x28 */ public float[] Radiation;
        [NMS(Size = 0x5, EnumType = typeof(GcHazardValueTypes.HazardValueEnum))]
        /* 0x3C */ public float[] LifeSupportDrain;
    }
}
