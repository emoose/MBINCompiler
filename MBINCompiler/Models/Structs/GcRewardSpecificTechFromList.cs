using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcRewardSpecificTechFromList : NMSTemplate
    {
        public List<NMSString0x10> TechList;

        public int TechListRewardOrder;
        public string[] TechListRewardOrderValues()
        {
            return new[] { "OneRandom", "InOrder" };
        }

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;
    }
}
