namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x84B6B607BF7F3134, NameHash = 0xC89268EC)]
    public class GcStatType : NMSTemplate
    {
        // size: 0x3
        public enum StatTypeEnum : uint {
            Int,
            Float,
            AvgRate,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public StatTypeEnum StatType;
    }
}
