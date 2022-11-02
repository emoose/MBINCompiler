using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC3B924958462F097, NameHash = 0xBA4C53DBACF34B41)]
    public class GcBasePlacementComponentData : NMSTemplate
    {
        /* 0x0 */ public List<GcBasePlacementRule> Rules;
    }
}
