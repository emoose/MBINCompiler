using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCE13B97F5ADECE0C, NameHash = 0x42109FD0D90982DB)]
    public class GcMissionConditionInteractionIndexChanged : NMSTemplate
    {
        /* 0x0 */ public GcInteractionType InteractionType;
        /* 0x4 */ public GcAlienRace Race;
    }
}
