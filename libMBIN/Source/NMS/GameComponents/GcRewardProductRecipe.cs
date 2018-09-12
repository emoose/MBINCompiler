namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x18, GUID = 0x0D2A4169D7657745E)]
    public class GcRewardProductRecipe : NMSTemplate
    {
        public GcRealitySubstanceCategory Category;
        public GcRarity Rarity;
        public bool IgnoreRarity;
        public int ItemLevel;
        [NMS(Size = 5, EnumValue = new[] { "Component", "Device", "Consumable", "Curiosity", "BuildingPart" })]
        public bool[] AllowedProductTypes;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] EndPadding;
    }
}
