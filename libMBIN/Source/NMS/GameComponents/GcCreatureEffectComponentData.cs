using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3003E745E9B138F7, NameHash = 0x9B56D2D8)]
    public class GcCreatureEffectComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcCreatureEffectTrigger> AnimTriggers;
    }
}
