using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x1C02BEC2FEC36610, NameHash = 0x89917AF9)]
    public class TkID256Array : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<NMSString0x20A> Array;
    }
}
