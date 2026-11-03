using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9EF92BA83618D3F5, NameHash = 0x94B217E8)]
    public class GcActionSetsHudLayers : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcActionSetHudLayer> ActionSetHudLayers;
    }
}
