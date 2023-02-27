using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC59E1A4E7BC0F022, NameHash = 0xE47353C2B9EE4F60)]
    public class GcMissionConditionHasSettlementBuilding : NMSTemplate
    {
        /* 0x0 */ public GcBuildingClassification BuildingClass;
        /* 0x4 */ public bool RequireComplete;
    }
}
