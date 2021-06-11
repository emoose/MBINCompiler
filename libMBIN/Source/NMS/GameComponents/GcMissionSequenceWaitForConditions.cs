using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x120, GUID = 0x447961099A4C8366, NameHash = 0x677779252EE27773)]
    public class GcMissionSequenceWaitForConditions : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public GcMissionConditionTest ConditionTest;
        /* 0x088 */ public List<NMSTemplate> Conditions;
        /* 0x098 */ public bool AllowedToFormatObjectives;
        /* 0x099 */ public NMSString0x80 DebugText;
        /* 0x11C */ public GcStatusMessageMissionMarkup StatusMessageMissionMarkup;
    }
}
