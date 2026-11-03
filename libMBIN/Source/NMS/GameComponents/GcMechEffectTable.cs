using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x20C2AFD3E4A68232, NameHash = 0xA3418980)]
    public class GcMechEffectTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public GcMechEffect FootDust;
        [NMS(Index = 2)]
        /* 0x20 */ public GcMechEffect Jetpack;
        [NMS(Index = 3)]
        /* 0x40 */ public GcMechEffect JetpackLaunch;
        [NMS(Index = 4)]
        /* 0x60 */ public GcMechEffect JetpackLaunchGroundEffect;
        [NMS(Index = 1)]
        /* 0x80 */ public GcMechEffect LandingImpact;
    }
}
