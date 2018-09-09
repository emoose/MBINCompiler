namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x2581475059916919)]
    public class GcExpeditionDuration : NMSTemplate
    {
		public enum ExpeditionDurationEnum { VeryShort, Short, Medium, Long, VeryLong }
		public ExpeditionDurationEnum ExpeditionDuration;
    }
}
