namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBF9BF61E677AB05D, NameHash = 0x9B192CD525C0A892)]
    public class GcSavedInteractionRaceData : NMSTemplate
    {
        // size: 0x8
        public enum SavedRaceIndiciesEnum {
            Traders,
            Warriors,
            Explorers,
            Robots,
            Atlas,
            Diplomats,
            Exotics,
            None
        }
        [NMS(Size = 0x8, EnumType = typeof(SavedRaceIndiciesEnum))]
        /* 0x00 */ public int[] SavedRaceIndicies;
        // size: 0x8
        public enum HasLoopedIndiciesEnum {
            Traders,
            Warriors,
            Explorers,
            Robots,
            Atlas,
            Diplomats,
            Exotics,
            None
        }
        [NMS(Size = 0x8, EnumType = typeof(HasLoopedIndiciesEnum))]
        /* 0x20 */ public bool[] HasLoopedIndicies;
    }
}
