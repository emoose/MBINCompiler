using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x67A6293BF5002055, NameHash = 0x5213D4A36E989714)]
    public class GcStoriesTable : NMSTemplate
    {
        // size: 0x8
        public enum TableEnum {
            Traders,
            Warriors,
            Explorers,
            Robots,
            Atlas,
            Diplomats,
            Exotics,
            None
        }
        [NMS(Size = 0x8, EnumType = typeof(TableEnum))]
        /* 0x0 */ public GcStoryCategory[] Table;
    }
}
