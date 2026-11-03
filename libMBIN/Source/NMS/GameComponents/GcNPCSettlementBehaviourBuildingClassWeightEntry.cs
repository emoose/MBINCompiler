using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC964ADC1A3FB0753, NameHash = 0xA3D4C382)]
    public class GcNPCSettlementBehaviourBuildingClassWeightEntry : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public float EntryWeight;
        [NMS(Index = 2)]
        /* 0x4 */ public float ExitWeight;
        [NMS(Index = 0)]
        /* 0x8 */ public GcBuildingClassification BuildingClass;
    }
}
