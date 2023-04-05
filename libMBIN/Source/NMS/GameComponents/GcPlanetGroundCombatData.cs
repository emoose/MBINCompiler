using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x258B7B9B1934FA6B, NameHash = 0xD04EA6F623D821D9)]
    public class GcPlanetGroundCombatData : NMSTemplate
    {
        /* 0x00 */ public GcPlanetSentinelLevel SentinelLevel;
        /* 0x04 */ public int MaxActiveDrones;
        /* 0x08 */ public Vector2f SentinelTimer;
        /* 0x10 */ public Vector2f FlybyTimer;
    }
}
