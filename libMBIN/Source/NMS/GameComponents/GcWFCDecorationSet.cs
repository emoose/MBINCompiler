using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE972E551D6A86BB5, NameHash = 0xDC8CEC5A)]
    public class GcWFCDecorationSet : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcWFCDecorationItem> Items;
    }
}
