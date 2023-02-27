using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB88CD25A12DE1832, NameHash = 0x7AA76AD6E14A0C29)]
    public class GcInventoryLayoutGenerationData : NMSTemplate
    {
        [NMS(Size = 0x25, EnumType = typeof(GcInventoryLayoutSizeType.SizeTypeEnum))]
        /* 0x0 */ public GcInventoryLayoutGenerationDataEntry[] GenerationDataPerSizeType;
    }
}
