namespace MBINCompiler.Models.Structs
{
    public class GcRewardTableCategory : NMSTemplate        // size: 0x48
    {
        [NMS(Size = 0x3, EnumValue = new[] { "Small", "Medium", "Large"})]
        public GcRewardTableItemList[] Sizes;
    }
}
