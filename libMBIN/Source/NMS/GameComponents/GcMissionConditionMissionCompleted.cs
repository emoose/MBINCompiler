namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8C2BF8C5C2322B2, NameHash = 0xC28C1E8A4FA47E3B)]
    public class GcMissionConditionMissionCompleted : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 MissionID;
        /* 0x10 */ public bool TakeIDFromSeasonData;
        /* 0x11 */ public bool CalculateTextMissionTargetFromStageIndex;
    }
}
