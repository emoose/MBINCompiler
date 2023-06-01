namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7D58868B17FADC8C, NameHash = 0xC28C1E8A4FA47E3B)]
    public class GcMissionConditionMissionCompleted : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 MissionID;
        /* 0x10 */ public int SeasonalMissionSeed;
        /* 0x14 */ public bool TakeIDFromSeasonData;
        /* 0x15 */ public bool CalculateTextMissionTargetFromStageIndex;
    }
}
