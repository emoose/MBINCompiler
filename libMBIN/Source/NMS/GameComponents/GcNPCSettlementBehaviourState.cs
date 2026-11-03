namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEF0F544797A46962, NameHash = 0xE36FB5A8)]
    public class GcNPCSettlementBehaviourState : NMSTemplate
    {
        // size: 0x5
        public enum NPCSettlementBehaviourStateEnum : uint {
            Generic,
            Sociable,
            Productive,
            Tired,
            Afraid,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public NPCSettlementBehaviourStateEnum NPCSettlementBehaviourState;
    }
}
