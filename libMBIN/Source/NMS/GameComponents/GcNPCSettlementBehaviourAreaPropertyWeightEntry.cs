using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4D4DE7B110B454A6, NameHash = 0x9438A8C0CC009F4)]
    public class GcNPCSettlementBehaviourAreaPropertyWeightEntry : NMSTemplate
    {
        /* 0x0 */ public GcNPCSettlementBehaviourAreaProperty AreaProperty;
        /* 0x4 */ public float EntryWeight;
        /* 0x8 */ public float ExitWeight;
    }
}
