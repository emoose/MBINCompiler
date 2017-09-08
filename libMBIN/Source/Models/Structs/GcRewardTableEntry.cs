namespace MBINCompiler.Models.Structs
{
    public class GcRewardTableEntry : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        [NMS(Size = 0x3, EnumValue = new[] { "Common", "Uncommon", "Rare" })]
        public GcRewardTableCategory[] Rarities;
    }
}
