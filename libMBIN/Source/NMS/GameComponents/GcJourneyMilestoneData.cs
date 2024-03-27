namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE8BF2A6A86ADC900, NameHash = 0xC35BDABF76750407)]
    public class GcJourneyMilestoneData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 JourneyMilestoneId;
        /* 0x10 */ public int PointsToUnlock;
        /* 0x18 */ public NMSString0x20A JourneyMilestoneTitle;
        /* 0x38 */ public NMSString0x20A JourneyMilestoneTitleLower;
    }
}
