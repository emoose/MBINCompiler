namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x72F7CE03C69CB529, NameHash = 0x29BC4AF5B8027FD)]
    public class TkBlackboardCategory : NMSTemplate
    {
        // size: 0x3
        public enum BlackboardCategoryEnum {
            Local,
            Archetype,
            PlayerControl
        }
        /* 0x0 */ public BlackboardCategoryEnum BlackboardCategory;
    }
}
