using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBD2A0EE79C31BC91, NameHash = 0x8BBB5C31)]
    public class GcNPCSettlementBehaviourAreaPropertyWeightEntry : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcNPCSettlementBehaviourAreaProperty AreaProperty;
        [NMS(Index = 1)]
        /* 0x4 */ public float EntryWeight;
        [NMS(Index = 2)]
        /* 0x8 */ public float ExitWeight;
    }
}
