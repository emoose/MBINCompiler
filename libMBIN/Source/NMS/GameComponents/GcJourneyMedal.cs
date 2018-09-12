using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x3B84F81C9B02B741)]
    public class GcJourneyMedal : NMSTemplate        // size: 0x214
    {
        /* 0x000 */ public GcJourneyMedalType Type;
        /* 0x004 */ public TkTextureResource None;
        /* 0x088 */ public TkTextureResource Bronze;
        /* 0x10C */ public TkTextureResource Silver;
        /* 0x190 */ public TkTextureResource Gold;
    }
}
