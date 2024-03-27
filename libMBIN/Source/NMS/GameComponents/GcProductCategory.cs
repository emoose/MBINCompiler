namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFD2D86AE268A7F24, NameHash = 0xB3E1998DF67B4EF2)]
    public class GcProductCategory : NMSTemplate
    {
        // size: 0x9
        public enum ProductCategoryEnum : uint {
            Component,
            Consumable,
            Tradeable,
            Curiosity,
            BuildingPart,
            Procedural,
            Emote,
            CustomisationPart,
            CreatureEgg,
        }
        /* 0x0 */ public ProductCategoryEnum ProductCategory;
    }
}
