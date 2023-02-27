namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9117FB771CCEB0C5, NameHash = 0x182075982F91C5F8)]
    public class GcJourneyCategoryType : NMSTemplate
    {
        // size: 0x3
        public enum CategoryTypeEnum : uint {
            Journey,
            Race,
            Guild,
        }
        /* 0x0 */ public CategoryTypeEnum CategoryType;
    }
}
