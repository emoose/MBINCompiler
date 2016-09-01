namespace MBINCompiler.Models.Structs
{
    public class GcRewardTableEntry : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        public GcRewardTableCategory Common; // This actually is a GcRewardTableCategory[3], values are GcRarity
        public GcRewardTableCategory Uncommon;
        public GcRewardTableCategory Rare;
    }
}
