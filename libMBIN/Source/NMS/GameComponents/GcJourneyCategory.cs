using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6B7881FEB05B98C6, NameHash = 0x88F1E142115EF824)]
    public class GcJourneyCategory : NMSTemplate
    {
        /* 0x000 */ public GcJourneyCategoryType Type;
        /* 0x004 */ public GcGameMode GameModeRestriction;
        /* 0x008 */ public GcMissionFaction Faction;
        /* 0x010 */ public NMSString0x20A NameIDLower;
        /* 0x030 */ public NMSString0x20A NameIDUpper;
        /* 0x050 */ public NMSString0x20A DescriptionID;
        /* 0x070 */ public TkTextureResource IconOn;
        /* 0x0F4 */ public TkTextureResource IconOff;
        /* 0x178 */ public List<GcJourneyMedal> Medals;
    }
}
