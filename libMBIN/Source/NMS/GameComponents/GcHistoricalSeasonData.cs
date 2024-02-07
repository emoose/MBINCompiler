using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAEC0B12984C1344, NameHash = 0x270ED26636E9BF5B)]
    public class GcHistoricalSeasonData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A SeasonName;
        /* 0x020 */ public NMSString0x20A SeasonNameUpper;
        /* 0x040 */ public int SeasonNumber;
        /* 0x044 */ public int RemixNumber;
        /* 0x048 */ public int DisplayNumber;
        /* 0x04C */ public TkTextureResource MainIcon;
        /* 0x0D0 */ public NMSString0x20 Description;
        /* 0x0F0 */ public NMSString0x10 FinalReward;
        /* 0x100 */ public NMSString0x20A UnlockedTitle;
    }
}
