using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6B988E1DE23BFCD9, NameHash = 0x53E5A2C89515A4E1)]
    public class GcCreatureDataTable : NMSTemplate
    {
        /* 0x0 */ public List<GcCreatureData> Table;
    }
}
