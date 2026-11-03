using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x9600A2F78E1D94E9, NameHash = 0x74D183C5)]
    public class TkChordsImageLookup : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkChordPathMapping> Lookup;
    }
}
