namespace MBINCompiler.Models.Structs
{
    [NMS(Size = 0x18)]
    public class GcRewardTechRecipe : NMSTemplate
    {
        public GcTechnologyCategory Category;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding4;
        [NMS(Size = 0x10)]
        public string RewardGroup;
    }
}
