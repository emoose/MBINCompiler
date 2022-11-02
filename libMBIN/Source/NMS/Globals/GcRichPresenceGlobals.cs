namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xAABD3EED468AF125, NameHash = 0x9B12FDDE20DE4536)]
    public class GcRichPresenceGlobals : NMSTemplate
    {
        /* 0x00 */ public bool ShowOnScreen;
        /* 0x04 */ public float IdleThreshold;
        /* 0x08 */ public float EvaluationPeriod;
        /* 0x0C */ public float PublishPeriod;
        /* 0x10 */ public int PlanetLocationPriority;
        /* 0x14 */ public int SpaceLocationPriority;
        /* 0x18 */ public int StormLocationPriority;
        /* 0x1C */ public int SpaceCombatPriority;
        /* 0x20 */ public int GameModePriority;
    }
}
