using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x198, GUID = 0x0000000000000000, NameHash = 0x4E7A7CEB00A9346B)]
    public class GcTargetMissionSurveyOptions : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string TargetMissionSurveyId;
        /* 0x010 */ public bool TargetMissionSurveyDefinitelyExists;
        [NMS(Size = 0x80)]
        /* 0x011 */ public string SurveyInactiveHint;
        [NMS(Size = 0x80)]
        /* 0x091 */ public string SurveySwapHint;
        [NMS(Size = 0x80)]
        /* 0x111 */ public string SurveyHint;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x191 */ public string EndPadding;
    }
}
