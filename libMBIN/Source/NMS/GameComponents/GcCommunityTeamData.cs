using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD83B169F7DC0AD0F, NameHash = 0xC2E194F8)]
    public class GcCommunityTeamData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A DescLocID;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x20A LocID;
        [NMS(Index = 4)]
        /* 0x40 */ public TkTextureResource Icon;
        [NMS(Index = 5)]
        /* 0x58 */ public NMSString0x10 PaletteID;
        [NMS(Index = 6)]
        /* 0x68 */ public NMSString0x10 ShipPaletteID;
        [NMS(Index = 0)]
        /* 0x78 */ public NMSString0x80 TeamID;
        [NMS(Index = 3)]
        /* 0xF8 */ public GcCommunityTeam EnumID;
    }
}
