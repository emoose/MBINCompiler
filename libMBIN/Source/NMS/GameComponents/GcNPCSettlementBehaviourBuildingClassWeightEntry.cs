using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x107A3DDC0D87C2D3, NameHash = 0xC563E51748C26DEE)]
    public class GcNPCSettlementBehaviourBuildingClassWeightEntry : NMSTemplate
    {
        /* 0x0 */ public GcBuildingClassification BuildingClass;
        /* 0x4 */ public float EntryWeight;
        /* 0x8 */ public float ExitWeight;
    }
}
