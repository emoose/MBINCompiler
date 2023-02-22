using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4F79311F26224F5F, NameHash = 0x932307388A9E5FF3)]
    public class GcTechBoxTable : NMSTemplate
    {
        /* 0x0 */ public List<GcTechBoxData> Table;
    }
}
