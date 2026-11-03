using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA3032F5FBAB65ABA, NameHash = 0xC70D273E)]
    public class GcNPCSettlementBehaviourObjectTypeWeightEntry : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcNPCInteractiveObjectType ObjectType;
        [NMS(Index = 1)]
        /* 0x4 */ public float Weight;
    }
}
