using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB4D6C15BF2D9C2BE, NameHash = 0x5F6B19969ECDDFE)]
    public class GcAlienPuzzleTable : NMSTemplate
    {
        /* 0x0 */ public List<GcAlienPuzzleEntry> Table;
    }
}
