using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC94AA7C4935ABD50, NameHash = 0xEE25A96466342A98)]
    public class GcBaseBuildingCostsTable : NMSTemplate
    {
        /* 0x0 */ public List<GcBaseBuildingEntryCosts> ObjectCosts;
    }
}
