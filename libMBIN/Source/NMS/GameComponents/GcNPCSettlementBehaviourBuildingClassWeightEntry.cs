using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE33C52E30AF838F6, NameHash = 0xC563E51748C26DEE)]
    public class GcNPCSettlementBehaviourBuildingClassWeightEntry : NMSTemplate
    {
        /* 0x0 */ public GcBuildingClassification BuildingClass;
        /* 0x4 */ public float EntryWeight;
        /* 0x8 */ public float ExitWeight;
    }
}
