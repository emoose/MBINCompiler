using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x100, GUID = 0x0A7D9D37A1A02B65, NameHash = 0xA3940C8D106BB96E)]
    public class GcMissionSequenceShowPodMessage : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x00 */ public string Message;
        [NMS(Size = 0x80)]
        /* 0x80 */ public string DebugText;
    }
}
