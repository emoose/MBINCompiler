using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0F373CC74C47A4AF)]
    public class GcStatDisplayType : NMSTemplate
    {
		public enum StatDisplayTypeEnum { None, Sols, Distance }
		public StatDisplayTypeEnum StatDisplayType;
    }
}
