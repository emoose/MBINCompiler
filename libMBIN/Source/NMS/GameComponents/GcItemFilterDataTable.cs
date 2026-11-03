using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x263D9D0F351BECE, NameHash = 0xE77B2AA9)]
    public class GcItemFilterDataTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcItemFilterDataTableEntry> Filters;
    }
}
