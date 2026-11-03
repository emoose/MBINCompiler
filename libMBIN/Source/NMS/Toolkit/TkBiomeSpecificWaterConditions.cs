using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xD06FD62311DFC0E1, NameHash = 0x69E02AAE)]
    public class TkBiomeSpecificWaterConditions : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x2, EnumType = typeof(TkWaterRequirement.WaterRequirementEnum))]
        /* 0x0 */ public TkAllowedWaterConditions[] WaterConditionUsage;
    }
}
