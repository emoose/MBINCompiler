using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x414C922F72D16827, NameHash = 0xDDDC2F57D70378EB)]
    public class GcNPCSettlementBehaviourObjectTypeWeightEntry : NMSTemplate
    {
        /* 0x0 */ public GcNPCInteractiveObjectType ObjectType;
        /* 0x4 */ public float Weight;
    }
}
