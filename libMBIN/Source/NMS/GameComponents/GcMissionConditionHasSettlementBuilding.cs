using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x8, GUID = 0x3E77F6502C61A1BD, NameHash = 0xE47353C2B9EE4F60)]
    public class GcMissionConditionHasSettlementBuilding : NMSTemplate
    {
        /* 0x0 */ public GcBuildingClassification BuildingClass;
        /* 0x4 */ public bool RequireComplete;
    }
}
