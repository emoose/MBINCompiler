using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3E93D35AE55E0520, NameHash = 0x24E4352E3DDE4F22)]
    public class GcPlayerEmoteList : NMSTemplate
    {
        /* 0x0 */ public List<GcPlayerEmote> Emotes;
    }
}
