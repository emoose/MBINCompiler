using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x778C8BC46E8653F3, NameHash = 0xA0DADC1850532F54)]
    public class GcCreatureEffectComponentData : NMSTemplate
    {
        /* 0x0 */ public List<GcCreatureEffectTrigger> AnimTriggers;
    }
}
