using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x10, GUID = 0xD345A806D5C682B0, NameHash = 0x05F6B19969ECDDFE)]
    public class GcAlienPuzzleTable : NMSTemplate
    {
        /* 0x0 */ public List<GcAlienPuzzleEntry> Table;
    }
}
