namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC0D46638AF53103D, NameHash = 0xCD771E985A27F526)]
    public class GcMissionSequenceWaitForStatMilestone : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public NMSString0x10 Stat;
        // size: 0x3
        public enum MilestoneEnum : uint {
            Bronze,
            Silver,
            Gold,
        }
        /* 0x90 */ public MilestoneEnum Milestone;
        /* 0x94 */ public bool EveryMilestone;
        /* 0x95 */ public NMSString0x80 DebugText;
    }
}
