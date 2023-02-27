using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4531553B105E462, NameHash = 0xC546551B048ACC33)]
    public class GcAISpaceshipPreloadList : NMSTemplate
    {
        /* 0x0 */ public GcRealityCommonFactions Faction;
        /* 0x8 */ public List<GcAISpaceshipPreloadCacheData> Cache;
    }
}
