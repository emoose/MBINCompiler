using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0xCE7049D622C53DCA)]
    public class GcPlayerEmoteList : NMSTemplate
    {
        /* 0x00 */ public List<GcPlayerEmote> Emotes;
    }
}
