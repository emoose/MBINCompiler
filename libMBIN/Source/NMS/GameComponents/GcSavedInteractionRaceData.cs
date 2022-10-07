namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5DB65E13C5C3B1E, NameHash = 0x9B192CD525C0A892)]
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
        /* 0x0 */ public int[] SavedRaceIndicies;
    }
}
