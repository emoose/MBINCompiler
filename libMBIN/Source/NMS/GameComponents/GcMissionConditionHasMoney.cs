using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x5094992244A9D6F4, SubGUID = 0x58D4887623FE6FF5)]
    public class GcMissionConditionHasMoney : NMSTemplate
    {
        public int Amount;
		public enum TestCurrencyEnum { Units, Nanites, Specials }
		public TestCurrencyEnum TestCurrency;
    }
}
