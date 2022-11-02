namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3B856B5623F39B30, NameHash = 0x182075982F91C5F8)]
    public class GcJourneyCategoryType : NMSTemplate
    {
        // size: 0x3
        public enum CategoryTypeEnum {
            Journey,
            Race,
            Guild
        }
        /* 0x0 */ public CategoryTypeEnum CategoryType;
    }
}
