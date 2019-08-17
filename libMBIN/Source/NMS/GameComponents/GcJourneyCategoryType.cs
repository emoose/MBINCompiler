using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xB6E944C82ACF13FF, SubGUID = 0x182075982F91C5F8)]
    public class GcJourneyCategoryType : NMSTemplate
    {
		public enum CategoryTypeEnum { Journey, Race, Guild }
		public CategoryTypeEnum CategoryType;
    }
}
