using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF7353267DC3C55C8, NameHash = 0x893933F89479A7D8)]
    public class GcRewardProduct : NMSTemplate
    {
        /* 0x00 */ public GcRealitySubstanceCategory ItemCategory;
        /* 0x04 */ public GcRarity ItemRarity;
        /* 0x08 */ public int ItemLevel;
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
        /* 0x0C */ public bool[] AllowedProductTypes;
        /* 0x18 */ public int AmountMin;
        /* 0x1C */ public int AmountMax;
    }
}
