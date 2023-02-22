namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x301034BCF5288797, NameHash = 0xB3E1998DF67B4EF2)]
    public class GcProductCategory : NMSTemplate
    {
        // size: 0x9
        public enum ProductCategoryEnum {
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
