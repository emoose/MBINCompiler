using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0x9B47247812B4DD38)]
    public class GcDiscoveryRewardLookupTable : NMSTemplate
    {
        public List<GcDiscoveryRewardLookup> Table;
    }
}
