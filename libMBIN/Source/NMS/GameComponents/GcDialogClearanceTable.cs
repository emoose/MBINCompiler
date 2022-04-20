using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x10, GUID = 0x173C648D82FDFF4B, NameHash = 0xA2B1571E48DBF03D)]
    public class GcDialogClearanceTable : NMSTemplate
    {
        /* 0x0 */ public List<GcDialogClearanceInfo> Table;
    }
}
