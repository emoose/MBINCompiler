using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4CED9B807DAB2670, NameHash = 0x8CFEB3CA)]
    public class GcHeavyAirList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcFilename> Options;
    }
}
