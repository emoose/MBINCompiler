using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD1753D1139865EC5, NameHash = 0x7BF27C8F05ED20B7)]
    public class GcTechnologyTable : NMSTemplate
    {
        /* 0x0 */ public List<GcTechnology> Table;
    }
}
