using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8E63F0F044DC2CE9, NameHash = 0xBA4C53DBACF34B41)]
    public class GcBasePlacementComponentData : NMSTemplate
    {
        /* 0x0 */ public List<GcBasePlacementRule> Rules;
    }
}
