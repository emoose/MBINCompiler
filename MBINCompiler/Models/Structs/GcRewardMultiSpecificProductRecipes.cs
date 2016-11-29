using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcRewardMultiSpecificProductRecipes : NMSTemplate
    {
        public List<NMSString0x10> ProductIds;
        [NMS(Size = 0x10)]
        public string DisplayProductId;
        [NMS(Size = 0x10)]
        public string SetName;
    }
}
