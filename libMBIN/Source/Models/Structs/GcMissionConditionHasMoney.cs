namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x5094992244A9D6F4)]
    public class GcMissionConditionHasMoney : NMSTemplate
    {
        public int Amount;
		public enum TestCurrencyEnum { Units, Nanites, Specials }
		public TestCurrencyEnum TestCurrency;
    }
}
