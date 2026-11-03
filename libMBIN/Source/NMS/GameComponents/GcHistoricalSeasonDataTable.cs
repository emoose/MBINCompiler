using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF917FBD15953731A, NameHash = 0xDF99D762)]
    public class GcHistoricalSeasonDataTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcHistoricalSeasonData> Table;
    }
}
