using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x668FCE5B1743986A, NameHash = 0x9562AF9028346F05)]
    public class GcSeasonalMilestoneEncryption : NMSTemplate
    {
        /* 0x000 */ public bool IsEncrypted;
        /* 0x008 */ public NMSString0x20A TitleUpper;
        /* 0x028 */ public NMSString0x20A Subtitle;
        /* 0x048 */ public NMSString0x20A Description;
        /* 0x068 */ public TkTextureResource Patch;
        /* 0x0EC */ public TkTextureResource HoverPopupIcon;
        /* 0x170 */ public NMSString0x10 DecryptMissionId;
        /* 0x180 */ public int DecryptMissionSeed;
    }
}
