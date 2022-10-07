namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2581475059916919, NameHash = 0x406EA68C88F85056)]
    public class GcExpeditionDuration : NMSTemplate
    {
        // size: 0x5
        public enum ExpeditionDurationEnum {
            VeryShort,
            Short,
            Medium,
            Long,
            VeryLong
        }
        /* 0x0 */ public ExpeditionDurationEnum ExpeditionDuration;
    }
}
