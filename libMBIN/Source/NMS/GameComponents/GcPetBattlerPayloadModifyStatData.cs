using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x52B547DB0C666110, NameHash = 0x9436331A)]
    public class GcPetBattlerPayloadModifyStatData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public NMSString0x20A LocIDToDescribeStat;
        [NMS(Index = 0)]
        /* 0x20 */ public GcPetBattlerStat StatToChange;
        [NMS(Index = 1)]
        /* 0x24 */ public bool OneRoundSupercharge;
        [NMS(Index = 2)]
        /* 0x25 */ public bool PositiveChange;
    }
}
