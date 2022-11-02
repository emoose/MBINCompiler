using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x658E6BF56F02B5C0, NameHash = 0x217B9012F2F7FC1F)]
    public class GcExpeditionEventOccurrenceRate : NMSTemplate
    {
        [NMS(Size = 0x5, EnumType = typeof(GcExpeditionCategory.ExpeditionCategoryEnum))]
        /* 0x0 */ public GcExpeditionCategoryStrength[] ExpeditionCategory;
    }
}
