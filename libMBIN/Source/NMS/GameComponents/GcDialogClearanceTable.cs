using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x173C648D82FDFF4B, NameHash = 0xA2B1571E48DBF03D)]
    public class GcDialogClearanceTable : NMSTemplate
    {
        /* 0x0 */ public List<GcDialogClearanceInfo> Table;
    }
}
