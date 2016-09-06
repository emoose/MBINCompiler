namespace MBINCompiler.Models.Structs
{
    public class GcRewardProduct : NMSTemplate
    {
        public GcRealitySubstanceCategory Category;
        public GcRarity Rarity;
        public int ItemLevel;
        [NMS(Size = 4, EnumValue = new[] { "Component", "Device", "Consumable", "Curiosity" })]
        public bool[] AllowedProductTypes;
        public int AmountMin;
        public int AmountMax;
    }
}
