namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2997545CCDDD9AC1, NameHash = 0xC28C1E8A4FA47E3B)]
    public class GcMissionConditionMissionCompleted : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 MissionID;
        /* 0x10 */ public int SeasonalMissionSeed;
        /* 0x14 */ public bool TakeIDFromSeasonData;
        /* 0x15 */ public bool CalculateTextMissionTargetFromStageIndex;
        /* 0x18 */ public int CalculateSeasonalSeedFromStageIndexOffset;
    }
}
