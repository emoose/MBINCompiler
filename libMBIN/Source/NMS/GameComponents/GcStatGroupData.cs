using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1F78F7E6ABC7B3B2, NameHash = 0xDB9BCAEA43E96FA6)]
    public class GcStatGroupData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 GroupName;
        /* 0x10 */ public List<NMSString0x10> TrackedStats;
    }
}
