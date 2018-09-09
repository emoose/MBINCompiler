namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0BE2FC37325C56C05)]
    public class GcPlanetSentinelData : NMSTemplate
    {
		public enum SentinelLevelEnum { Default, Aggressive }
		public SentinelLevelEnum SentinelLevel;

        public int MaxActiveDrones;
    }
}
