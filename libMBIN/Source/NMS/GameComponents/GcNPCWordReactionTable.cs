using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7DA7BF701D66F28E, NameHash = 0x8998F482)]
    public class GcNPCWordReactionTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x0 */ public GcNPCWordReactionCategory[] Races;
    }
}
