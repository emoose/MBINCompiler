using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x515DE95090B4C0D7, NameHash = 0x6AE734CB)]
    public class GcCreatureHoverMovementData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcCreatureHoverMovementDataParams> Params;
    }
}
