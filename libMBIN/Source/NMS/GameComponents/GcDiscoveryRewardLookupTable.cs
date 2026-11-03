using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFAE123E83C9444EC, NameHash = 0x60597D1F)]
    public class GcDiscoveryRewardLookupTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcDiscoveryRewardLookup> Table;
    }
}
