using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x4, GUID = 0xC34FAF27ADCE3397, NameHash = 0x29BC4AF5B8027FD)]
    public class TkBlackboardCategory : NMSTemplate
    {
        // size: 0x3
        public enum BlackboardCategoryEnum { Local, Archetype, PlayerControl }
        public BlackboardCategoryEnum BlackboardCategory;
    }
}
