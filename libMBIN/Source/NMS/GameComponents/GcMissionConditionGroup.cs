using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEB4EFC526207C00, NameHash = 0x3820751A1F86DB6)]
    public class GcMissionConditionGroup : NMSTemplate
    {
        /* 0x0 */ public GcMissionConditionTest ConditionTest;
        /* 0x8 */ public List<NMSTemplate> Conditions;
    }
}
