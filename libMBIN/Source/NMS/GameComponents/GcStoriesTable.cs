using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x487FB87F8803BAD8, NameHash = 0x5213D4A36E989714)]
    public class GcStoriesTable : NMSTemplate
    {
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x0 */ public GcStoryCategory[] Table;
    }
}
