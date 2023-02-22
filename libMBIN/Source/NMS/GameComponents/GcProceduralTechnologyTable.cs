using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9DD6B23E1F527835, NameHash = 0x80ED6EE04AC8D620)]
    public class GcProceduralTechnologyTable : NMSTemplate
    {
        /* 0x0 */ public List<GcProceduralTechnologyData> Table;
    }
}
