namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xE0D89F81B6637711, NameHash = 0x1829ECCC)]
    public class TkBlackboardCategory : NMSTemplate
    {
        // size: 0x3
        public enum BlackboardCategoryEnum : uint {
            Local,
            Archetype,
            PlayerControl,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public BlackboardCategoryEnum BlackboardCategory;
    }
}
