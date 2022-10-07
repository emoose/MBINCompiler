namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD2D75D99686EC7B0, NameHash = 0x4F41C5DCED5937F1)]
    public class GcWordCategoryTableEnum : NMSTemplate
    {
        // size: 0x7
        public enum wordcategorytableEnumEnum {
            MISC,
            DIRECTIONS,
            HELP,
            TRADE,
            LORE,
            TECH,
            THREAT
        }
        /* 0x0 */ public wordcategorytableEnumEnum wordcategorytableEnum;
    }
}
