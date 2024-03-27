namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC5A9DABEAEFD7DEE, NameHash = 0x4E7A7CEB00A9346B)]
    public class GcTargetMissionSurveyOptions : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 TargetMissionSurveyId;
        /* 0x010 */ public bool TargetMissionSurveyDefinitelyExists;
        /* 0x011 */ public NMSString0x80 SurveyInactiveHint;
        /* 0x091 */ public NMSString0x80 SurveySwapHint;
        /* 0x111 */ public NMSString0x80 SurveyHint;
        /* 0x191 */ public NMSString0x80 SurveyVehicleHint;
    }
}
