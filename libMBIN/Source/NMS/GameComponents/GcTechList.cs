using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x98EAA064EDE908, NameHash = 0xF29047E5)]
    public class GcTechList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<NMSString0x10> AvailableTech;
    }
}
