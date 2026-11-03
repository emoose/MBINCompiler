namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x630810590E6E167E, NameHash = 0xC4477DCA)]
    public class GcItemQuality : NMSTemplate
    {
        // size: 0x5
        public enum ItemQualityEnum : uint {
            Junk,
            Common,
            Rare,
            Epic,
            Legendary,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ItemQualityEnum ItemQuality;
    }
}
