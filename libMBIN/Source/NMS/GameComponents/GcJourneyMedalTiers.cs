namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x67F1E3E9EFB25F8C, NameHash = 0x58F824A5)]
    public class GcJourneyMedalTiers : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public int Bronze;
        [NMS(Index = 3)]
        /* 0x4 */ public int Gold;
        [NMS(Index = 0)]
        /* 0x8 */ public int None;
        [NMS(Index = 2)]
        /* 0xC */ public int Silver;
    }
}
