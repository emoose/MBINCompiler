using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD6B0AA1C2654A969, NameHash = 0x9160051E7F0A1295)]
    public class GcDiscoveryRewardLookupTable : NMSTemplate
    {
        /* 0x0 */ public List<GcDiscoveryRewardLookup> Table;
    }
}
