using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFFA65D6CD42D0731, NameHash = 0x5F5BF3F7E2ECA606)]
    public class GcCreatureFilenameTable : NMSTemplate
    {
        /* 0x0 */ public List<GcCreatureFilename> Table;
    }
}
