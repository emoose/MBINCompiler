using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6A89C6608F2BACF8, NameHash = 0x932307388A9E5FF3)]
    public class GcTechBoxTable : NMSTemplate
    {
        /* 0x0 */ public List<GcTechBoxData> Table;
    }
}
