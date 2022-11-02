using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB32F258074F1BAAC, NameHash = 0x33CAC73016241300)]
    public class GcJourneyMedal : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 LevelledStatID;
        /* 0x010 */ public NMSString0x20A MedalTitle;
        /* 0x030 */ public NMSString0x20A MedalProgressText;
        /* 0x050 */ public NMSString0x20A PinnedDescription;
        /* 0x070 */ public NMSString0x10 PinnedMission;
        /* 0x080 */ public GcStatType StatType;
        /* 0x084 */ public bool OverallJourneyDummy;
        /* 0x088 */ public TkTextureResource IconNone;
        /* 0x10C */ public TkTextureResource IconBronze;
        /* 0x190 */ public TkTextureResource IconSilver;
        /* 0x214 */ public TkTextureResource IconGold;
    }
}
