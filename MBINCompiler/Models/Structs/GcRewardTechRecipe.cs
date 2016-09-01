namespace MBINCompiler.Models.Structs
{
    public class GcRewardTechRecipe : NMSTemplate
    {
        public GcTechnologyCategory Category;
        [NMS(Size = 0x10)]
        public string RewardGroup;
    }
}
