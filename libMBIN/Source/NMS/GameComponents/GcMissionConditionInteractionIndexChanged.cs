using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC3A1CFF177B8049F, NameHash = 0x42109FD0D90982DB)]
    public class GcMissionConditionInteractionIndexChanged : NMSTemplate
    {
        /* 0x0 */ public GcInteractionType InteractionType;
        /* 0x4 */ public GcAlienRace Race;
    }
}
