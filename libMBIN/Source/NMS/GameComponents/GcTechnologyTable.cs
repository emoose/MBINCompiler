using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE8595020D25A9F7A, NameHash = 0x7BF27C8F05ED20B7)]
    public class GcTechnologyTable : NMSTemplate
    {
        /* 0x0 */ public List<GcTechnology> Table;
    }
}
