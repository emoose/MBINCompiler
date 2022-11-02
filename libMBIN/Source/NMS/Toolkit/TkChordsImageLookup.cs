using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xA9D37C063C909AE5, NameHash = 0xD2FF58C5F7940C1F)]
    public class TkChordsImageLookup : NMSTemplate
    {
        /* 0x0 */ public List<TkChordPathMapping> Lookup;
    }
}
