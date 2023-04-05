using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x20486F2DF9900EE4, NameHash = 0xE47353C2B9EE4F60)]
    public class GcMissionConditionHasSettlementBuilding : NMSTemplate
    {
        /* 0x0 */ public GcBuildingClassification BuildingClass;
        /* 0x4 */ public bool RequireComplete;
    }
}
