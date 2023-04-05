using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9F3428E20A0D40DF, NameHash = 0x87BC5043F293743D)]
    public class GcNPCSettlementBehaviourData : NMSTemplate
    {
        /* 0x00 */ public GcNPCSettlementBehaviourEntry BaseBehaviour;
        [NMS(Size = 0x5, EnumType = typeof(GcNPCSettlementBehaviourState.NPCSettlementBehaviourStateEnum))]
        /* 0x48 */ public GcNPCSettlementBehaviourEntry[] BehaviourOverrides;
    }
}
