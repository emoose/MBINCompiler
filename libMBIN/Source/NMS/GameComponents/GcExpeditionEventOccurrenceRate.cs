using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3F37C560E275667E, NameHash = 0x217B9012F2F7FC1F)]
    public class GcExpeditionEventOccurrenceRate : NMSTemplate
    {
        // size: 0x5
        public enum ExpeditionCategoryEnum {
            Combat,
            Exploration,
            Mining,
            Diplomacy,
            Balanced
        }
        [NMS(Size = 0x5, EnumType = typeof(ExpeditionCategoryEnum))]
        /* 0x0 */ public GcExpeditionCategoryStrength[] ExpeditionCategory;
    }
}
