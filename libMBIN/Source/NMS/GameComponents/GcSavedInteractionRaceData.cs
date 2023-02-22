using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x41001B1CCB31C2FF, NameHash = 0x9B192CD525C0A892)]
    public class GcSavedInteractionRaceData : NMSTemplate
    {
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x00 */ public int[] SavedRaceIndicies;
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x20 */ public bool[] HasLoopedIndicies;
    }
}
