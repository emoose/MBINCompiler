using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x92FE105FDB7EE0FE, NameHash = 0xFCB8FED346EB142B)]
    public class GcMissionSequenceShowHintMessage : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public NMSString0x80 MessageTitle;
        /* 0x100 */ public NMSString0x10 InventoryHint;
        /* 0x110 */ public float InitialWaitTime;
        /* 0x114 */ public float HighPriorityTime;
        /* 0x118 */ public float SecondaryWaitTime;
        /* 0x11C */ public bool AllowedWhileInDanger;
        /* 0x120 */ public List<NMSTemplate> UseConditionsForTextFormatting;
        /* 0x130 */ public NMSString0x80 DebugText;
    }
}
