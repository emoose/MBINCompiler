using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x99D1CBD8CE771A8, NameHash = 0xA0DA78BA)]
    public class GcShipAIPerformanceArray : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<NMSTemplate> Array;
    }
}
