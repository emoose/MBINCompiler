using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x227913CF273E0496, NameHash = 0x3C8474F8)]
    public class GcMissionConditionSystemRace : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcAlienRace Race;
    }
}
