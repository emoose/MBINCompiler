namespace MBINCompiler.Models.Structs
{
    public class GcRewardProductRecipe : NMSTemplate
    {
        public GcRealitySubstanceCategory Category;
        public GcRarity Rarity;
        public bool IgnoreRarity;
        public int ItemLevel;
        public bool AllowComponent;
        public bool AllowDevice;
        public bool AllowConsumable;
        public bool AllowCuriosity;
    }
}
