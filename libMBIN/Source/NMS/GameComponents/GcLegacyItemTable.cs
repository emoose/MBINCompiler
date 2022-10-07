using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x728CF75D2EB011D5, NameHash = 0xB700CDCA231A2974)]
    public class GcLegacyItemTable : NMSTemplate
    {
        /* 0x0 */ public List<GcLegacyItem> Table;
    }
}
