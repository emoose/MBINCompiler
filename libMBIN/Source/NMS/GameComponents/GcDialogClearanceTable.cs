using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x144FF34C5888AEB9, NameHash = 0x44E2B4C4)]
    public class GcDialogClearanceTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcDialogClearanceInfo> Table;
    }
}
