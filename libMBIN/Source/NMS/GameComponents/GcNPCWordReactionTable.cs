using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9553C1912E7347CF, NameHash = 0xB4578AF4AEBD0B11)]
    public class GcNPCWordReactionTable : NMSTemplate
    {
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x0 */ public GcNPCWordReactionCategory[] Races;
    }
}
