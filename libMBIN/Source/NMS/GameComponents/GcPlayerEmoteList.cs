using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0xF2C0EAFAFA88D971)]
    public class GcPlayerEmoteList : NMSTemplate
    {
        /* 0x00 */ public List<GcPlayerEmote> Emotes;
    }
}
