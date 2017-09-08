using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcWikiCategory : NMSTemplate       // size: 0x160
    {
        [NMS(Size = 0x20)]
        /* 0x000 */ public string CategoryID;
        [NMS(Size = 0x20)]
        /* 0x020 */ public string CategoryIDUpper;
        /* 0x040 */ public TkTextureResource IconOn;
        /* 0x0C4 */ public TkTextureResource IconOff;
        /* 0x148 */ public List<GcWikiTopic> Topics;
        /* 0x158 */ public GcWikiTopicType Type;        // I guess?
        /* 0x15C */ public int UnseenCount;
    }
}
