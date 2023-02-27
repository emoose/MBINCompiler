using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3D82E412D71EA3E3, NameHash = 0xD66342935A1B2735)]
    public class GcAISpaceshipWeightingData : NMSTemplate
    {
        [NMS(Size = 0x9, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x0 */ public float[] CivilianClassWeightings;
    }
}
