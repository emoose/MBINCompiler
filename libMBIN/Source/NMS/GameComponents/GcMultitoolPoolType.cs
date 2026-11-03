namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB096D3CAEB0EDA19, NameHash = 0x7A5AE09C)]
    public class GcMultitoolPoolType : NMSTemplate
    {
        // size: 0x5
        public enum MultiToolPoolTypeEnum : uint {
            Standard,
            Exotic,
            Sentinel,
            Atlas,
            SettlementRotational,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public MultiToolPoolTypeEnum MultiToolPoolType;
    }
}
