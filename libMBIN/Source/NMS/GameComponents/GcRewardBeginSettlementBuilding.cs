using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x47BA5871ADA970EA, NameHash = 0x5E8D0251)]
    public class GcRewardBeginSettlementBuilding : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcBuildingClassification> ValidBuildings;
        [NMS(Index = 0)]
        /* 0x10 */ public bool IsUpgrade;
    }
}
