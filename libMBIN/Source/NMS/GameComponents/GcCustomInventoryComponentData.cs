using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x51AD00284F2D2C83, NameHash = 0xB16E966B1CE41461)]
    public class GcCustomInventoryComponentData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Size;
        /* 0x10 */ public List<GcInventoryTechProbability> DesiredTechs;
        /* 0x20 */ public bool Cool;
    }
}
