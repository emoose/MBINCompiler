using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x610152F1A74AFD04, NameHash = 0x1FE5BC27)]
    public class GcSavedInteractionRaceData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x00 */ public int[] SavedRaceIndicies;
        [NMS(Index = 1, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x24 */ public bool[] HasLoopedIndicies;
    }
}
