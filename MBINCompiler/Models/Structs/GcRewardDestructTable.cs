namespace MBINCompiler.Models.Structs
{
    public class GcRewardDestructTable : NMSTemplate
    {
        [NMS(Size = 5)]
        public GcRewardDestructRarities[] Categories;
    }
}
