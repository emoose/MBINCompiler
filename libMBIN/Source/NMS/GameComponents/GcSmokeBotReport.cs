using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x79B1C8F92E065DCC, NameHash = 0x16AC643981D10CC9)]
    public class GcSmokeBotReport : NMSTemplate
    {
        /* 0x0 */ public ulong StartingUA;
        /* 0x8 */ public List<GcSmokeBotSystemReport> Systems;
    }
}
