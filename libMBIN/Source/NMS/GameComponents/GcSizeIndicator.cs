namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0F4CE658A01F5C02E)]
    public class GcSizeIndicator : NMSTemplate
    {
		public enum SizeIndicatorEnum { Small, Medium, Large }
		public SizeIndicatorEnum SizeIndicator;
    }
}
