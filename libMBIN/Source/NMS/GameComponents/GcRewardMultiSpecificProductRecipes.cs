using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x66F519D76005DDAF)]
    public class GcRewardMultiSpecificProductRecipes : NMSTemplate
    {
        public List<NMSString0x10> ProductIds;
        [NMS(Size = 0x10)]
        public string DisplayProductId;
        [NMS(Size = 0x20)]
        public string SetName;
    }
}
