namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF302A03E3ADB86B1, NameHash = 0x7E6B18F25C0843D4)]
    public class GcStatDisplayType : NMSTemplate
    {
        // size: 0x3
        public enum StatDisplayTypeEnum {
            None,
            Sols,
            Distance,
        }
        /* 0x0 */ public StatDisplayTypeEnum StatDisplayType;
    }
}
