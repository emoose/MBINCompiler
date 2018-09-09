using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x1F78F7E6ABC7B3B2)]
    public class GcStatGroupData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string GroupName;
        public List<NMSString0x10> TrackedStats;
    }
}
