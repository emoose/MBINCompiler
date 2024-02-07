using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5A0CE15BB94FC262, NameHash = 0x5F6B19969ECDDFE)]
    public class GcAlienPuzzleTable : NMSTemplate
    {
        /* 0x0 */ public List<GcAlienPuzzleEntry> Table;
    }
}
