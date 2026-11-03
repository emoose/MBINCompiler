using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAB38E948570A3950, NameHash = 0x9C18578D)]
    public class GcRewardRecycleAllObjInVolume : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<NMSString0x10> ExtraStats;
        [NMS(Index = 1)]
        /* 0x10 */ public int Value;
        [NMS(Index = 2)]
        /* 0x14 */ public bool DestroyObjectWhenFinished;
    }
}
