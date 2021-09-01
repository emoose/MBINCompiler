using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x10, GUID = 0x5E9F006378481CF2, NameHash = 0x59344CCB9E9B831E)]
    public class GcRewardBeginSettlementBuilding : NMSTemplate
    {
        public List<GcBuildingClassification> ValidBuildings;
    }
}
