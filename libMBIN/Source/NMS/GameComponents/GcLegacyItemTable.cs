using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x52929D5CA2AAAB23, NameHash = 0xB58F6BA8)]
    public class GcLegacyItemTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcLegacyItem> Table;
    }
}
