using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x8, GUID = 0x281F7CD00AE9BE55, NameHash = 0x512506C3685B14E6)]
    public class GcCostMoney : NMSTemplate
    {
        public int Cost;
		public GcCurrency CostCurrency;
    }
}