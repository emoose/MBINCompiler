using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0xD2A4169D7657745E)]
    public class GcRewardProductRecipe : NMSTemplate
    {
        public GcRealitySubstanceCategory Category;
        public GcRarity Rarity;
        public bool IgnoreRarity;
        public int ItemLevel;
        // enum struct: GcProductCategory
        [NMS(Size = 8, EnumValue = new[] { "Component", "Device", "Consumable", "Curiosity", "BuildingPart", "Procedural", "Emote", "CustomisationPart" })]
        public bool[] AllowedProductTypes;
    }
}
