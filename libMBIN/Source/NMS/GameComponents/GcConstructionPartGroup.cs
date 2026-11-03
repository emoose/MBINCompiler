using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x42EF656E9C4264E5, NameHash = 0xDAD16E07)]
    public class GcConstructionPartGroup : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcConstructionPart> ValidParts;
    }
}
