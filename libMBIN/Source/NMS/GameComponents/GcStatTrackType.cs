namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x1371942C474D2758)]
    public class GcStatTrackType : NMSTemplate
    {
		public enum StatTrackTypeEnum { Set, Add, Max, Min }
		public StatTrackTypeEnum StatTrackType;
    }
}
