namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x45D1408457CC38ED, NameHash = 0x36730B94549148DE)]
    public class GcNPCSettlementBehaviourState : NMSTemplate
    {
        // size: 0x5
        public enum NPCSettlementBehaviourStateEnum {
            Generic,
            Sociable,
            Productive,
            Tired,
            Afraid
        }
        /* 0x0 */ public NPCSettlementBehaviourStateEnum NPCSettlementBehaviourState;
    }
}
