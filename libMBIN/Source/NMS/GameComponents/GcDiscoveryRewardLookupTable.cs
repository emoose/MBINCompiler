using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9B47247812B4DD38, NameHash = 0x9160051E7F0A1295)]
    public class GcDiscoveryRewardLookupTable : NMSTemplate
    {
        /* 0x0 */ public List<GcDiscoveryRewardLookup> Table;
    }
}
