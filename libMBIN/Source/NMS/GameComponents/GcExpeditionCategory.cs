namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC67C697DA64DEE8A, NameHash = 0x4843066B)]
    public class GcExpeditionCategory : NMSTemplate
    {
        // size: 0x5
        public enum ExpeditionCategoryEnum : uint {
            Combat,
            Exploration,
            Mining,
            Diplomacy,
            Balanced,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ExpeditionCategoryEnum ExpeditionCategory;
    }
}
