namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4F09C639611E170C, NameHash = 0xE1F7DF71)]
    public class GcMissionConditionTechnologyKnown : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Technology;
        [NMS(Index = 1)]
        /* 0x10 */ public bool DependentOnSeasonMilestone;
        [NMS(Index = 2)]
        /* 0x11 */ public bool TakeTechFromSeasonData;
    }
}
