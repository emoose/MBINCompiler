namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5CBB282C779E15E5, NameHash = 0x28B527B8)]
    public class GcExpeditionDuration : NMSTemplate
    {
        // size: 0x5
        public enum ExpeditionDurationEnum : uint {
            VeryShort,
            Short,
            Medium,
            Long,
            VeryLong,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ExpeditionDurationEnum ExpeditionDuration;
    }
}
