namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF7B7D7C78B6104B8, NameHash = 0x402D87044A8D02D3)]
    public class GcNPCSettlementBehaviourAreaProperty : NMSTemplate
    {
        // size: 0x2
        public enum NPCSettlementBehaviourAreaPropertyEnum {
            ContainsPlayer,
            ContainsNPCs,
        }
        /* 0x0 */ public NPCSettlementBehaviourAreaPropertyEnum NPCSettlementBehaviourAreaProperty;
    }
}
