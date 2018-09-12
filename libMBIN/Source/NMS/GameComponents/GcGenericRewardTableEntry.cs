namespace libMBIN.Models.Structs
{
	[NMS(Alignment = 0x8, GUID = 0x0EBE52AC97B2A9766)]
    public class GcGenericRewardTableEntry : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        public GcRewardTableItemList Common;
    }
}
