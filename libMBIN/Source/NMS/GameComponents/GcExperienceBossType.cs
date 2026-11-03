namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5CDF55937AD8D82C, NameHash = 0x817FBCEF)]
    public class GcExperienceBossType : NMSTemplate
    {
        // size: 0x3
        public enum ExperienceBossTypeEnum : uint {
            BugQueen,
            JellyBoss,
            SpookBoss,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ExperienceBossTypeEnum ExperienceBossType;
    }
}
