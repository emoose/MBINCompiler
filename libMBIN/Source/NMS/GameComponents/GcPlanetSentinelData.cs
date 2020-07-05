using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x8, GUID = 0xDC6C66FA5075980E, NameHash = 0x1EB5C4AE3BDB484E)]
    public class GcPlanetSentinelData : NMSTemplate
    {
		public enum SentinelLevelEnum { Low, Default, Aggressive }
		public SentinelLevelEnum SentinelLevel;

        public int MaxActiveDrones;
    }
}