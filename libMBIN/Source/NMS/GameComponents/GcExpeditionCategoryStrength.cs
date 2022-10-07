namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3DD882A3DE1B6FA7, NameHash = 0xA66A9F625C0BD43C)]
    public class GcExpeditionCategoryStrength : NMSTemplate
    {
        // size: 0x5
        public enum OccurranceChanceEnum {
            Combat,
            Exploration,
            Mining,
            Diplomacy,
            Balanced
        }
        [NMS(Size = 0x5, EnumType = typeof(OccurranceChanceEnum))]
        /* 0x0 */ public int[] OccurranceChance;
    }
}
