using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x64BEA061A645390)]
    public class GcRewardSpecificProductRecipeFromList : NMSTemplate
    {
        public List<NMSString0x10> ProductList;

		public enum ProductListRewardOrderEnum { OneRandom, InOrder, TryAllRandom }
		public ProductListRewardOrderEnum ProductListRewardOrder;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;
    }
}
