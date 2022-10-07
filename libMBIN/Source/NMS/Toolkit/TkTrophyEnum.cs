namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x53ACC709803EED2D, NameHash = 0xF50D34444AC02C1E)]
    public class TkTrophyEnum : NMSTemplate
    {
        // size: 0x6
        public enum TrophyEnum : uint {
            None = 0xFFFFFFFF,
            Trophy0 = 0x0,
            Trophy1 = 0x1,
            Trophy2 = 0x2,
            Trophy3 = 0x3,
            Trophy4 = 0x4
        }
        /* 0x0 */ public TrophyEnum Trophy;
    }
}
