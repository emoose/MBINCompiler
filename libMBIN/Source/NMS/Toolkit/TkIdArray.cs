using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x3C1B325AF872A548, NameHash = 0xC3614740)]
    public class TkIdArray : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<NMSString0x10> Array;
    }
}
