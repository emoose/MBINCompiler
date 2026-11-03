namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x11E556A7ED5C5E1C, NameHash = 0xAEFAC858)]
    public class GcTargetMissionSurveyOptions : NMSTemplate
    {
        [NMS(Index = 6)]
        /* 0x00 */ public NMSString0x20A SurveyHint;
        [NMS(Index = 4)]
        /* 0x20 */ public NMSString0x20A SurveyInactiveHint;
        [NMS(Index = 5)]
        /* 0x40 */ public NMSString0x20A SurveySwapHint;
        [NMS(Index = 7)]
        /* 0x60 */ public NMSString0x20A SurveyVehicleHint;
        [NMS(Index = 3)]
        /* 0x80 */ public NMSString0x10 TargetMissionSurveyDefinitelyExistsWithResourceHint;
        [NMS(Index = 0)]
        /* 0x90 */ public NMSString0x10 TargetMissionSurveyId;
        [NMS(Index = 2)]
        /* 0xA0 */ public bool ForceSurveyTextForAllSequencesInThisGroup;
        [NMS(Index = 1)]
        /* 0xA1 */ public bool TargetMissionSurveyDefinitelyExists;
    }
}
