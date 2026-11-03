using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD274C9556B062790, NameHash = 0x23AEDFAE)]
    public class GcSeasonalRingArray : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcSeasonalRingData> SeasonalRingData;
    }
}
