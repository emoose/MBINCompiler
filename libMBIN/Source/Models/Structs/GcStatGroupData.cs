using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcStatGroupData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string GroupName;
        public List<NMSString0x10> TrackedStats;
    }
}
