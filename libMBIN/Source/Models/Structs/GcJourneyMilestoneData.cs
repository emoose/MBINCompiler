namespace libMBIN.Models.Structs
{
    public class GcJourneyMilestoneData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string JourneyMilestoneId;
        public int PointsToUnlock;
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;
        [NMS(Size = 0x20)]
        public string JourneyMilestoneTitle;
    }
}
