using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xAD1718785B26B78F)]
    public class GcRewardSpecificTechFromList : NMSTemplate
    {
        public List<NMSString0x10> TechList;

		public enum TechListRewardOrderEnum { OneRandom, InOrder, TryAllRandom }
		public TechListRewardOrderEnum TechListRewardOrder;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;
    }
}
