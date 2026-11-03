using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x167BE99EB7B1437E, NameHash = 0x34800A5C)]
    public class GcPlanetHazardData : NMSTemplate
    {
        [NMS(Index = 3, Size = 0x6, EnumType = typeof(GcHazardValueTypes.HazardValueEnum))]
        /* 0x00 */ public float[] LifeSupportDrain;
        [NMS(Index = 2, Size = 0x6, EnumType = typeof(GcHazardValueTypes.HazardValueEnum))]
        /* 0x18 */ public float[] Radiation;
        [NMS(Index = 4, Size = 0x6, EnumType = typeof(GcHazardValueTypes.HazardValueEnum))]
        /* 0x30 */ public float[] SpookLevel;
        [NMS(Index = 0, Size = 0x6, EnumType = typeof(GcHazardValueTypes.HazardValueEnum))]
        /* 0x48 */ public float[] Temperature;
        [NMS(Index = 1, Size = 0x6, EnumType = typeof(GcHazardValueTypes.HazardValueEnum))]
        /* 0x60 */ public float[] Toxicity;
    }
}
