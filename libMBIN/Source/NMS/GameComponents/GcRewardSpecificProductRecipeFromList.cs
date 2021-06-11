using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0x59817101CD4BFD31, NameHash = 0xCD501C8D037C74A5)]
    public class GcRewardSpecificProductRecipeFromList : NMSTemplate
    {
        public List<NMSString0x10> ProductList;

		public enum ProductListRewardOrderEnum { OneRandom, InOrder, TryAllRandom, TryUnknownRandom }
		public ProductListRewardOrderEnum ProductListRewardOrder;
    }
}
