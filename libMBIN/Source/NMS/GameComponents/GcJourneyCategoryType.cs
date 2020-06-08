using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x1BE53BCA8CB92910, NameHash = 0x182075982F91C5F8)]
    public class GcJourneyCategoryType : NMSTemplate
    {
		public enum CategoryTypeEnum { Journey, Race, Guild, Seasonal }
		public CategoryTypeEnum CategoryType;
    }
}
