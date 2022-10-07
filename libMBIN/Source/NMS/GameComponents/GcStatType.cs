namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC5B5E7E09FF7A701, NameHash = 0xC9590B318F3C4D2)]
    public class GcStatType : NMSTemplate
    {
        // size: 0x3
        public enum StatTypeEnum {
            Int,
            Float,
            AvgRate
        }
        /* 0x0 */ public StatTypeEnum StatType;
    }
}
