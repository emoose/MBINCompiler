using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6E750EBC0B1892B, NameHash = 0xE07E83B8A167074C)]
    public class GcStatGroupTable : NMSTemplate
    {
        /* 0x0 */ public List<GcStatGroupData> StatGroupTable;
    }
}
