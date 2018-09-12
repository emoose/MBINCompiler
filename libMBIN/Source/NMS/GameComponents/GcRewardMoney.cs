namespace libMBIN.Models.Structs
{
	[NMS(Size = 0xC, GUID = 0x304763E55680D650)]
    public class GcRewardMoney : NMSTemplate
    {
        public int AmountMin;
        public int AmountMax;
		public enum CurrencyEnum { Units, Nanites, Specials }
		public CurrencyEnum Currency;
    }
}
