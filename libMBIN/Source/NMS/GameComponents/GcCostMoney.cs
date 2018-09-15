using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xCFD91697CCC3D372)]
    public class GcCostMoney : NMSTemplate
    {
        public int Cost;
		public enum CostCurrencyEnum { Units, Nanites, Specials }
		public CostCurrencyEnum CostCurrency;
    }
}
