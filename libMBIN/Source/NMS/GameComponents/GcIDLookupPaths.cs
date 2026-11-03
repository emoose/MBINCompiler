using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9C0B237A2FCCA970, NameHash = 0xF0BB5F78)]
    public class GcIDLookupPaths : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcIDLookupPath> Paths;
    }
}
