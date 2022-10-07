using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x9808CBC171682435, NameHash = 0xD2657A8AE39E6E61)]
    public class TkProceduralModelList : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public List<NMSString0x80> List;
    }
}
