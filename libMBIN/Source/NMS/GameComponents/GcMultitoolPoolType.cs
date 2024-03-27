namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x67E7745DA24F94EF, NameHash = 0x9CEEDED8BE6E524C)]
    public class GcMultitoolPoolType : NMSTemplate
    {
        // size: 0x4
        public enum MultiToolPoolTypeEnum : uint {
            Standard,
            Exotic,
            Sentinel,
            Atlas,
        }
        /* 0x0 */ public MultiToolPoolTypeEnum MultiToolPoolType;
    }
}
