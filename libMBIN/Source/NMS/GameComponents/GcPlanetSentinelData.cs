using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xBE2FC37325C56C05, SubGUID = 0x1EB5C4AE3BDB484E)]
    public class GcPlanetSentinelData : NMSTemplate
    {
		public enum SentinelLevelEnum { Default, Aggressive }
		public SentinelLevelEnum SentinelLevel;

        public int MaxActiveDrones;
    }
}
