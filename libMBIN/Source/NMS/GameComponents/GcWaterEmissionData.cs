using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x927E878CA7EA2957, NameHash = 0xF25D8AED)]
    public class GcWaterEmissionData : NMSTemplate
    {
        [NMS(Index = 1, Size = 0x4, EnumType = typeof(GcWaterEmissionBehaviourType.WaterEmissionBehaviourTypeEnum))]
        /* 0x00 */ public float[] FoamEmissionSelectionWeights;
        [NMS(Index = 0, Size = 0x4, EnumType = typeof(GcWaterEmissionBehaviourType.WaterEmissionBehaviourTypeEnum))]
        /* 0x10 */ public float[] WaterEmissionSelectionWeights;
        [NMS(Index = 2)]
        /* 0x20 */ public bool OverrideDefault;
    }
}
