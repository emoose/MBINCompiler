using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x54CB63EE6FC97142, NameHash = 0x932307388A9E5FF3)]
    public class GcTechBoxTable : NMSTemplate
    {
        /* 0x0 */ public List<GcTechBoxData> Table;
    }
}
