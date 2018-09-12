using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS( GUID = 0x37A021DF6D707809 )]
    public class GcRichPresenceGlobals : NMSTemplate
    {
        /* 0x0 */ public bool ShowOnScreen;
        /* 0x4 */ public float IdleThreshold;
        /* 0x8 */ public float EvaluationPeriod;
        /* 0xC */ public float PublishPeriod;
        /* 0x10 */ public int PlanetLocationPriority;
        /* 0x14 */ public int SpaceLocationPriority;
        /* 0x18 */ public int StormLocationPriority;
        /* 0x1C */ public int SpaceCombatPriority;
        /* 0x20 */ public int GameModePriority;
    }
}
