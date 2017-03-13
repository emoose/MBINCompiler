using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcRewardSpecificProductRecipeFromList : NMSTemplate
    {
        public List<NMSString0x10> ProductList;

        public int ProductListRewardOrder;
        public string[] ProductListRewardOrderValues()
        {
            return new[] { "OneRandom", "InOrder" };
        }

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;
    }
}
