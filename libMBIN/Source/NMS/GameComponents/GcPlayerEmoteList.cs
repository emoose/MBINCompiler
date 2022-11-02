using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x690AB9F1C765E8F4, NameHash = 0x24E4352E3DDE4F22)]
    public class GcPlayerEmoteList : NMSTemplate
    {
        /* 0x0 */ public List<GcPlayerEmote> Emotes;
    }
}
