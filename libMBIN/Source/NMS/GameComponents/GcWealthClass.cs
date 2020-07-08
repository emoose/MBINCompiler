using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0xBEB3844828C75A77, NameHash = 0xC0B928F5E2599F60)]
    public class GcWealthClass : NMSTemplate
    {
		public enum WealthClassEnum { Poor, Average, Wealthy }
		public WealthClassEnum WealthClass;
    }
}