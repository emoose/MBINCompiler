namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x63660285B883E92D)]
    public class TkNoiseOffsetEnum : NMSTemplate
    {
		public enum OffsetTypeEnum { Zero, Base, All, SeaLevel }
		public OffsetTypeEnum OffsetType;
    }
}
