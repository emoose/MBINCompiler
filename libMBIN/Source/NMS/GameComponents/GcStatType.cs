namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x67F1FBF60A4F8EC, NameHash = 0xC9590B318F3C4D2)]
    public class GcStatType : NMSTemplate
    {
        // size: 0x3
        public enum StatTypeEnum {
            Int,
            Float,
            AvgRate,
        }
        /* 0x0 */ public StatTypeEnum StatType;
    }
}
