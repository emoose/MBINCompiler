using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7564546D97DAAB75, NameHash = 0x42109FD0D90982DB)]
    public class GcMissionConditionInteractionIndexChanged : NMSTemplate
    {
        /* 0x0 */ public GcInteractionType InteractionType;
        /* 0x4 */ public GcAlienRace Race;
    }
}
