namespace MBINCompiler.Models.Structs
{
    public class GcRewardProductRecipe : NMSTemplate
    {
        public GcRealitySubstanceCategory Category;
        public GcRarity Rarity;
        public bool IgnoreRarity;
        public int ItemLevel;
        [NMS(Size = 4, EnumValue = new[] { "Component", "Device", "Consumable", "Curiosity" })]
        public bool[] AllowedProductTypes;
    }
}
