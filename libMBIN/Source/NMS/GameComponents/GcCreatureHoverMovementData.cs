using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF117BB94CE07869F, NameHash = 0xFA76C7A4963051DC)]
    public class GcCreatureHoverMovementData : NMSTemplate
    {
        /* 0x0 */ public List<GcCreatureHoverMovementDataParams> Params;
    }
}
