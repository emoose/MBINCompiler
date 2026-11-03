using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1E658BFD390D2F85, NameHash = 0x4A0C79E6)]
    public class GcSettlementJobDetails : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public GcSettlementJobGiftDetails Gifts;
        [NMS(Index = 1)]
        /* 0x40 */ public NMSString0x20A InTextTitle;
        [NMS(Index = 0)]
        /* 0x60 */ public NMSString0x20A PerkTitle;
        [NMS(Index = 2)]
        /* 0x80 */ public GcSettlementStatType Stat;
    }
}
