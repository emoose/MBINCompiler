using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x38A06B26A124D29D, NameHash = 0xDE0D8B1D5DF55902)]
    public class GcModularCustomisationDataTable : NMSTemplate
    {
        [NMS(Size = 0x1, EnumType = typeof(GcModularCustomisationResourceType.ModularCustomisationResourceTypeEnum))]
        /* 0x0 */ public GcModularCustomisationConfig[] ModularCustomisationConfigs;
    }
}
