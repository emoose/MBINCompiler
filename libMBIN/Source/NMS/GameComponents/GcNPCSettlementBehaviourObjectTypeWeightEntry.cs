using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF2FDB6EFC497DD7, NameHash = 0xDDDC2F57D70378EB)]
    public class GcNPCSettlementBehaviourObjectTypeWeightEntry : NMSTemplate
    {
        /* 0x0 */ public GcNPCInteractiveObjectType ObjectType;
        /* 0x4 */ public float Weight;
    }
}
