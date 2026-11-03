using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x797D2513BE1226DC, NameHash = 0x2FBFB424)]
    public class GcCreatureFilenameTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcCreatureFilename> Table;
    }
}
