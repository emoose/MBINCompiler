using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x96A9D0407453E3E5, NameHash = 0x5559683D)]
    public class TkLanguageFontTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkLanguageFontTableEntry> Table;
    }
}
