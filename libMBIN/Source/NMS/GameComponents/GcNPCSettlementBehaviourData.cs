using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCA5615B57503AB, NameHash = 0x87BC5043F293743D)]
    public class GcNPCSettlementBehaviourData : NMSTemplate
    {
        /* 0x00 */ public GcNPCSettlementBehaviourEntry BaseBehaviour;
        [NMS(Size = 0x5, EnumType = typeof(GcNPCSettlementBehaviourState.NPCSettlementBehaviourStateEnum))]
        /* 0x48 */ public GcNPCSettlementBehaviourEntry[] BehaviourOverrides;
    }
}
