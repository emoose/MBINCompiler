using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xA27983F991070A43, NameHash = 0x2969CA92E6538A9A)]
    public class TkLocalisationTable : NMSTemplate
    {
        /* 0x0 */ public List<TkLocalisationEntry> Table;
    }
}
