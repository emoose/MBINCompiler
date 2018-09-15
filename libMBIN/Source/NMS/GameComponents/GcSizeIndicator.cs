using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xF4CE658A01F5C02E)]
    public class GcSizeIndicator : NMSTemplate
    {
		public enum SizeIndicatorEnum { Small, Medium, Large }
		public SizeIndicatorEnum SizeIndicator;
    }
}
