using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x108, GUID = 0x9AA5966B8AD10C45)]
    public class GcMissionSequenceCollectMoney : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Message;
        public int Amount;
		public enum CollectCurrencyEnum { Units, Nanites, Specials }
		public CollectCurrencyEnum CollectCurrency;
        [NMS(Size = 0x80)]
        public string DebugText;
    }
}
