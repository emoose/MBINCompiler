using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9E0831FF95371E74, NameHash = 0x6180CAFA8774C28A)]
    public class GcNPCSettlementBehaviourBuildingClassCapacityEntry : NMSTemplate
    {
        /* 0x0 */ public GcBuildingClassification BuildingClass;
        /* 0x4 */ public int Capacity;
    }
}
