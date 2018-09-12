using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0B6E944C82ACF13FF)]
    public class GcJourneyCategoryType : NMSTemplate
    {
		public enum CategoryTypeEnum { Journey, Race, Guild }
		public CategoryTypeEnum CategoryType;
    }
}
