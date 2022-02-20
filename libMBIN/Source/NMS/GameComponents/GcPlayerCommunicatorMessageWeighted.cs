using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x58, GUID = 0x9958D4B116210267, NameHash = 0x3246DB9846FF8B70)]
    public class GcPlayerCommunicatorMessageWeighted : NMSTemplate
    {
        /* 0x00 */ public GcPlayerCommunicatorMessage Message;
        /* 0x50 */ public int Weight;
    }
}
