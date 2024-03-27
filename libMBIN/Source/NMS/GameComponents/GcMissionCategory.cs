namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x40D2D9150DBBFB0E, NameHash = 0x7C883BFCF9D557D5)]
    public class GcMissionCategory : NMSTemplate
    {
        // size: 0x5
        public enum MissionCategoryEnum : uint {
            Info,
            SelectableHint,
            Mission,
            Danger,
            Urgent,
        }
        /* 0x0 */ public MissionCategoryEnum MissionCategory;
    }
}
