using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6ED3EBB059410E8E, NameHash = 0x51E0033396BF50C5)]
    public class GcMissionConditionUsingInteraction : NMSTemplate
    {
        /* 0x0 */ public GcInteractionType InteractionType;
        /* 0x4 */ public GcAlienRace Race;
        /* 0x8 */ public bool MustBeSelectedMission;
    }
}
