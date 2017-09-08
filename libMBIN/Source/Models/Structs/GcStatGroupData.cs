using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcStatGroupData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string GroupName;
        public List<NMSString0x10> TrackedStats;
    }
}
