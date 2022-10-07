using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBDA739C3E176E027, NameHash = 0xEE25A96466342A98)]
    public class GcBaseBuildingCostsTable : NMSTemplate
    {
        /* 0x0 */ public List<GcBaseBuildingEntryCosts> ObjectCosts;
    }
}
