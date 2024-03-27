using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x781BDBA6D5335B6A, NameHash = 0xDB9BCAEA43E96FA6)]
    public class GcStatGroupData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 GroupName;
        /* 0x10 */ public List<NMSString0x10> TrackedStats;
    }
}
