using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x444199DB9C294156, NameHash = 0x8F2E6E15D53D1C05)]
    public class GcIDLookupPaths : NMSTemplate
    {
        /* 0x0 */ public List<GcIDLookupPath> Paths;
    }
}
