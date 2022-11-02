using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6069FE39149FD57F, NameHash = 0x4B1FC18F2123392C)]
    public class GcSeasonalRingArray : NMSTemplate
    {
        /* 0x0 */ public List<GcSeasonalRingData> SeasonalRingData;
    }
}
