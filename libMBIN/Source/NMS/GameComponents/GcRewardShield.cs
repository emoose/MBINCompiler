namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD9CF1932CADF215B, NameHash = 0xE45E47B0)]
    public class GcRewardShield : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public int AmountMax;
        [NMS(Index = 0)]
        /* 0x4 */ public int AmountMin;
        [NMS(Index = 3)]
        /* 0x8 */ public bool ShowOSDOnFail;
        [NMS(Index = 2)]
        /* 0x9 */ public bool ShowOSDOnSuccess;
    }
}
