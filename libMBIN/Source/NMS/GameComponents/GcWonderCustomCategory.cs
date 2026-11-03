namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7BF2D417EF544804, NameHash = 0x894AB2E)]
    public class GcWonderCustomCategory : NMSTemplate
    {
        // size: 0xC
        public enum WonderCustomCategoryEnum : uint {
            Custom01,
            Custom02,
            Custom03,
            Custom04,
            Custom05,
            Custom06,
            Custom07,
            Custom08,
            Custom09,
            Custom10,
            Custom11,
            Custom12,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public WonderCustomCategoryEnum WonderCustomCategory;
    }
}
