using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x5D00249DF1376C41, NameHash = 0xD4D0EA68)]
    public class TkWaterData : NMSTemplate
    {
        [NMS(Index = 1, Size = 0xF, EnumType = typeof(TkWaterCondition.WaterConditionEnum))]
        /* 0x000 */ public TkWaterConditionData[] WaterConditions;
        [NMS(Index = 3, Size = 0x11, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x348 */ public TkBiomeSpecificWaterConditions[] BiomeSpecificUsage;
        [NMS(Index = 2, Size = 0x2, EnumType = typeof(TkWaterRequirement.WaterRequirementEnum))]
        /* 0xB40 */ public TkAllowedWaterConditions[] WaterConditionUsage;
        [NMS(Index = 0)]
        /* 0xBB8 */ public float MinimumWavelength;
    }
}
