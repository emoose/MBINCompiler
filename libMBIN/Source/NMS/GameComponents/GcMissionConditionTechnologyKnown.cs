namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x76DC726A8B85ACDC, NameHash = 0x1E4A17D964305DC4)]
    public class GcMissionConditionTechnologyKnown : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Technology;
        /* 0x10 */ public bool DependentOnSeasonMilestone;
        /* 0x11 */ public bool TakeTechFromSeasonData;
    }
}
