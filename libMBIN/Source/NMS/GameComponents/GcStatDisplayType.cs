namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0F373CC74C47A4AF)]
    public class GcStatDisplayType : NMSTemplate
    {
		public enum StatDisplayTypeEnum { None, Sols, Distance }
		public StatDisplayTypeEnum StatDisplayType;
    }
}
