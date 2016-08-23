namespace MBINCompiler.Models.Structs
{
    public class GcRewardDestructTable : NMSTemplate
    {
        [NMSAttribute(Size = 5)]
        public GcRewardDestructRarities[] Categories;
    }
}
