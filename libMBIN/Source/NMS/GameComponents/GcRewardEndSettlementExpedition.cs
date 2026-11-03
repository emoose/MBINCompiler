namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x334643C8FAF6A812, NameHash = 0x400D8D3)]
    public class GcRewardEndSettlementExpedition : NMSTemplate
    {
        // size: 0x2
        public enum EndTypeEnum : uint {
            Debrief,
            Shutdown,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public EndTypeEnum EndType;
    }
}
