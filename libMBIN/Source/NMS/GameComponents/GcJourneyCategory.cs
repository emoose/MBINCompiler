using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x188, GUID = 0x768281F9DE5C50E6, NameHash = 0x88F1E142115EF824)]
    public class GcJourneyCategory : NMSTemplate
    {
        /* 0x000 */ public GcJourneyCategoryType Type;
        /* 0x004 */ public GcGameMode GameModeRestriction;
        /* 0x008 */ public GcMissionFaction Faction;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x00C */ public byte[] PaddingC;
        [NMS(Size = 0x20)]
        /* 0x010 */ public string NameIDLower;
        [NMS(Size = 0x20)]
        /* 0x030 */ public string NameIDUpper;
        [NMS(Size = 0x20)]
        /* 0x050 */ public string DescriptionID;
        /* 0x070 */ public TkTextureResource IconOn;
        /* 0x0F4 */ public TkTextureResource IconOff;
        /* 0x178 */ public List<GcJourneyMedal> Medals;
    }
}
