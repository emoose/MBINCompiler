using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x47317E94270300B5, NameHash = 0x59344CCB9E9B831E)]
    public class GcRewardBeginSettlementBuilding : NMSTemplate
    {
        /* 0x0 */ public List<GcBuildingClassification> ValidBuildings;
    }
}
