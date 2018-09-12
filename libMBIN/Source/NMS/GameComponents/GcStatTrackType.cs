using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x1371942C474D2758)]
    public class GcStatTrackType : NMSTemplate
    {
		public enum StatTrackTypeEnum { Set, Add, Max, Min }
		public StatTrackTypeEnum StatTrackType;
    }
}
