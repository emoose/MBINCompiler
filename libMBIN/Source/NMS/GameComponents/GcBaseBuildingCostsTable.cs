using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE3874E520602845A, NameHash = 0x8069EA15)]
    public class GcBaseBuildingCostsTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcBaseBuildingEntryCosts> ObjectCosts;
    }
}
