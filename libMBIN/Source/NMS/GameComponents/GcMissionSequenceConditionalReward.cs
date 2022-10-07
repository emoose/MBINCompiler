using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2108991F48DCA41F, NameHash = 0x4A3E875FBE0AEA1D)]
    public class GcMissionSequenceConditionalReward : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 RewardIfTrue;
        /* 0x10 */ public NMSString0x10 RewardIfFalse;
        /* 0x20 */ public GcMissionConditionTest ConditionTest;
        /* 0x28 */ public List<NMSTemplate> Conditions;
        /* 0x38 */ public NMSString0x80 DebugText;
    }
}
