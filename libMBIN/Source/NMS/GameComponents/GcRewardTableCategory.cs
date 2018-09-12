namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x4EE34D7B0CD4D953)]
    public class GcRewardTableCategory : NMSTemplate        // size: 0x48
    {
        [NMS(Size = 0x3, EnumValue = new[] { "Small", "Medium", "Large"})]
        public GcRewardTableItemList[] Sizes;
    }
}
