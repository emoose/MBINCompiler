using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x40, GUID = 0xC994B6BF65C27A2C)]
    public class GcRewardStatDiff : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string CoreStat;
        [NMS(Size = 0x10)]
        public string CompareAndSetStat;
        [NMS(Size = 0x10)]
        public string SubstanceID;
		public enum RewardCurrencyEnum { None, Units, Nanites, Specials }
		public RewardCurrencyEnum RewardCurrency;
        public int AmountPerStat;
        public int StatRewardCap;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
