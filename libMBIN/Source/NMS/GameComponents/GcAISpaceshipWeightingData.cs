using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x57A798B0145121C7, NameHash = 0xBDB2EAAD)]
    public class GcAISpaceshipWeightingData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0xC, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x0 */ public float[] CivilianClassWeightings;
    }
}
