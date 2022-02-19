using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x18, GUID = 0x9FB6DCD9030B3AF6, NameHash = 0xC546551B048ACC33)]
    public class GcAISpaceshipPreloadList : NMSTemplate
    {
        /* 0x0 */ public GcRealityCommonFactions Faction;
        /* 0x8 */ public List<GcAISpaceshipPreloadCacheData> Cache;
    }
}
