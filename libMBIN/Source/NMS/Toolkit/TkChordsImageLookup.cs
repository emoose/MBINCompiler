using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x8A6C9B64E7270E1B, NameHash = 0xD2FF58C5F7940C1F)]
    public class TkChordsImageLookup : NMSTemplate
    {
        /* 0x0 */ public List<TkChordPathMapping> Lookup;
    }
}
