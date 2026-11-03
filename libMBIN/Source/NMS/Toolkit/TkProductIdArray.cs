using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x2C5DB80919098CA3, NameHash = 0x2DF76AC4)]
    public class TkProductIdArray : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<NMSString0x10> Array;
    }
}
