using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x738C1A4C0B58644E, NameHash = 0x53E5A2C89515A4E1)]
    public class GcCreatureDataTable : NMSTemplate
    {
        /* 0x0 */ public List<GcCreatureData> Table;
    }
}
