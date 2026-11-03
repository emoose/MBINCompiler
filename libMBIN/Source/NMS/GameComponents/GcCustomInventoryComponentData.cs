using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCC2E1AF4404DF73D, NameHash = 0x179DEDE7)]
    public class GcCustomInventoryComponentData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcInventoryTechProbability> DesiredTechs;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 Size;
        [NMS(Index = 2)]
        /* 0x20 */ public bool Cool;
    }
}
