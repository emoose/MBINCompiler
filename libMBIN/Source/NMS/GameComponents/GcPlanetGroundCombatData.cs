using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x716FD98360CC6074, NameHash = 0x301FA3AE)]
    public class GcPlanetGroundCombatData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public Vector2f FlybyTimer;
        [NMS(Index = 2)]
        /* 0x08 */ public Vector2f SentinelTimer;
        [NMS(Index = 1)]
        /* 0x10 */ public int MaxActiveDrones;
        [NMS(Index = 0)]
        /* 0x14 */ public GcPlanetSentinelLevel SentinelLevel;
    }
}
