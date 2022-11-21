using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x35DB28B502CC33BB, NameHash = 0x307D1ADF8E3AA83B)]
    public class GcBuildingModeCondition : NMSTemplate
    {
        [NMS(Size = 0x5, EnumType = typeof(GcBaseBuildingMode.BaseBuildingModeEnum))]
        /* 0x0 */ public int[] ValidBuildingModes;
    }
}
