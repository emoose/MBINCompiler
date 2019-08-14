using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xD2D75D99686EC7B0)]
    public class GcWordCategoryTableEnum : NMSTemplate
    {
		public enum WordCategoryEnum { MISC, DIRECTIONS, HELP, TRADE, LORE, TECH, THREAT }
		public WordCategoryEnum WordCategory;
    }
}
