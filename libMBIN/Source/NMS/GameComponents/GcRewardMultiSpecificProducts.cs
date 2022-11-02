using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFD858417E0D4B98F, NameHash = 0xC87C94C721C64FAA)]
    public class GcRewardMultiSpecificProducts : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A SetName;
        /* 0x20 */ public List<NMSString0x10> ProductIds;
    }
}
