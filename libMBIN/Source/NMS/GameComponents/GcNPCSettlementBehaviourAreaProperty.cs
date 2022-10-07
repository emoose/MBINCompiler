namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x649C31A6D0A2D1DA, NameHash = 0x402D87044A8D02D3)]
    public class GcNPCSettlementBehaviourAreaProperty : NMSTemplate
    {
        // size: 0x2
        public enum NPCSettlementBehaviourAreaPropertyEnum {
            ContainsPlayer,
            ContainsNPCs
        }
        /* 0x0 */ public NPCSettlementBehaviourAreaPropertyEnum NPCSettlementBehaviourAreaProperty;
    }
}
