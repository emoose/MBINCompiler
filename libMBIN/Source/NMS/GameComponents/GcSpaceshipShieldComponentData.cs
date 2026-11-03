namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCC7BB33C4BAC8872, NameHash = 0x408F1802)]
    public class GcSpaceshipShieldComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 ShieldID;
        [NMS(Index = 2)]
        /* 0x10 */ public bool IgnoreHitsWhenPlayerAimingElsewhere;
        [NMS(Index = 1)]
        /* 0x11 */ public bool RotateOnHit;
    }
}
