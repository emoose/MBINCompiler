using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xDC6C66FA5075980E, SubGUID = 0x1EB5C4AE3BDB484E)]
    public class GcPlanetSentinelData : NMSTemplate
    {
		public enum SentinelLevelEnum { Low, Default, Aggressive }
		public SentinelLevelEnum SentinelLevel;

        public int MaxActiveDrones;
    }
}
