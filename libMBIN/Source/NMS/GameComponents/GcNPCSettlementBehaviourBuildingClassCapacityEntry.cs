using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBE7B450CC46CA134, NameHash = 0x6180CAFA8774C28A)]
    public class GcNPCSettlementBehaviourBuildingClassCapacityEntry : NMSTemplate
    {
        /* 0x0 */ public GcBuildingClassification BuildingClass;
        /* 0x4 */ public int Capacity;
    }
}
