using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x174B52DE26713C86, NameHash = 0x27F75B1E)]
    public class GcWaterEmissionBiomeData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x20, EnumType = typeof(GcBiomeSubType.BiomeSubTypeEnum))]
        /* 0x0 */ public GcWaterEmissionData[] SubBiomeOverrides;
    }
}
