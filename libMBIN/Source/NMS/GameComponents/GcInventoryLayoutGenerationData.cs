using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x31E0EB2DE415F614, NameHash = 0x5EB6EE4B)]
    public class GcInventoryLayoutGenerationData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x2D, EnumType = typeof(GcInventoryLayoutSizeType.SizeTypeEnum))]
        /* 0x0 */ public GcInventoryLayoutGenerationDataEntry[] GenerationDataPerSizeType;
    }
}
