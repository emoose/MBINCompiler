namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAF22C9BA93D5EE5A, NameHash = 0xA2B6A3B9)]
    public class GcMessageSummonAndDismiss : NMSTemplate
    {
        // size: 0x2
        public enum SummonEventTypeEnum : uint {
            Summon,
            Dismiss,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SummonEventTypeEnum SummonEventType;
    }
}
