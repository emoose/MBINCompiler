using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x184, GUID = 0x4DFA5FFAAFE6B182, NameHash = 0x3C3DF65980E5A451)]
    public class GcMissionSequenceWaitForAbandFreighterDoorOpen : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        [NMS(Size = 0x80)]
        /* 0x080 */ public string MessageOvertime;
        /* 0x100 */ public float MinTime;
        [NMS(Size = 0x80)]
        /* 0x104 */ public string DebugText;
    }
}
