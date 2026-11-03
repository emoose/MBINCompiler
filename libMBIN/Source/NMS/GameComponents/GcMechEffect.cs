using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF81AAAAD058AAF47, NameHash = 0x2A2E592A)]
    public class GcMechEffect : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 DefaultEffect;
        [NMS(Index = 1)]
        /* 0x10 */ public List<GcMechPartEffectOverride> MeshPartOverrides;
    }
}
