namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x8BC8F6B78C4BDE3B)]
    public class GcRewardStatCompareAndSet : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string CoreStat;
        [NMS(Size = 0x10)]
        public string CompareAndSetStat;
    }
}
