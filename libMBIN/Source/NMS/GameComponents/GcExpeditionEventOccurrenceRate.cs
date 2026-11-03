using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x94B6ED344438FAE6, NameHash = 0x7B6C44AE)]
    public class GcExpeditionEventOccurrenceRate : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x5, EnumType = typeof(GcExpeditionCategory.ExpeditionCategoryEnum), MxmlName = "Expedition Category")]
        /* 0x0 */ public GcExpeditionCategoryStrength[] ExpeditionCategory;
    }
}
