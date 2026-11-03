using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3517BE662CE4CC7D, NameHash = 0xFC02BD58)]
    public class GcPetBattlerPayloadStatDamageData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public NMSString0x20A LocIDToDescribeStat;
        [NMS(Index = 0)]
        /* 0x20 */ public GcPetBattlerPayloadAffinity Affinity;
        [NMS(Index = 1)]
        /* 0x28 */ public GcPetBattlerStat StatToReference;
        [NMS(Index = 2)]
        /* 0x2C */ public bool UseMyStats;
    }
}
