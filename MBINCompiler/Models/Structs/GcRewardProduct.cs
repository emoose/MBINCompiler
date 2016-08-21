namespace MBINCompiler.Models.Structs
{
    public class GcRewardProduct : NMSTemplate
    {
        public GcRealitySubstanceCategory Category;
        public GcRarity Rarity;
        public int ItemLevel;
        public bool AllowComponent;
        public bool AllowDevice;
        public bool AllowConsumable;
        public bool AllowCuriosity;
        public int AmountMin;
        public int AmountMax;
    }
}
