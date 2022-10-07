using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD2A4169D7657745E, NameHash = 0x27661A8643F25227)]
    public class GcRewardProductRecipe : NMSTemplate
    {
        /* 0x00 */ public GcRealitySubstanceCategory ItemCatagory;
        /* 0x04 */ public GcRarity ItemRarity;
        /* 0x08 */ public bool IgnoreRarity;
        /* 0x0C */ public int ItemLevel;
        // size: 0x9
        public enum AllowedProductTypesEnum {
            Component,
            Consumable,
            Tradeable,
            Curiosity,
            BuildingPart,
            Procedural,
            Emote,
            CustomisationPart,
            CreatureEgg
        }
        [NMS(Size = 0x9, EnumType = typeof(AllowedProductTypesEnum))]
        /* 0x10 */ public bool[] AllowedProductTypes;
    }
}
