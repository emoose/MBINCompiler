using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcMissionSequenceWaitForConditions : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        /* 0x080 */ public GcMissionConditionTest ConditionTest;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x084 */ public byte[] Padding84;
        /* 0x088 */ public List<NMSTemplate> Conditions;
        [NMS(Size = 0x80)]
        /* 0x098 */ public string DebugText;
    }
}
