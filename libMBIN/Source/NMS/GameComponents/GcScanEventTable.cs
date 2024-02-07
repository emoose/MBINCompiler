using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD258E1E4FF5CDABA, NameHash = 0xD550A58E83EA253)]
    public class GcScanEventTable : NMSTemplate
    {
        /* 0x0 */ public List<GcScanEventData> Events;
    }
}
