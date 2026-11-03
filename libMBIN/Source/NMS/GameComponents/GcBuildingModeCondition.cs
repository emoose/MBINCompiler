using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x66D5CEBC0BBE2BD1, NameHash = 0x589EEBBD)]
    public class GcBuildingModeCondition : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x5, EnumType = typeof(GcBaseBuildingMode.BaseBuildingModeEnum))]
        /* 0x0 */ public int[] ValidBuildingModes;
    }
}
