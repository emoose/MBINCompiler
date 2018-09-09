namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0C5B5E7E09FF7A701)]
    public class GcStatType : NMSTemplate // not the same as GcStatsTypes
    {
		public enum StatTypeEnum { Int, Float, AvgRate }
		public StatTypeEnum StatType;
    }
}
