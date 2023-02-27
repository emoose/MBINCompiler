using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2F554A12B156BFF1, NameHash = 0x42109FD0D90982DB)]
    public class GcMissionConditionInteractionIndexChanged : NMSTemplate
    {
        /* 0x0 */ public GcInteractionType InteractionType;
        /* 0x4 */ public GcAlienRace Race;
    }
}
