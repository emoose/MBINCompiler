using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x8446B4D09B82D436, NameHash = 0xD2FF58C5F7940C1F)]
    public class TkChordsImageLookup : NMSTemplate
    {
        /* 0x0 */ public List<TkChordPathMapping> Lookup;
    }
}
