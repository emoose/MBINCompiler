using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDCC56388C8B1E68, NameHash = 0x3203CA31)]
    public class GcBasePlacementComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcBasePlacementRule> Rules;
    }
}
