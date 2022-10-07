using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3BC2543792E9B519, NameHash = 0x16AC643981D10CC9)]
    public class GcSmokeBotReport : NMSTemplate
    {
        /* 0x0 */ public ulong StartingUA;
        /* 0x8 */ public List<GcSmokeBotSystemReport> Systems;
    }
}
